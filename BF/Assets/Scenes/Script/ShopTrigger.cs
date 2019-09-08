using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ShopTrigger : MonoBehaviour
{


    void Awake()
    {

    }
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Go");
            SceneManager.LoadScene("GameScene");
            GameObject.FindWithTag("Player").transform.position = new Vector3(-1, 0, 8);
        }

    }

}
 