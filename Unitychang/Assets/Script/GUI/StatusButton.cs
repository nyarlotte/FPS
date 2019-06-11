using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusButton : MonoBehaviour
{
　　GameObject Player;
    Status2 script;

  public void Start(){
    Player = GameObject.Find("unitychan");
    script = Player.GetComponent<Status2>();


  }
  public void ClickStatus(){
  
        Debug.Log(script.HP);
  }
}
