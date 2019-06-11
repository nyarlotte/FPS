using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class status : MonoBehaviour{
public GameObject player;
public int health = 100;
int power = 20;

    void Update(){
      //health = 100;
        if (health<=0){
          Destroy(player);
        }
    }

    void OnTriggerStay(Collider Poison){

         if (Poison.gameObject.CompareTag("Poison")){

            health-= 1;
            Debug.Log (health);
         }
         if(Poison.gameObject.CompareTag("SpringofRecovery")){

            if (health<100){
                health+= 1;
            }
          Debug.Log (health);
         }

    }
    void Item (){
      // 配列で保管
    }
}
