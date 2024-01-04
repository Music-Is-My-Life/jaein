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
        clickTxt.text = "클릭 수 : 0";
        fameTxt.text = "명성 : 0";
    }

    // Update is called once per frame


    public void Click()
    {
        ClickNum++;
        clickTxt.text ="클릭 수 :"+ ClickNum.ToString();
        Debug.Log("ClickNum: " + ClickNum);

        FameNum = ClickNum / 10; // FameNum을 Click 함수에서 갱신합니다.
        fameTxt.text = "명성 : "+FameNum.ToString();
        Debug.Log("FameNum: " + FameNum);

    }
    void Update()
    {
      PlayerPrefs.SetInt("Fame",FameNum);
    }
}
