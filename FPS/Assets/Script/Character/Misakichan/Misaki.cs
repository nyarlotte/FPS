using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Misaki: MonoBehaviour
{
    public  float MaxHP=150;
    public  float AT;
    public  float HP= 100;
    public  float Speed;
    [SerializeField]  GameObject  Ball;
    public  float MisakiAbility;
  //  public  Text UiHP;
  //  public  Slider slider;
    GameObject Shoot;
    GameObject Camera;

    void Awake(){
      Shoot = transform.GetChild(6).gameObject;
      //Camera= transform.GetChild(7).gameObject;
    }
    void Start(){
      HP =　MaxHP;
      Status();
    }

    public void Status(){//ステータス用関数
        AT = 65;
        Speed = 1000;
        //MisakiAbility = 0.65f;
        //HP自動回復
        //受けるダメージ1.5倍
    }

    public void　TakeDamage(float amount){
      HP -= amount;
    }

    void Update(){

      Death();
      HPGuI();
      Shooting();
    }

    public void Death(){
      if(HP <= 0 ){
        Destroy(gameObject);
      }
    }

    public void HPGuI(){
          //HPをGUIに表示させるため
    //      int HPUI =(int)HP  ;
    //      slider.maxValue = MaxHP;
    //      UiHP.text = "HP"+ HPUI.ToString()  + "/" + MaxHP.ToString();
    //      slider.value = HP;

    }
    void Shooting(){
    if(Input.GetMouseButtonDown(0)){
        var Balls = Instantiate(Ball, Shoot.transform.position, Quaternion.identity) as GameObject;
        var rb = Balls.GetComponent<Rigidbody>();       //cubesのRigidbody取得
        var force = Shoot.transform.forward*Speed;          //Vector3に速度（speed）代入
        rb.AddForce(force);                             //AddForceで動かす
        Destroy(Balls, 5);
      }
    }
}

//-----HPを回復させるなら--------------------------------
/*if(HP > MaxHP){
  //MaxHPを超えないように
   HP  = MaxHP;
}*/
