using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Status2 : MonoBehaviour
{
    public  int MaxHP = 150;
    public  int AT;
    public  int HP = 100;
    public  Text UiHP;
    public  Slider slider;
    public  List<string> Bug = new List<string>();

    void Awake () {
	DontDestroyOnLoad(gameObject);
  slider = GameObject.Find("Slider").GetComponent<Slider>();
  UiHP   = GameObject.Find("HPText").GetComponent<Text>();
}
    //public  int CurrentHP;

    public void Status(){//ステータス用関数

      if(HP > MaxHP){
         HP  = MaxHP;
      }
    }


    public void HPGuI(){

      slider.maxValue = MaxHP;
      UiHP.text = "HP"+ HP.ToString() + "/" + MaxHP.ToString();
      slider.value = HP;

    }
    void Update(){
      Death();
      Status();
      HPGuI();
    }

    public void Item(){//アイテム用関数

      if(Bug[0]=="リンゴ"){
          Debug.Log(Bug[0]);
      }
      if(Bug.Count==2){
        Debug.Log("これ以上拾えません");
      }

    }
    public void Death(){//ゲームオーバー用の関数
      if(HP <= 0 ){
        //Destroy(gameObject);
        SceneManager.LoadScene ("GameOver");
      }
    }

　
}
　　


//もし赤いリンゴを食べたら最大HPが5UPするとかいいんじゃないかな
//その場合は赤いリンゴを食べた回数を記録する変数が必要になるのだろうか
//if(eatApple== true){ hp =+5i 　i = i+1} みたいな記述？
