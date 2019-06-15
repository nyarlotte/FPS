using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusButton : MonoBehaviour
{
　　        Status2 PlayerScript;

    public GameObject Panel;
  public void Start(){
    PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();
  }
  public void ClickStatus(){
    Panel.SetActive(true);
  }
}
