using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music1 : MonoBehaviour
{
  public GameObject Red;
  public GameObject Blue;
    // Start is called before the first frame update
    void Start()
    {
      Instantiate(Red);
      Instantiate(Blue);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
