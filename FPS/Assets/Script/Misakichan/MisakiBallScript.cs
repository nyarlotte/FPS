using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    Character Attack;

    public float Damage;
    public GameObject Ball;
    void Awake(){
      Attack = GameObject.Find("unitychan").GetComponent<Character>();
      Damage = Attack.AT;
    }
}
