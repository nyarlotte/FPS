using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpring : MonoBehaviour
{
  //  ユニちゃんの変数HPを取るための変数　パブリックにしてアタッチするのもいいのかな
        Status2 PlayerScript;
    void Start()
    {                 //ゲームオブジェクトとコンポーネントを探す
                      //おそらく変数をパブリックにしてアタッチしたほうがFindを使わない分動作が軽くなるかも
                      //ただしスクリプトすべてにアタッチする必要がありそう
      PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();
    }

    //　OnTriggerStay　コライダーに侵入している間呼び続ける　かっこの中は何が入ってきたらこれを呼ぶのか？という条件

    void OnTriggerStay(Collider unitychan){
         if (unitychan.gameObject.CompareTag("Player")){
          //ここに入っている間はHPが増え続ける
                  PlayerScript.HP++ ;
            //Debug.Log (script.HP);
         }
    }
}
