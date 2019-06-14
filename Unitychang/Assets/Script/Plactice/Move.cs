using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
  void OnTriggerStay(Collider other)
  {
      if (other.attachedRigidbody)
          transform.Translate (0, 0, 3);
  }
}
