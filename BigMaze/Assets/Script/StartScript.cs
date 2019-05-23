using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour{
  public Canvas canvas;
  public Text text;
    // Start is called before the first frame update
    void Start(){
      canvas.enabled = false;
      text.text = "ready...";
    }

    // Update is called once per frame
    void Update(){
      if (Input.GetKey(KeyCode.Space)){
        canvas.enabled = true;
      }
    }
    public void OnButtonClick(){//　OnButtonClickメソッド
      text.text ="ok!!";
    }
}
