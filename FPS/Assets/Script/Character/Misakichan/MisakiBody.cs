using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisakiBody : MonoBehaviour
{
  GameObject Misaki;
  Misaki Script;
  Unitychan    Unitychan;
  Yuko　　　　　Yuko;
void Awake(){

//UnitychanAT = GameObject.//GameObject.Find("unitychan").GetComponent<Unitychan>();
      Misaki = transform.root.gameObject ;
      Script = Misaki.GetComponent<Misaki>();
      Unitychan = GameObject.Find("unitychan").GetComponent<Unitychan>();
      Yuko = GameObject.Find("Yuko").GetComponent<Yuko>();
}

void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(Script.AT);
    }else if(other.gameObject.tag=="UnitychanBall"){
      Script.TakeDamage(Unitychan.AT);
    }else if(other.gameObject.tag=="YukoBall"){
      Script.TakeDamage(Yuko.AT);
    }
  }
}
