using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
  　/*    HotSpringを別の書き方にしたばーじょん
    //　　プレイヤーでオブジェクトを変数に入れて
    //　　Status2=スクリプト名のデータ型でコンポーネントを格納している
    //　　コンポーネントを２つ、3つと探す際にはこういうか空き方のほうがいいと思う
    //　　作成途中
    */　　
  GameObject Player;
  Status2    script;
  void Start()
  {
    Player = GameObject.Find("unitychan");
    script = Player.GetComponent<Status2>();
  }
    public void ItemClick(){

    /*  if(script.Bug[0]=="") {
          Debug.Log("何も入っていません");
        }　else　{
          Debug.Log(script.Bug[script.i]+"が入っています。");
      }
    */
    //script.Bug[0]="リンゴ";
  /*   if(script.Bug[0]=="") {
          Debug.Log("何も入っていません");
        }　else {
          Debug.Log(script.Bug[0]+"が入っています。");
      }

      if(script.Bug[1]=="") {
           Debug.Log("何も入っていません");
         }　else {
           Debug.Log(script.Bug[1]+"が入っています。");
       }

       if(script.Bug[2]=="") {
            Debug.Log("何も入っていません");
          }　else {
            Debug.Log(script.Bug[2]+"が入っています。");
        }
*/
if(script.Bug[0]=="リンゴ") {
    Debug.Log(script.Bug[0]+"が入っています。");
    Debug.Log(script.Bug[0]);
  } else if(script.Bug[1]=="リンゴ"){
    Debug.Log(script.Bug[1]+"が入っています。");
    Debug.Log(script.Bug[1]);
  } else if(script.Bug[2]=="リンゴ"){
    Debug.Log(script.Bug[2]+"が入っています。");
    Debug.Log(script.Bug[2]);
  }


    }
}
