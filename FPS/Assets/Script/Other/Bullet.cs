using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Status _PlayerStatus, _EnemyStatus;

    //void Awake() {
    //    if (this.gameObject.tag == "Player's Bullet") {
    //        _PlayerStatus = GameObject.FindWithTag("Player").GetComponent<PlayerStatus>();
    //    }
    //}

    public void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Fields") {
            this.gameObject.tag = "Fields";
        } else if (other.gameObject.tag == "Enemy") {
            string enemyName = other.gameObject.name;
            _EnemyStatus = GameObject.Find(enemyName).GetComponent<Status>();
            _PlayerStatus = GameObject.FindWithTag("Player").GetComponent<Status>();
            _EnemyStatus.TakeDamage(_PlayerStatus.AT);
            Destroy(gameObject);
        } else if (other.gameObject.tag == "Player"){
            _EnemyStatus = GameObject.FindWithTag("Enemy").GetComponent<Status>();
            _PlayerStatus = GameObject.FindWithTag("Player").GetComponent<Status>();
            _PlayerStatus.TakeDamage(_EnemyStatus.AT);
            Destroy(gameObject);
        }
    }
}
