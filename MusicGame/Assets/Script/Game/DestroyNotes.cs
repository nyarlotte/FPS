using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  DestroyNotes: MonoBehaviour
{

    void OnTriggerStay(Collider Note)
    {

         if (Note.gameObject.CompareTag("Note"))
         {
            Destroy(Note.gameObject);

            Debug.Log("Bad");
         }
    }
}
