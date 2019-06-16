using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
  //トリガーに入ったら呼び出される関数
  void OnTriggerEnter(Collider unitychan)
  {
              //タグ"Player"が設定されているものが入ったら
      if (unitychan.gameObject.CompareTag("Player")){
            //シーン移動
          SceneManager.LoadScene ("NewScene");
            /*  シーン移動した際の座標をここで設定
                この書き方でワープのように移動させることが可能
            */
          GameObject.Find("unitychan").transform.position = new Vector3 (-1,0,3);
        }
}
}
