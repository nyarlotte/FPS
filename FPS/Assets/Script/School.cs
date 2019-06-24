using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class School : MonoBehaviour
{

    //GameObject Unitychan;
    GameObject Misaki;
    GameObject Unitychan;
    Unitychan script;
    GameObject CPMisaki;
    void Awake (){
      Unitychan=(GameObject)Resources.Load("Unitychan");
      Misaki=(GameObject)Resources.Load("Misaki");
      CPMisaki=(GameObject)Resources.Load("CPMisaki");
      Setpos();
    }
    void Start (){
      script =Unitychan.GetComponent<Unitychan>();
    }
   void Update(){

      Debug.Log(script.HP);
    }

    void Setpos(){
      switch(PlayerPrefs.GetInt("Character")){
        case 0:
        Instantiate(Unitychan,new Vector3(0,0,0),Quaternion.identity);
        Instantiate(CPMisaki,new Vector3(10,0,10),Quaternion.identity);
        //Instantiate(CPYoko,new Vector3(49,0,2),Quaternion.identity);
              break;
        case 1:
        Instantiate(Misaki,new Vector3(0,0,0),Quaternion.identity);
              break;
      }

    }
}
