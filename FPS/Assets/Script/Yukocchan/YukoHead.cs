using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukoHead : MonoBehaviour
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
          YukoAT.TakeDamage(UnitychanAT.AT*1.5f);
        }else if(other.gameObject.tag=="MisakiBall"){
          YukoAT.TakeDamage(MisakiAT.AT*1.5f);
        }else if(other.gameObject.tag=="YukoBall"){
          YukoAT.TakeDamage(YukoAT.AT*1.5f);
        }
    }
}
