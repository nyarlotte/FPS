using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InShop : MonoBehaviour {

    public GameManegement GameManegement;


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Go");
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(0, 0, 0);
            GameManegement.Event(1);
            GameManegement._event = true;

        }
    }

}

