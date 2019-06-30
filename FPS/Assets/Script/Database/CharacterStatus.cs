using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "MyScriptable/Create CharacterStatus")]
public class CharacterStatus : ScriptableObject {
	public string characterName;
	public int maxHp;
	public int atk;
	public int def;
	public int exp;
	public int gold;
}
