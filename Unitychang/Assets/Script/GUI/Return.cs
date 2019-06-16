using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
  //Menuで表示したものを元に戻すためのスクリプト
  //一つにまとめてOnclickに設定しても関数が同時に2つは知ってしまっていたのでこういう形にしてみた
    public GameObject Status;
    public GameObject Item;
    public GameObject Save;
    public GameObject Config;
    public GameObject Menu;

  public void Click2() {
    Status.SetActive(false);
    Item.SetActive(false);
    Save.SetActive(false);
    Config.SetActive(false);
    gameObject.SetActive(false);
    Menu.SetActive(true);
    Debug.Log("そのメニュー、消えるよ");
  }
}
