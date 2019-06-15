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
          GameObject.Find("unitychan").transform.position = new Vector3 (15,0,-2.8f);
        }
}

void start(){

}
}

/*[SerializeField] GameObject Player ;
[SerializeField] Vector3 Spawn ;
[SerializeField] Transform Point ;
void awake(){
   Player = GameObject.Find("unitychan").GetComponent<Transform>();
   Point = Player.transform;
   Spawn = Point.position;//5,0,5
}
*/
