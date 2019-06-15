using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotSpring : MonoBehaviour
{
        Status2 PlayerScript;

    void Start()
    {
      PlayerScript = GameObject.Find("unitychan").GetComponent<Status2>();
    }

    void OnTriggerStay(Collider unitychan){
         if (unitychan.gameObject.CompareTag("Player")){
                  PlayerScript.HP++ ;
            //Debug.Log (script.HP);
         }
    }
}
