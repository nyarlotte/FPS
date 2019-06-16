using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
  //Setactiveで非表示にしているのでFindで探すことができないためスクリプト自身にアタッチ
    //GameObject Menu;
    public GameObject Status;
    public GameObject Item;
    public GameObject Save;
    public GameObject Config;
    public GameObject Return;

    public void Click() {
      Status.SetActive(true);
      Item.SetActive(true);
      Save.SetActive(true);
      Config.SetActive(true);
      Return.SetActive(true);
      gameObject.SetActive(false);
      Debug.Log("押した");
    }

}
