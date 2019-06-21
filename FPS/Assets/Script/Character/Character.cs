using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character: MonoBehaviour
{
    public  float MaxHP=150;　//maxHP
    public  float AT;
    public  int Speed;
    public  float HP= 100;
    public  float UnitychanAbility;
    public  int Shoot;
    public  int Reload;
    public  int[] Carry;
    public  Text UiHP;
    public  Slider slider;
                      BodyJudg BodyCollision;
                      HeadJudg HeadCollision;
                      BallScript BallDamage;
    void Awake () {
      //Status();
      BodyCollision = GameObject.Find("BodyJudge").GetComponent<BodyJudg>();
      HeadCollision = GameObject.Find("HeadJudge").GetComponent<HeadJudg>();
      BallDamage    = GameObject.Find("Ball").GetComponent<BallScript>();

}
    //public  int CurrentHP;
    void Start(){
      HP =　MaxHP;
      Status();
    }
    public void Status(){//ステータス用関数
        AT = 45;
        Speed　=　5;
        Shoot　=　1000;
        Reload　=　5;
        int[] Carry = new int[5];
        UnitychanAbility = 0.65f;
    }

    public void　TakeDamage(float amount){
      HP -= amount*UnitychanAbility;
    }

    public void HPGuI(){
      //HPをGUIに表示させるため
      int HPUI =(int)HP  ;
      slider.maxValue = MaxHP;
      UiHP.text = "HP"+ HPUI.ToString()  + "/" + MaxHP.ToString();
      slider.value = HP;
    }
    void Update(){
      //毎フレーム変化していくだろうモノをぶち込む
      TakeDamage(0);
      Death();
      HPGuI();
      Debug.Log("UnityちゃんのHPは"+HP);
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
