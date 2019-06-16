using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusButton : MonoBehaviour
{
  //ユニちゃんのHPを表示するためのシート
　　        Status2 PlayerScript;

    public GameObject Panel;
  public void Start(){
    PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();
  }
  //現状これで表示できるのだが、例えば
  //パネルを表示したまま戻るボタンを押されると次回開くときにこれが開きっぱなしになっていたので後日修正
  public void ClickStatus(){
    Panel.SetActive(true);
  }
}
