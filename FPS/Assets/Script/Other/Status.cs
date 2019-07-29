using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
  public CharacterStatus Unitychan;
  [SerializeField]
  public  float HP ;
  [SerializeField]
  public  float AT;
  [SerializeField]
  public  string Name;
  [SerializeField]
  public float Speed;

  void Awake()
    {
      HP = Unitychan.maxHp;
      AT = Unitychan.atk;
      Name =Unitychan.characterName;
      Speed = Unitychan.speed;
      Debug.Log(HP);
      Debug.Log(AT);
      Debug.Log(Name);
      Debug.Log(Speed);
    }

}
