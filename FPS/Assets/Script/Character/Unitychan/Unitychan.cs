using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Unitychan: MonoBehaviour
{
    public  float MaxHP=150;　//maxHP
    public  float AT;
    public  float Speed;
    public  float HP= 100;
    public  float UnitychanAbility;
    [SerializeField]  GameObject  Ball;
    public  Text UiHP;
    public  Slider slider;
            GameObject Shoot;
            GameObject Camera;

    void Awake(){

      Shoot = transform.GetChild(6).gameObject;
      Camera= transform.GetChild(10).gameObject;
    }
    void Start(){
      HP =　MaxHP;
      Status();
    }

    public void Status(){
        AT = 45;
        Speed = 1000;
        UnitychanAbility = 0.65f;
    }

    public void　TakeDamage(float amount){
      HP -= amount*UnitychanAbility;
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
          int HPUI =(int)HP  ;
          slider.maxValue = MaxHP;
          UiHP.text = "HP"+ HPUI.ToString()+"/" + MaxHP.ToString();
          slider.value = HP;
    }
    void Shooting(){
    if(Input.GetMouseButtonDown(0)){
        var Balls = Instantiate(Ball, Shoot.transform.position, Quaternion.identity) as GameObject;
        var rb = Balls.GetComponent<Rigidbody>();       //cubesのRigidbody取得
        var force = Camera.transform.forward*Speed;          //Vector3に速度（speed）代入
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
