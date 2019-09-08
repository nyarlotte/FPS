using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Staff : MonoBehaviour
{
    public GameObject panel;
    public GameObject shopPanel;
    public GameObject character;
    public GameObject textObject;
    public GameObject[] Button;
    public GameObject Scroll;
    public GameObject[] SelectButton;
    Move Move;//Characterに当ててあるスクリプト

    Text text;

    void Start()
    {
        character = GameObject.FindWithTag("Player");
        Move = character.GetComponent<Move>();
        textObject = panel.gameObject.transform.GetChild(0).gameObject;
        text = textObject.GetComponent<Text>();
    }

    bool Shopping = false;
    void OnTriggerStay(Collider other)
    {

        if (Shopping == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                panel.SetActive(true);
                Move.CharacterMove = false;
                Shopping = true;
                text.text = "いらっしゃい";
            }
        }


    }

    public void Click(int Button)
    {
        switch (Button)
        {
            case 1:
                Buy();
                break;

            case 2:
                Sale();
                break;

            case 3:
                Back();
                break;
        }
    }

    void Back()
    {
        panel.SetActive(false);
        shopPanel.SetActive(false);
        Move.CharacterMove = true;
        Shopping = false;
    }

    public void Buy()
    {
        int i =0;
        text.text = "買い物ですね？";
        SelectButton[0].SetActive(true);
        SelectButton[1].SetActive(true);
        switch (i)
        {
            case 1:
                Scroll.SetActive(true);
                break;
            case 2:
                break;
        }
    }

    public void Sale()
    {
        int i=0;
        text.text = "売却ですね？";
        SelectButton[0].SetActive(true);
        SelectButton[1].SetActive(true);
        switch (i)
        {
            case 1:
                Scroll.SetActive(true);
                break;
            case 2:

                break;
        }
    }
}
