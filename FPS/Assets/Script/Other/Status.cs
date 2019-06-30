using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
  public CharacterStatus Unitychan;
  [SerializeField]
  public  float HP ;
  [SerializeField]
    float AT;
  [SerializeField]
    string Name;

    void Awake()
    {
      HP = Unitychan.maxHp;
      AT = Unitychan.atk;
      Name =Unitychan.characterName;
      Debug.Log(HP);
      Debug.Log(AT);
      Debug.Log(Name);
    }

}
