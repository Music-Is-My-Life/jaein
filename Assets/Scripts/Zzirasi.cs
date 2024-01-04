using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Zzirasi : MonoBehaviour
{
    public int ClickNum;
    public int FameNum;
    public TMP_Text clickTxt;
    public TMP_Text fameTxt;

    void Start()
    {
        ClickNum = 0;
        FameNum = 0;
        clickTxt.text = "0";
        fameTxt.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void Click()
    {
        ClickNum++;
        clickTxt.text = ClickNum.ToString();
        Debug.Log("ClickNum: " + ClickNum);
        FameNum = ClickNum / 10; // FameNum을 Click 함수에서 갱신합니다.
        fameTxt.text = FameNum.ToString();
        Debug.Log("FameNum: " + FameNum);
    }
}
