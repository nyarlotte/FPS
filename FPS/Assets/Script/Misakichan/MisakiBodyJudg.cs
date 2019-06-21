using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyJudg : MonoBehaviour
{
  public float Damage;
  public BallScript Ball;
        Character BodyCollision;
  void Awake(){
    Ball = GameObject.Find("Ball").GetComponent<BallScript>();
    BodyCollision = GameObject.Find("unitychan").GetComponent<Character>();
  }

  void Start(){
    Debug.Log(BodyCollision.HP+"Unity");// HPは取れてる
  }
  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="Ball"){
      BodyCollision.TakeDamage(BodyCollision.AT); //Ball.Damege;
    }
  }

}
