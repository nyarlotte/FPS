using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteCreate: MonoBehaviour
{
    public GameObject note;

    public int speed = 1000;

    //1～4小節

    void Start()
    {

      Invoke("Lane1Gen", 2);
      Invoke("Lane2Gen", 4);
      Invoke("Lane3Gen", 6);
      Invoke("Lane4Gen", 8);
      Invoke("Lane5Gen", 10);
      Invoke("Lane4Gen", 12);
      Invoke("Lane3Gen", 14);
      Invoke("Lane2Gen", 16);
      Invoke("Lane1Gen", 18);
      Invoke("Lane2Gen", 20);
      Invoke("Lane3Gen", 22);
      Invoke("Lane4Gen", 24);
      Invoke("Lane5Gen", 26);
      Invoke("Lane4Gen", 28);
      Invoke("Lane3Gen", 30);
      Invoke("Lane2Gen", 32);
      Invoke("Lane1Gen", 34);
      Invoke("Lane2Gen", 36);
      Invoke("Lane3Gen", 38);
      Invoke("Lane4Gen", 40);
      Invoke("Lane5Gen", 42);
      Invoke("Lane4Gen", 44);
      Invoke("Lane3Gen", 46);
      Invoke("Lane2Gen", 48);
    }

    void Lane1Gen()
    {
        var notes = Instantiate(note, new Vector3(-4, 0, 35), Quaternion.identity) as GameObject;
        var rb = notes.GetComponent<Rigidbody>();       //cubesのRigidbody取得
        var force = new Vector3(0, 0, -speed);          //Vector3に速度（speed）代入
        rb.AddForce(force);                             //AddForceで動かす
    }

    void Lane2Gen()
    {
        var notes = Instantiate(note, new Vector3(-2, 0, 35), Quaternion.identity) as GameObject;
        var rb = notes.GetComponent<Rigidbody>();
        var force = new Vector3(0, 0, -speed);
        rb.AddForce(force);
    }

    void Lane3Gen()
    {
        var notes = Instantiate(note, new Vector3(0, 0, 35), Quaternion.identity) as GameObject;
        var rb = notes.GetComponent<Rigidbody>();
        var force = new Vector3(0, 0, -speed);
        rb.AddForce(force);
    }
    void Lane4Gen()
    {
        var notes = Instantiate(note, new Vector3(2, 0, 35), Quaternion.identity) as GameObject;
        var rb = notes.GetComponent<Rigidbody>();       //cubesのRigidbody取得
        var force = new Vector3(0, 0, -speed);          //Vector3に速度（speed）代入
        rb.AddForce(force);                             //AddForceで動かす
    }
    void Lane5Gen()
    {
        var notes = Instantiate(note, new Vector3(4, 0, 35), Quaternion.identity) as GameObject;
        var rb = notes.GetComponent<Rigidbody>();
        var force = new Vector3(0, 0, -speed);
        rb.AddForce(force);
    }
}
