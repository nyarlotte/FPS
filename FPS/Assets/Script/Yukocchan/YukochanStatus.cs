using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class YukochanStatus : MonoBehaviour
{
    public  int MaxHP = 150;　//maxHP
    public  int AT;
    public  int HP = 100;
    public  Text UiHP;
    public  Slider slider;
    public  List<string> Bug = new List<string>();

    void Awake () {
	DontDestroyOnLoad(gameObject);　//シーン移動でゆにてぃちゃんが変化しないように
  slider = GameObject.Find("Slider").GetComponent<Slider>();
  UiHP   = GameObject.Find("HPText").GetComponent<Text>();
}
    //public  int CurrentHP;

    public void Status(){//ステータス用関数

      if(HP > MaxHP){
        //MaxHPを超えないように
         HP  = MaxHP;
      }
    }


    public void HPGuI(){
      //スライダーのGUIを表示させるための
      slider.maxValue = MaxHP;
      UiHP.text = "HP"+ HP.ToString() + "/" + MaxHP.ToString();
      slider.value = HP;

    }
    void Update(){
      //毎フレーム変化していくだろうモノをぶち込む
      Death();
      Status();
      HPGuI();
    }

    public void Death(){//ゲームオーバー用の関数
      if(HP <= 0 ){
        Destroy(gameObject);

      }
    }

　
}
