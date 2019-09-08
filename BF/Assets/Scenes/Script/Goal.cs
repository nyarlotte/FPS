using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Goal : MonoBehaviour {
    public GameManegement GameManegement;
    public Color fadeColor = Color.black;


    private void OnTriggerEnter(Collider other)
    {

            FadeManager.Instance.LoadScene("1", 2.0f);
            GameManegement.Event(2);
            GameManegement._event = true;
    }

}
