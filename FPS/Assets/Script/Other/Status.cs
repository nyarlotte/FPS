using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour{
    [SerializeField] CharacterStatus Unitychan;
    public float HP, AT, Speed ;
    [SerializeField] string Name;

    void Awake(){
      HP = Unitychan.maxHp;
      AT = Unitychan.atk;
      Name =Unitychan.characterName;
      Speed = Unitychan.speed;
      //Debug.Log(HP);
      //Debug.Log(AT);
      //Debug.Log(Name);
      //Debug.Log(Speed);
    }

    void Update(){
        Death();
    }

    public void TakeDamage(float amount){
        HP -= amount;
    }

    void Death(){
        if (HP <= 0){
            Destroy(gameObject);
        }
    }
}
