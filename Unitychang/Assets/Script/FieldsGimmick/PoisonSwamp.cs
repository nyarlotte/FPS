using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSwamp : MonoBehaviour
{
        GameObject Player;
        Status2    script;
    void Start()
    {
        Player = GameObject.Find("unitychan");
        script = Player.GetComponent<Status2>();
    }

    void OnTriggerStay(Collider unitychan){

         if (unitychan.gameObject.CompareTag("Player")){

            script.HP-- ;
            Debug.Log (script.HP);
         }
    }
}
