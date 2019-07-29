using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBullets : MonoBehaviour{
    [SerializeField] GameObject _Bullet;                        //射出するBulletプレハブの取得
    [SerializeField] float _Speed = 100;                        //Bulletの射出スピード用変数
    Transform shootingObjTrans;                         //子オブジェクトのShootingObjectを参照

    void Awake(){
        shootingObjTrans = gameObject.transform.GetChild(1).transform;  //ShootingObjectのTransformを取得
    }

    void Update(){
        float Y_Rotation = Input.GetAxis("Mouse Y");            //マウスのY軸の値をShootingObjectのX軸回転に代入し射出角度を変えられるようにする
        shootingObjTrans.Rotate(-Y_Rotation, 0, 0);
        Shooting();
    }

    void Shooting(){
        if (Input.GetMouseButtonDown(0)){                        //もしマウス左クリックをしたら。。。
            GameObject bullets = Instantiate(_Bullet, shootingObjTrans.position, Quaternion.identity) as GameObject;    //BulletオブジェクトをShootingObjectの位置からBulletsとして生成
            bullets.transform.parent = this.transform;          //Playerの子オブジェクトにする
            bullets.name = "Player's Bullet";
            Rigidbody rb = bullets.GetComponent<Rigidbody>();   //BulletsのRigidBodyを取得し、前方向に力を加える
            Vector3 force = shootingObjTrans.forward * _Speed;
            rb.AddForce(force);
            Destroy(bullets, 5);                                //５秒後に射出したBulletsを破壊
        }
    }
}
