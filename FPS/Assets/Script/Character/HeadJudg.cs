using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadJudg : MonoBehaviour
{
  public float Damege;
  public BallScript Ball;
         Character HeadCollision;
  void Awake(){
    Ball = GameObject.Find("Ball").GetComponent<BallScript>();
    HeadCollision = GameObject.Find("unitychan").GetComponent<Character>();
  }
    void OnTriggerEnter(Collider Other){
      if(Ball.gameObject.CompareTag("Ball")){
        HeadCollision.HP -= Ball.Damege*1.5f;
      }
    }
}
