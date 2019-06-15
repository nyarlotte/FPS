using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonSwamp : MonoBehaviour
{
        Status2 PlayerScript;
      //  Status2    script;
    void Start()
    {
        PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();
      //  script = Player;
    }

    void OnTriggerStay(Collider unitychan){

         if (unitychan.gameObject.CompareTag("Player")){

            PlayerScript.HP-- ;
            Debug.Log (PlayerScript.HP);
         }
    }
}
