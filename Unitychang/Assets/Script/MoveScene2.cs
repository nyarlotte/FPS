using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene2 : MonoBehaviour
{
  void OnTriggerEnter(Collider unitychan)
  {
      if (unitychan.gameObject.CompareTag("Player")){
          SceneManager.LoadScene ("SampleScene");
        }
}
}
