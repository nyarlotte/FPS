
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CPMisaki : MonoBehaviour
{
    //Move
    public　float　RandomX;
    public　float　RandomY;

    //status
    public  float MaxHP=150;
    public  float AT;
    public  float Speed;
    public  float HP= 100;
    public  float MisakiAbility;

    //
    public bool Search = false;

    public　float　Timer;
    [SerializeField] GameObject Ball  = default;
    Transform    CPMisakiPos;
    Transform    PlayerPos;
    Transform    CPUPos;
    NavMeshAgent CPUNav;

    GameObject Shoot;
    GameObject Camera;
    void Awake()
    {
      CPUNav = GetComponent<NavMeshAgent>();
      CPMisakiPos =  GetComponent<Transform>();
      Shoot = transform.GetChild(4).gameObject;
    }
    void Start(){
      PlayerPos = GameObject.FindGameObjectWithTag("Player").transform;
      HP =　MaxHP;
      Status();
      InvokeRepeating("CPUMove",0,5);
    }
    public void Status(){//ステータス用関数
        AT = 65;
        Speed = 1000;
        MisakiAbility = 0.65f;
        //HP自動回復
        //受けるダメージ1.5倍
    }

    public void CPUMove(){
      RandomX = Random.Range(-49,49); // -49~49
      RandomY = Random.Range(-49,49);  // -49~49
      CPUNav.SetDestination(new Vector3(RandomX,0,RandomY));
    }


    void OnTriggerStay(Collider other){
      if(other.gameObject.tag=="Player"){
        CPUNav.SetDestination(PlayerPos.position);
        transform.LookAt(PlayerPos);
        Search = true;
      }
    }
    void OnTriggerExit(Collider other){
      if(other.gameObject.tag=="Player"){
        Search = false;
      }
    }
    public void　TakeDamage(float amount){
      HP -= amount;
    }

    void Shooting(){
      if(Search == true){
        var Balls = Instantiate(Ball, Shoot.transform.position, Quaternion.identity) as GameObject;
        var rb = Balls.GetComponent<Rigidbody>();       //cubesのRigidbody取得

        var force = Shoot.transform.forward*Speed;          //Vector3に速度（speed）代入
        rb.AddForce(force);                             //AddForceで動かす
        Destroy(Balls, 5);
      }
    }

    void AtTime(){
      Timer += Time.deltaTime;
      if(Timer >= 1.5f){
        Shooting();
        Timer = 0.0f;

      }
    }

    void Update()
    {
      Death();
      AtTime();
    }
    public void Death(){
      if(HP <= 0 ){
        Destroy(gameObject);
      }
    }
}
