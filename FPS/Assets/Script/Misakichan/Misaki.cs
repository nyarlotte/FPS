using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Misaki: MonoBehaviour
{
    public  float MaxHP=150;
    public  float AT;
    public  float HP= 100;
    public  float MisakiAbility;
    public  Text UiHP;
    public  Slider slider;


    //public  int CurrentHP;
    void Start(){
      HP =　MaxHP;
      Status();
    }

    public void Status(){//ステータス用関数
        AT = 65;
        MisakiAbility = 0.65f;
        //HP自動回復
        //受けるダメージ1.5倍
    }

    public void　TakeDamage(float amount){
      HP -= amount/*UnitychanAbility*/;
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
    /*      int HPUI =(int)HP  ;
          slider.maxValue = MaxHP;
          UiHP.text = "HP"+ HPUI.ToString()  + "/" + MaxHP.ToString();
          slider.value = HP;
    */
    }
}

//-----HPを回復させるなら--------------------------------
/*if(HP > MaxHP){
  //MaxHPを超えないように
   HP  = MaxHP;
}*/
