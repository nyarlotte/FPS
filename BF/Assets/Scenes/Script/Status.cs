using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public BattleManegment BattleManegment;
    public ParameterTable Parameter;

    [SerializeField] public string Name;
    [SerializeField] public int Lv;
    [SerializeField] public int MaxHP;
    [SerializeField] public int HP;
    [SerializeField] public int AT;
    [SerializeField] public int DF;
    [SerializeField] public int SP;
    [SerializeField] public int EXP;
    [SerializeField] public int LevelUP = 100;
    [SerializeField] public int GET;
    [SerializeField] public int TOTAL_EXP;
    [SerializeField] public int MONEY;
    
    [SerializeField] public bool player;

    public List<Item> bag = new List<Item>();

    public Vector3 save;
    public void Awake()
    {
        Name = Parameter._name;
        Lv   = Parameter._lv ;
        MaxHP = Parameter._hp;
        HP   = Parameter._hp;
        AT   = Parameter._at;
        DF   = Parameter._df;
        SP   = Parameter._speed ;
        EXP  = Parameter._exp ;
        MONEY = Parameter._money;
        if (this.gameObject.tag == "Player")
        {
            player = true;
        }
    }

    public void Levelup()
    {
        if (LevelUP <= 0)
        {
            Debug.Log("Lvあっぷ");
            Lv +=1;
            HP +=3;
            AT +=2;
            DF +=2;
            SP +=2;
            EXP += -LevelUP;
            LevelUP = 100 * Lv;
            
        }
    }

    public void  SavePosition()
    {
        save = this.gameObject.transform.position;
    }
}
