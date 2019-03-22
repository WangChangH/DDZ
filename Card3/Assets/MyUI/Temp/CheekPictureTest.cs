using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CheekPictureTest : MonoBehaviour
{

    Image MyImage;
    string ImagePath;
    Sprite[] s;
    void Start()
    {
        MyImage = GetComponent<Image>();
        ImagePath = "Identity/AllPelple";
        s = Resources.LoadAll<Sprite>(ImagePath);
        test();
        Destroy(gameObject);
        GetComponent<CheekPictureTest>().enabled = false;
    }
    void test()
    {
        MyImage.sprite = s[112];
    }

}
