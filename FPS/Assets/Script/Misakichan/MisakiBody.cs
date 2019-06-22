using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisakiBody : MonoBehaviour
{
        Unitychan UnitychanAT;
        Misaki    MisakiAT;
        Yuko　　　　　YukoAT;
  void Awake(){
    UnitychanAT = GameObject.Find("unitychan").GetComponent<Unitychan>();
    MisakiAT = GameObject.Find("Misaki").GetComponent<Misaki>();
    YukoAT = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="UnitychanBall"){
      MisakiAT.TakeDamage(UnitychanAT.AT);
    }else if(other.gameObject.tag=="MisakiBall"){
      MisakiAT.TakeDamage(MisakiAT.AT);
    }else if(other.gameObject.tag=="YukoBall"){
      MisakiAT.TakeDamage(YukoAT.AT);
    }
  }
}
