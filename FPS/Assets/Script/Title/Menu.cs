using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
  [SerializeField]
  public GameObject  config;
  [SerializeField]
  public GameObject  text;
  [SerializeField]
   Text back;
  [SerializeField]
  public bool Check = false;
  public void Start(){
     config.SetActive(false);
  }
  public void PutConfig()
    {
      config.SetActive(!config.activeSelf);
      if(Check==true){
          back.text = "Config";
          Check = false;
      }else if(Check==false){
        back = text.GetComponent<Text>();
        back.text = "戻る";
        Check = true;
      }
    }
}
