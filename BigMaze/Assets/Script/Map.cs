using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour{
  public GameObject Player;
  public GameObject Floor;
  public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
      Instantiate(Floor);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
