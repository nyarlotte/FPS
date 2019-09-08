using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleMessage : MonoBehaviour {
    [SerializeField] Text _MessageText;                             //The text component to attach
    string _AllMessage = "スライムがあらわれた！";                    //The first text to display

    void Start() {
        SetMessage(_AllMessage);                                    //Display the first text
    }

    public void SetMessage(string message) {                        //Method to display text
        _MessageText.text = message;
    }
}
