using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour{
  public GameObject Note;

  public int speed = 1000;                            //ノーツの速度を変える変数

  public float lane1Time;                             //ノーツ生成時間用の変数
  public float lane2Time;
  public float lane3Time;
  public float lane4Time;
  public float lane5Time;

  public int randomMax = 11;                          //ランダム生成時間の範囲を決める変数
  public int randomMin = 0;

  void Start(){}

  void Update(){
      lane1Time = Random.Range(randomMin, randomMax); //ノーツの生成時間をランダムに決め、そこからカウントダウンをする
      lane1Time -= Time.deltaTime;

      lane2Time = Random.Range(randomMin, randomMax);
      lane2Time -= Time.deltaTime;

      lane3Time = Random.Range(randomMin, randomMax);
      lane3Time -= Time.deltaTime;

      lane4Time = Random.Range(randomMin, randomMax);
      lane4Time -= Time.deltaTime;

      lane5Time = Random.Range(randomMin, randomMax);
      lane5Time -= Time.deltaTime;

      if (lane1Time <= 0){Lane1Gen();}　　　　　　　　　　　　　　　 //laneTimeが０以下のときにそれぞれのノーツ生成メソッドを実行
      else if (lane2Time <= 0){Lane2Gen();}
      else if (lane3Time <= 0){Lane3Gen();}
      else if (lane4Time <= 0){Lane4Gen();}
      else if (lane5Time <= 0){Lane5Gen();}

  }

  void Lane1Gen(){
      var cubes = Instantiate(Note, new Vector3(-4, 0.2f, 30), Quaternion.identity) as GameObject;
      var rb = cubes.GetComponent<Rigidbody>();       //cubesのRigidbody取得
      var force = new Vector3(0, 0, -speed);          //Vector3に速度（speed）代入
      rb.AddForce(force);                             //AddForceで動かす
  }

  void Lane2Gen(){
      var cubes = Instantiate(Note, new Vector3(-2, 0.2f, 30), Quaternion.identity) as GameObject;
      var rb = cubes.GetComponent<Rigidbody>();
      var force = new Vector3(0, 0, -speed);
      rb.AddForce(force);
  }

  void Lane3Gen(){
      var cubes = Instantiate(Note, new Vector3(0, 0.2f, 30), Quaternion.identity) as GameObject;
      var rb = cubes.GetComponent<Rigidbody>();
      var force = new Vector3(0, 0, -speed);
      rb.AddForce(force);
  }
  void Lane4Gen(){
      var cubes = Instantiate(Note, new Vector3(2, 0.2f, 30), Quaternion.identity) as GameObject;
      var rb = cubes.GetComponent<Rigidbody>();
      var force = new Vector3(0, 0, -speed);
      rb.AddForce(force);
  }
  void Lane5Gen(){
      var cubes = Instantiate(Note, new Vector3(4, 0.2f, 30), Quaternion.identity) as GameObject;
      var rb = cubes.GetComponent<Rigidbody>();
      var force = new Vector3(0, 0, -speed);
      rb.AddForce(force);
}
}
