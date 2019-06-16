using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanBullet : MonoBehaviour
{       //詳しくはHotSpring.cs　参照
        public GameObject Player;
        MisakichanStatus PlayerScript;
    void Start()
    {
        PlayerScript = GameObject.Find("Misaki").GetComponent<MisakichanStatus>();

    }

    void OnTriggerEnter(Collider other){

         if (Player.gameObject.CompareTag("Player")){
            //HPが減り続ける
            PlayerScript.HP -=20 ;
            Debug.Log (PlayerScript.HP);

    }
}
}
