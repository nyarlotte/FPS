using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectMisaki : MonoBehaviour
{
  public GameObject Select;
  public bool   Misaki = false;

public void SelectCharacter(){
    Select.SetActive(true);
    Misaki = true;
    Debug.Log(Misaki);
    MoveScene();
 }

  public void MoveScene (){
    PlayerPrefs.SetInt("Character",1);
    
    SceneManager.LoadScene("School");

  }
}
/*Switch(PlayerPrefs.GetInt(“保存する名前”)){
    case 1:
        Player 1.SetActive(true);
        （ついでにここにプレイヤーの能力も書いておけます。）
    break;

    case 2:
        Player 2.SetActive(true);
    break;

    case 3:
        Player 3.SetActive(true);
    break;

    default :
    break;
*/
