using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "MyScriptable/Create CharacterStatus")]
public class CharacterStatus : ScriptableObject {
	public string characterName;
	public float maxHp;
	public float atk;
	public float speed;
}
