using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
  public GameObject enemy;

  private Rigidbody rb;
	private Vector3 defaultPos;

  void OnTriggerStay(Collider unitychan){
    if(unitychan.gameObject.CompareTag("Player")){
      Destroy(enemy);
      Debug.Log("倒しました");
    }
  }

	void Start () {
		rb = GetComponent<Rigidbody>();
		defaultPos = transform.position;
	}

	void FixedUpdate() {
		rb.MovePosition(new Vector3(defaultPos.x　+ Mathf.PingPong(Time.time, 2),0, defaultPos.z　+ Mathf.PingPong(Time.time ,2)));
	}
}
