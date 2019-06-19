using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSwamp : MonoBehaviour
{       //詳しくはHotSpring.cs　参照
        Status2 PlayerScript;
    void Start()
    {
        PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();

    }

    void OnTriggerStay(Collider unitychan){

         if (unitychan.gameObject.CompareTag("Player")){
            //HPが減り続ける
            PlayerScript.HP-- ;
            Debug.Log (PlayerScript.HP);
         }
    }
}
