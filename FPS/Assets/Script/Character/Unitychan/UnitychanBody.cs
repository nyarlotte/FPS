using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanBody : MonoBehaviour
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
      Script.TakeDamage(Script.AT);
    }else if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(Misaki.AT);
    }else if(other.gameObject.tag=="YukoBall"){
    //  Script.TakeDamage(Yuko.AT);
    }
  }

}
