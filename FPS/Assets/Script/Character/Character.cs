using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Character: MonoBehaviour
{
    public  float MaxHP　=150;　//maxHP
    public  float AT;
    public  int Speed;
    public  float HP;
    public  int Shoot;
    public  int Reload;
    public  int[] Carry;
    public  Text UiHP;
    public  Slider slider;
                      BodyJudg BodyCollision;
                      HeadJudg HeadCollision;
                      BallScript BallDamege;
    void Awake () {
      BodyCollision = GameObject.Find("BodyJudge").GetComponent<BodyJudg>();
      HeadCollision = GameObject.Find("HeadJudge").GetComponent<HeadJudg>();
      BallDamege    = GameObject.("Ball").GetComponent<BallScript>();
      Status();
      Debug.Log(HP);

}
    //public  int CurrentHP;

    public void Status(){//ステータス用関数
        AT = 45;
        BallDamege.Damege = AT ;
        Speed　=　5;
        Shoot　=　1000;
        Reload　=　5;
        int[] Carry = new int[5];
        MaxHP　=　150;
        HP =　MaxHP;
    }

    public void HPGuI(){
      //HPをGUIに表示させるため
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
    void Damege(){
        HP -= BodyCollision.Damege*0.65f; // Unityちゃん　アビリティ
        HP -= HeadCollision.Damege*0.65f;//　受けるダメージを35%軽減
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
