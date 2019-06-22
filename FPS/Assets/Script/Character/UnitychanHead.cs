using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanHead : MonoBehaviour
{
         Unitychan UnitychanAT;
         Misaki       MisakiAT;
         Yuko　　　　　YukoAT;
  void Awake(){

    UnitychanAT = GameObject.Find("unitychan").GetComponent<Unitychan>();
    MisakiAT = GameObject.Find("Misaki").GetComponent<Misaki>();
    YukoAT = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag=="UnitychanBall"){
          UnitychanAT.TakeDamage(UnitychanAT.AT*1.5f);
        }else if(other.gameObject.tag=="MisakiBall"){
          UnitychanAT.TakeDamage(MisakiAT.AT*1.5f);
        }else if(other.gameObject.tag=="YukoBall"){
          UnitychanAT.TakeDamage(MisakiAT.AT*1.5f);
        }
    }
}
