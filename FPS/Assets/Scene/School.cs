using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{
    public int aa ;
    //GameObject Unitychan;
    GameObject Misaki;
    GameObject Unitychan;

    void Awake (){
      aa = PlayerPrefs.GetInt("Character");
      Misaki=(GameObject)Resources.Load("Misaki");
      Unitychan=(GameObject)Resources.Load("Unitychan");
    }

    void Start(){
      Setpos(aa);
    }

    void Setpos(int bb){
      switch(bb){
        case 0:
        Instantiate(Unitychan,new Vector3(0,0,0),Quaternion.identity);
              break;
        case 1:
        Instantiate(Misaki,new Vector3(0,0,0),Quaternion.identity);
              break;
    }
  }
}
/*
Switch(PlayerPrefs.GetInt(“保存する名前”)){
    case 1:
        Player 1.SetActive(true);
        （ついでにここにプレイヤーの能力も書いておけます。）
    break;

    case 2:
        Player 2.SetActive(true);
    break;

    case 3:
        Player 3.SetActive(true);
    break;

    default :
    break;

    Switch(PlayerPrefs.GetInt("Character")){
      case 0: Instantiate(Unitychan,new Vector3(0,0,0),Quaternion.identity);
            break;
      case 1: Instantiate(Misaki,new Vector3(0,0,0),Quaternion.identity);
            break;
*/
