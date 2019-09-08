using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

    public float speed = 100.0f;
    Rigidbody rb;
    public bool CharacterMove = true;
    public float x;
    public float z;

    static public Move instance;

    static bool existsInstance = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        if (existsInstance)
        {
            Destroy(gameObject);
            return;
        }

        existsInstance = true;
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (CharacterMove == true)
        {
            x = Input.GetAxis("Horizontal") * speed;
            z = Input.GetAxis("Vertical") * speed;
            rb.AddForce(x, 0, z);
        }
    }
}
