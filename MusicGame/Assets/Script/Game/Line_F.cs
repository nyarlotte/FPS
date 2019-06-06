using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_F : MonoBehaviour{


      void update(){

        }


    	void OnTriggerStay(Collider Note){　//コライダーに触れている間

        if(Note.gameObject.CompareTag("Note")){ //もしゲームオブジェクトのタグがNoteなら

            if(Input.GetKeyDown(KeyCode.F)){  //もしキーボードのＡを押したら

                Destroy(Note.gameObject);　//デストロイ
                Debug.Log("Good");　//確認用デバッグ
            }
    	  }
    }
}
