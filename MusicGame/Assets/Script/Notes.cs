using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour{

  public GameObject BlueNote;
  public GameObject RedNote;

      // Start is called before the first frame update
    void Start()
    {
      GameObject laneB0 =  Instantiate (BlueNote, new Vector3(-4,0,30),Quaternion.identity);
      GameObject laneB1 =  Instantiate (BlueNote, new Vector3(-2,0,30),Quaternion.identity);
      GameObject laneB2 =  Instantiate (BlueNote, new Vector3(0,0,30),Quaternion.identity);
      GameObject laneB3 =  Instantiate (BlueNote, new Vector3(2,0,30),Quaternion.identity);
      GameObject laneB4 =  Instantiate (BlueNote, new Vector3(4,0,30),Quaternion.identity);

      GameObject laneR0 =  Instantiate (RedNote, new Vector3(-4,0,32),Quaternion.identity);
      GameObject laneR1 =  Instantiate (RedNote, new Vector3(-2,0,32),Quaternion.identity);
      GameObject laneR2 =  Instantiate (RedNote, new Vector3(0,0,32),Quaternion.identity);
      GameObject laneR3 =  Instantiate (RedNote, new Vector3(2,0,32),Quaternion.identity);
      GameObject laneR4 =  Instantiate (RedNote, new Vector3(4,0,32),Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
       Transform laneB0 = this.transform;
       Vector3 pos = laneB0.position;

       pos.z += 0.01f;

       laneB0.position = pos;
    }
}
