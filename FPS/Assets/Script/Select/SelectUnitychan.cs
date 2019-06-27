using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectUnitychan : MonoBehaviour
{
  public GameObject Select;
  public GameObject panel;
  public GameObject UnitychanText;
          Text textttt;
  public bool   Unitychan = false;

public void Start (){
  textttt =UnitychanText.GetComponent<Text>();
}

public void SelectCharacter(){
  Select.SetActive(true);
  panel.SetActive(true);
  textttt.text = "unitychan-dayo";
  Debug.Log(Unitychan);
  PlayerPrefs.SetInt("Character",0);
}


}
