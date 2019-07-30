using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Result : MonoBehaviour
{
  public Text text;
  public Image image;
  public Sprite Lose, Win;
  void Awake(){
    GameSet();
  }

  void Update(){
  }
  void GameSet(){
  switch(PlayerPrefs.GetInt("Result")){
    case 0:
    text.text ="Lose";
    image.sprite = Lose;
          break;
    case 1:
    text.text ="Win";
    image.sprite = Win;
          break;
        }
  }
}
