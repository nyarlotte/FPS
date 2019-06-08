using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update(){
      int i = 0;
        if (Input.GetKey("right"))
        {
          i= i+1;
        }

        if (Input.GetKey("left"))
        {
          i= i-1;
        }
}

void Chose(){

}
void ChoseGenel(){// ジャンルを選択するための配列
  string []Genel = new string[2];
      Genel[0]=AllGenel();
      Genel[1]=AnimeGenel();
      Genel[2]=JpopGenel();
}

void AllGenel(){　//
string []All = new string[5];
      All[0]="";
      All[1]="";
      All[2]="";
      All[3]="";
      All[5]="";
}

void AnimeGenel(){
string []Anime = new string[3];
        Anime[0]="";
        Anime[1]="";
        Anime[2]="";
        Anime[3]="";
}

void JpopGenel(){
string []Jpop = new string[2];
        Jpop[0]="";
        Jpop[1]="";
        Jpop[2]="";
}
}
