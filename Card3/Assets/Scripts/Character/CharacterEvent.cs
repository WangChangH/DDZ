using System;
using System.Collections.Generic;



public class CharacterEvent
{
    /// <summary>
    /// 初始化自身卡牌
    /// </summary>
    public const int INIT_MY_CARD = 0;
    /// <summary>
    /// 初始化左边玩家的卡牌
    /// </summary>
    public const int INIT_LEFT_CARD = 1;
    /// <summary>
    /// 初始化右边玩家的卡牌
    /// </summary>
    public const int INIT_RIGHT_CARD = 2;

    /// <summary>
    /// 自身玩家添加底牌
    /// </summary>
    public const int ADD_MY_CARD = 3;
    /// <summary>
    /// 左边玩家添加底牌
    /// </summary>
    public const int ADD_LEFT_CARD = 4;
    /// <summary>
    /// 右边玩家添加底牌
    /// </summary>
    public const int ADD_RIGHT_CARD = 5;

    /// <summary>
    /// 出牌
    /// </summary>
    public const int DEAL_CARD = 6;

    /// <summary>
    /// 移除自身手牌
    /// </summary>
    public const int REMOVE_MY_CARD = 7;
    /// <summary>
    /// 移除左边手牌
    /// </summary>
    public const int REMOVE_LEFT_CARD = 8;
    /// <summary>
    /// 移除右边手牌
    /// </summary>
    public const int REMOVE_RIGHT_CARD = 9;

    /// <summary>
    /// 更新桌面的显示
    /// </summary>
    public const int UPDATE_SHOW_DESK = 10;
}
