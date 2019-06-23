using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanHead : MonoBehaviour
{
        GameObject Unitychan;
        Unitychan Script;
        Misaki    MisakiAT;
        Yuko　　　　　YukoAT;
  void Awake(){


    Unitychan = transform.root.gameObject ;
    Script = Unitychan.GetComponent<Unitychan>();
    MisakiAT = GameObject.Find("CPMisaki").GetComponent<Misaki>();
    YukoAT = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="UnitychanBall"){
      Script.TakeDamage(Script.AT*1.5f);
    }else if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(MisakiAT.AT*1.5f);
    }else if(other.gameObject.tag=="YukoBall"){
      Script.TakeDamage(MisakiAT.AT*1.5f);
    }
  }

}
