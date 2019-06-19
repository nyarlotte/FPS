using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyJudg : MonoBehaviour
{
  public float Damege;
  public BallScript Ball;
        Character BodyCollision;
  void Awake(){
    Ball = GameObject.Find("Ball").GetComponent<BallScript>();
    BodyCollision = GameObject.Find("unitychan").GetComponent<Character>();

  }
  void OnTriggerEnter(Collider Other){
    if(Ball.gameObject.CompareTag("Ball")){
      BodyCollision.HP -= Ball.Damege; //Ball.Damege;
      Debug.Log("Hit");
    }
  }
}
