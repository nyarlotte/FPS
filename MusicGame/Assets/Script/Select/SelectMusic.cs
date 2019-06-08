using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectMusic : MonoBehaviour{
  public GameObject Music;
    // Start is called before the first frame update


    // Update is called once per frame

  void select(){
       string[] Music = new string[3];
             Music[0] = "アニソン";
             Music[1] = "J-POP";
             Music[2] = "洋楽";
             Music[3] = "東方";

  }
}
