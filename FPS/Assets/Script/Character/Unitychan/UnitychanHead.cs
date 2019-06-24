using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanHead : MonoBehaviour
{
        GameObject Unitychan;
        Unitychan Script;
        CPMisaki    Misaki;
        //Yuko　　　　　Yuko;
  void Awake(){
    Unitychan = transform.root.gameObject ;
    Script = Unitychan.GetComponent<Unitychan>();
    Misaki = GameObject.Find("CPMisaki").GetComponent<CPMisaki>();
    //Yuko = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="UnitychanBall"){
      Script.TakeDamage(Script.AT*1.5f);
    }else if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(Misaki.AT*1.5f);
    }else if(other.gameObject.tag=="YukoBall"){
      //Script.TakeDamage(Misaki.AT*1.5f);
    }
  }

}
