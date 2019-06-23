using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YukoBody : MonoBehaviour
{
        Unitychan UnitychanAT;
        Misaki    MisakiAT;
        Yuko      YukoAT;
  void Awake(){

    UnitychanAT = GameObject.Find("unitychan").GetComponent<Unitychan>();
    MisakiAT = GameObject.Find("Misaki").GetComponent<Misaki>();
    YukoAT = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="UnitychanBall"){
      YukoAT.TakeDamage(UnitychanAT.AT);
    }else if(other.gameObject.tag=="MisakiBall"){
      YukoAT.TakeDamage(MisakiAT.AT);
    }else if(other.gameObject.tag=="YukoBall"){
      YukoAT.TakeDamage(YukoAT.AT);
    }
  }
}
