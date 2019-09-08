using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "MyGame/Create Item", fileName = "Item")]
public class Item : ScriptableObject
{
    public List<Item> ItemDate = new List<Item>();

    [SerializeField] public string _name;
    [SerializeField] public int _id;
    [SerializeField] public string _ability;
    [SerializeField] public int _price;
    [SerializeField] public Image image;
}


