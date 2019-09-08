using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "MyGame/Create ParameterTable", fileName = "ParameterTable")]
public class ParameterTable : ScriptableObject
{
    [SerializeField]public string _name;
    [SerializeField]public int _lv;
    [SerializeField]public int _hp;
    [SerializeField]public int _at;
    [SerializeField]public int _df;
    [SerializeField]public int _speed;
    [SerializeField]public int _exp;
    [SerializeField]public int _money;
    [SerializeField]public List<Item> Drop = new List<Item>();
}

public class Enemy
{
    public List<Enemy> enemy = new List<Enemy>();
    string name;
    int hp;
}