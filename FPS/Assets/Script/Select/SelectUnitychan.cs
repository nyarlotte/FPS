using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectUnitychan : MonoBehaviour
{
  public GameObject Select;
    public bool   Unitychan = false;
public void SelectCharacter(){

  Select.SetActive(true);
  Unitychan = true;
  Debug.Log(Unitychan);
  MoveScene();
}

public void MoveScene (){
  PlayerPrefs.SetInt("Character",0);

  SceneManager.LoadScene("School");

}
}
