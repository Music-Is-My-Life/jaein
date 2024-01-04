using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class fame : MonoBehaviour
{
  public TMP_Text Fame;
    // Start is called before the first frame update
    void Start()
    {
      Fame.text = "증가한 명성: "+ PlayerPrefs.GetInt("Fame").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
