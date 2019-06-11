using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
//--------------------------------------------------
    public　GameObject　apple;
            GameObject Player;
            Status2    script;
//--------------------------------------------------

      void Start(){
          Player = GameObject.Find("unitychan");
          script = Player.GetComponent<Status2>();
      }


                      //なんのコライダーに対して反応させるかを書く（オブジェクト名）
    void OnTriggerStay(Collider unitychan){
          //(中に書いたものと同じ.gameobject　タグ名)
          if (unitychan.gameObject.CompareTag("Player")){
              Debug.Log("近づいた");
         //クリック　Destroy
         //item　追加　リンゴ
          }
    }


    public void Get(){
      Destroy(gameObject);
        
      Debug.Log("リンゴを拾いました");
        script.Bug.Add("リンゴ");
    }
}
