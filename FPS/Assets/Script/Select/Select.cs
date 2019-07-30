using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Select : MonoBehaviour {

  [SerializeField] GameObject _Select, _Panel;
  [SerializeField] Text _Txt;


  public void KohakuClick() {
    _Select.SetActive(true);
    _Panel.SetActive(true);
    _Txt.text = "Unitychan-dayo";
    PlayerPrefs.SetInt("Character", 0);
    }

  public void YukoClick() {
    _Select.SetActive(true);
    _Panel.SetActive(true);
    _Txt.text = "Yuko-dayo";
    PlayerPrefs.SetInt("Character", 1);
    }

  public void MisakiClick() {
    _Select.SetActive(true);
    _Panel.SetActive(true);
    _Txt.text = "Misaki-dayo";
    PlayerPrefs.SetInt("Character", 2);
    }
}
