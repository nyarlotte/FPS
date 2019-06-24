using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CPMisakiBody : MonoBehaviour
{
    GameObject CPMisaki;
    CPMisaki Script;
    Unitychan    Unitychan;
    //Yuko　　　　　Yuko;
  void Start(){
    CPMisaki = transform.root.gameObject ;
    Script = CPMisaki.GetComponent<CPMisaki>();
    Unitychan = GameObject.Find("unitychan").GetComponent<Unitychan>();
    //Yuko = GameObject.Find("Yuko").GetComponent<Yuko>();
  }

  void OnTriggerEnter(Collider other){
    if(other.gameObject.tag=="MisakiBall"){
      Script.TakeDamage(Script.AT);
    }else if(other.gameObject.tag=="UnitychanBall"){
      Script.TakeDamage(Unitychan.AT);
    }else if(other.gameObject.tag=="YukoBall"){
    //  Script.TakeDamage(Yuko.AT);
    }
  }
}
