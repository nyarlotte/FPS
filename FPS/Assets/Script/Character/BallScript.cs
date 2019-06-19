using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Character Attck;

    public float Damege;
    public GameObject Ball;
    void awake(){
      Attck = GameObject.Find("unitychan").GetComponent<Character>();

    }

    void OnTriggerEnter(Collider other){
      if(gameObject.CompareTag("Player")){
         Attck.HP-=Damege;

      }
    }

    void start(){
      Debug.Log(Attck.HP);
    }

}
