using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnitychanStatus : MonoBehaviour
{
    public  int MaxHP = 150;　//maxHP
    public  int AT  =　50;
    public  int Speed  =　50;
    public  int HP = 100;
    public  Text UiHP;
    public  Slider slider;


    void Awake () {
	DontDestroyOnLoad(gameObject);　//シーン移動でゆにてぃちゃんが変化しないように
  slider = GameObject.Find("Slider").GetComponent<Slider>();
  UiHP   = GameObject.Find("HPText").GetComponent<Text>();
}
    //public  int CurrentHP;

    public void Status(){//ステータス用関数


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

//-----HPを回復させるなら--------------------------------
/*if(HP > MaxHP){
  //MaxHPを超えないように
   HP  = MaxHP;
}*/
