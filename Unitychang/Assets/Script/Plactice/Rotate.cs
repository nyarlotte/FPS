using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{ public GameObject anan;

    void OnTriggerStay(Collider other)
    {
        if (other.attachedRigidbody){
            anan.transform.Rotate(new Vector3(5, 5, 5));
            anan.SetActive (true);
          }
  }
  void OnTriggerExit(Collider other)
  {
      if (other.attachedRigidbody){
          anan.SetActive (false);
        }
}
}
