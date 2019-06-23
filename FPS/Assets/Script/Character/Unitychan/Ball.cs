using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  private void OnCollisionEnter (Collision other)
  {
      if(other.gameObject.tag == "Fields")  // 壁にぶつかったら
      {
          this.tag = "Ball";             // タグを変更する
      }
  }
}
