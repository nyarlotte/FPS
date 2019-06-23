using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SchoolPawn : MonoBehaviour
{
  GameObject Unitychan;
  GameObject Misaki;
  void Awake (){
    Unitychan =(GameObject)Resources.Load("Respawn");
    Misaki=(GameObject)Resources.Load("Respawn");
  }
public void  ResPawan(int Character){
    if(Character == 0){
      Instantiate(Unitychan);
    }else if(Character == 1){
    Instantiate(Misaki);
    }
  }
}
