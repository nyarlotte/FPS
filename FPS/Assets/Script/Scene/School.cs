using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class School : MonoBehaviour
{

    GameObject Unitychan;
    public  Slider slider;
    public  Text UIHP;
    [SerializeField] GameObject[] Player;
          Status Script ;
    void Awake (){
      Unitychan=(GameObject)Resources.Load("Kohaku");
      Setpos();
      slider = GameObject.Find("Slider").GetComponent<Slider>();
      Player = GameObject.FindGameObjectsWithTag("Player");
      Script = Player[0].GetComponent<Status>();

      }
    void Start (){

    }
   void Update(){
     HPbar();
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
    void HPbar(){
        slider.maxValue = Script.HP;
        UIHP.text = "HP"+ Script.HP.ToString() + "/" + Script.HP.ToString();
        slider.value = Script.HP;
    }
}
