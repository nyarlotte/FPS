using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootBullet : MonoBehaviour{
  [SerializeField]  GameObject bullet;
  [SerializeField]  int speed = 1000;


  void Update(){
    Shoot();
  }

  void Shoot(){
  if(Input.GetMouseButtonDown(0)){
      var bullets = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
      var rb = bullets.GetComponent<Rigidbody>();       //cubesのRigidbody取得
      var force = this.gameObject.transform.forward * speed;          //Vector3に速度（speed）代入
      rb.AddForce(force);                             //AddForceで動かす
      Destroy(bullets, 5);
    }
  }

}
