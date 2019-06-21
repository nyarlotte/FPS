using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadJudg : MonoBehaviour
{
  public float Damage;
  public BallScript Ball;
         Character HeadCollision;
  void Awake(){
    Ball = GameObject.Find("Ball").GetComponent<BallScript>();
    HeadCollision = GameObject.Find("unitychan").GetComponent<Character>();
  }
    void OnTriggerEnter(Collider other){
      if(Ball.gameObject.CompareTag("Ball")){
        HeadCollision.TakeDamage(HeadCollision.AT*1.5f);
        Debug.Log("HeadHit");
      }
    }
}
