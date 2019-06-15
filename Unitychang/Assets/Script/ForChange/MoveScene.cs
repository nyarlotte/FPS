using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
  void OnTriggerEnter(Collider unitychan)
  {
      if (unitychan.gameObject.CompareTag("Player")){
          SceneManager.LoadScene ("NewScene");
          GameObject.Find("unitychan").transform.position = new Vector3 (-1,0,3);
        }
}
}
