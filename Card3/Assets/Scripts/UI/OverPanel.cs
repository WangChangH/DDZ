﻿using Protocol.Code;
using Protocol.Constant;
using Protocol.Dto.Fight;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// y游戏结束面板
/// </summary>
public class OverPanel : UIBase
{
    private void Awake()
    {
        Bind(UIEvent.SHOW_OVER_PANEL);
    }

    public override void Execute(int eventCode, object message)
    {
        switch (eventCode)
        {
            case UIEvent.SHOW_OVER_PANEL:
                refreshPanel(message as OverDto);
                break;
            default:
                break;
        }
    }

    private Text txtWinIdentity;
    private Text txtWinBeen;
    private Button btnBack;
    private Button btnContine;

    // Use this for initialization
    void Start()
    {
        
        txtWinIdentity = transform.Find("txtWinIdentity").GetComponent<Text>();
        txtWinBeen = transform.Find("txtWinBeen").GetComponent<Text>();
        btnBack = transform.Find("btnBack").GetComponent<Button>();
        btnBack.onClick.AddListener(backClick);
        btnContine = transform.Find("btnContine").GetComponent<Button>();
        btnContine.onClick.AddListener(ContineClick);
        setPanelActive(false);
    }

    /// <summary>
    /// 刷新显示
    /// </summary>
    private void refreshPanel(OverDto dto)
    {
        setPanelActive(true);

        ////显示谁胜利
        //txtWinIdentity.text = Identity.GetString(dto.WinIdentity);
        ////判断自己是否胜利
        //if (dto.WinUIdList.Contains(Models.GameModel.Id))
        //{
        //    txtWinIdentity.text = "胜利";
        //    txtWinBeen.text = "欢乐豆：+";
        //}
        //else
        //{
        //    //失败
        //    txtWinIdentity.text  ="失败";
        //    txtWinBeen.text = "欢乐豆：-";
        //}
        ////显示豆子数量
        //txtWinBeen.text += dto.BeenCount;

          if (dto.WinUIdList.Contains(Models.GameModel.Id))
        {
            if (dto.WinIdentity == Identity.LANDLORD)
            {
                txtWinIdentity.text = "胜利";
                txtWinBeen.text = "欢乐豆：+";
                //显示豆子数量
                txtWinBeen.text += dto.BeenCount * 2;
            }
            else
            {
                txtWinIdentity.text = "胜利";
                txtWinBeen.text = "欢乐豆：+";
                txtWinBeen.text += dto.BeenCount;
            }
        }
        else
        {
            if (dto.WinIdentity != Identity.LANDLORD)
            {
                txtWinIdentity.text = "失败";
                txtWinBeen.text = "欢乐豆：-";
                //显示豆子数量
                txtWinBeen.text += dto.BeenCount*2;
            }
            else if (dto.WinIdentity != Identity.FARMER)
            {
                txtWinIdentity.text = "失败";
                txtWinBeen.text = "欢乐豆：-";
                //显示豆子数量
                txtWinBeen.text += dto.BeenCount;
            }    
        }              
    }

    /// <summary>
    /// 返回点击事件
    /// </summary>
    private void backClick()
    {
        LoadSceneMsg msg = new LoadSceneMsg(1,
                 delegate ()
                 {
                     //向服务器获取信息
                     SocketMsg socketMsg = new SocketMsg(OpCode.USER, UserCode.GET_INFO_CREQ, null);
                     Dispatch(AreaCode.NET, 0, socketMsg);
                     //Debug.Log("加载完成！");
                 });
        Dispatch(AreaCode.SCENE, SceneEvent.LOAD_SCENE, msg);
    }
    /// <summary>
    /// 继续游戏事件
    /// </summary>
    private void ContineClick()
    {
        LoadSceneMsg msg = new LoadSceneMsg(2,
          delegate()
          {
              //向服务器获取信息
              SocketMsg socketMsg = new SocketMsg(OpCode.USER, UserCode.GET_INFO_CREQ, null);
              Dispatch(AreaCode.NET, 0, socketMsg);
              //SocketMsg socketMsg1 = new SocketMsg(OpCode.MATCH, MatchCode.READY_CREQ, null);
              //Dispatch(AreaCode.NET, 0, socketMsg1);
              // Dispatch(AreaCode.UI, UIEvent.PLAYER_HIDE_STATE, null);
              //Debug.Log("加载完成！");
              socketMsg.Change(OpCode.MATCH, MatchCode.KUAISUPIPEI, null);//改动
              Dispatch(AreaCode.NET, 0, socketMsg);
          });
        Dispatch(AreaCode.SCENE, SceneEvent.LOAD_SCENE, msg);
    }
}
