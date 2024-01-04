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
      text_Timer.text = "30";
      LimitTime = 30;
    }

    // Update is called once per frame
    void Update()
    {
      if(LimitTime>0)

      {
      LimitTime -= Time.deltaTime;
      text_Timer.text = "Time: "+ Mathf.Round(LimitTime);
    }
      else{
        text_Timer.text="Time's up!";
        ChangeScene();
      }
    }
    void ChangeScene(){
      SceneManager.LoadScene("Timeout");
    }
}
