using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
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
      slider.maxValue = Script.HP;
      }
    void Start (){

    }
   void Update(){
     HPbar();
     EnemyManeger();
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

        UIHP.text = "HP"+ Script.HP.ToString() + "/" + slider.maxValue.ToString();
        slider.value = Script.HP;
        if(Script.HP< 0){
          Script.HP = 0;
        }
    }
    void EnemyManeger() {
      if (!GameObject.FindGameObjectWithTag("Player") && GameObject.FindGameObjectWithTag("Enemy")) {
            PlayerPrefs.SetInt("Result", 0);
            SceneManager.LoadScene("Result");
      } else if (GameObject.FindGameObjectWithTag("Player") && !GameObject.FindGameObjectWithTag("Enemy")) {
          PlayerPrefs.SetInt("Result", 1);
          SceneManager.LoadScene("Result");
      }
    }
}
