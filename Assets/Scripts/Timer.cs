using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float LimitTime;
    public TMP_Text text_Timer;


    void Start()
    {
      text_Timer.text = "10";
      LimitTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
      if(LimitTime>0)

      {
      LimitTime -= Time.deltaTime;
      text_Timer.text = "남은 시간 : "+ Mathf.Round(LimitTime);
    }
      else{

        ChangeScene();
      }
    }
    void ChangeScene(){
      SceneManager.LoadScene("Timeout");
    }
}
