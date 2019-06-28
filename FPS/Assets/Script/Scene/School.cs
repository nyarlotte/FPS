using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School : MonoBehaviour
{

    GameObject Unitychan;

    void Awake (){
      Unitychan=(GameObject)Resources.Load("Kohaku");

      Setpos();
    }
    void Start (){

    }
   void Update(){

    }

    void Setpos(){
      switch(PlayerPrefs.GetInt("Character")){
        case 0:
        Instantiate(Unitychan,new Vector3(0,0,0),Quaternion.identity);
              break;
        case 1:
        //Instantiate(Misaki,new Vector3(0,0,0),Quaternion.identity);
              break;
      }

    }
}
