using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisakiHead : MonoBehaviour
{
  GameObject Misaki;
  Misaki Script;
  Unitychan    Unitychan;
  Yuko　　　　　YukoAT;
void Awake(){

//UnitychanAT = GameObject.//GameObject.Find("unitychan").GetComponent<Unitychan>();
      Misaki = transform.root.gameObject ;
      Script = Misaki.GetComponent<Misaki>();
      Unitychan = GameObject.Find("unitychan").GetComponent<Unitychan>();
      YukoAT = GameObject.Find("Yuko").GetComponent<Yuko>();
}

void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(Script.AT*1.5f);
    }else if(other.gameObject.tag=="UnitychanBall"){
      Script.TakeDamage(Unitychan.AT*1.5f);
    }else if(other.gameObject.tag=="YukoBall"){
      Script.TakeDamage(YukoAT.AT*1.5f);
    }
}
}
