using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unitychan: MonoBehaviour
{
    public  float MaxHP=150;　//maxHP
    public  float AT;
    //public  int Speed;
    public  float HP= 100;
    public  float UnitychanAbility;
    //public  int Shoot;
    //public  int Reload;
    //public  int[] Carry;
    public  Text UiHP;
    public  Slider slider;
            UnitychanBody BodyCollision;
            UnitychanHead HeadCollision;
                      //BallScript BallDamage;
/*    void Awake () {
      //Status();
      //BodyCollision = GameObject.Find("UnitychanBody").GetComponent<UnitychanBody>();
      //HeadCollision = GameObject.Find("UnitychanHead").GetComponent<UnitychanHead>();
      //BallDamage    = GameObject.Find("Ball").GetComponent<BallScript>();

}*/
    //public  int CurrentHP;
    void Start(){
      HP =　MaxHP;
      Status();
    }

    public void Status(){//ステータス用関数
        AT = 45;
        UnitychanAbility = 0.65f;
    }

    public void　TakeDamage(float amount){
      HP -= amount*UnitychanAbility;
    }

    void Update(){
      Death();
      HPGuI();
    }

    public void Death(){
      if(HP <= 0 ){
        Destroy(gameObject);
      }
    }

    public void HPGuI(){
          //HPをGUIに表示させるため
          int HPUI =(int)HP  ;
          slider.maxValue = MaxHP;
          UiHP.text = "HP"+ HPUI.ToString()  + "/" + MaxHP.ToString();
          slider.value = HP;
    }
}

//-----HPを回復させるなら--------------------------------
/*if(HP > MaxHP){
  //MaxHPを超えないように
   HP  = MaxHP;
}*/
