using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class BattleManegment : MonoBehaviour {

    public enum Phase
    {
        Select,
        Battle,
        Result
    }
    //GameObject
    public Phase phase;
    public GameObject Enemy;
    public List<GameObject> character = new List<GameObject>();
    public GameObject Player;
    public GameObject Current;
    public GameObject Wait;
    public GameObject BattleMenu;
    //Script

    //UI
    public Slider EnemyHP;
    public Slider PlayerHP;
    public Text PlayerHP_text;
    public Text EnemyHP_text;
    //数値
    public int[] Speed;
    //bool
    public bool Same = false;
    public bool isFadeIn = false;
    public bool isFadeOut = false;  
    public GameObject FadePanel;
    Image Fade;

    float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理


    private void Awake()
    { 
    
        Enemy =(GameObject) Resources.Load("Slime");
        Player = GameObject.FindGameObjectWithTag("Player");
        Instantiate(Enemy);
        character.Add(Player);
        character.Add(Enemy);
        
        Enemy.GetComponent<Status>().Awake();

        Fade = FadePanel.GetComponent<Image>();
        red = Fade.color.r;
        green = Fade.color.g;
        blue = Fade.color.b;
        alfa = Fade.color.a;

    }

    void Start ()
    {
        Debug.Log(Enemy.GetComponent<Status>().HP);
        Debug.Log(Enemy.GetComponent<Status>().DF);
        Debug.Log(Enemy.GetComponent<Status>().EXP);
        
        character[0].transform.position = new Vector3(0, 0, 0);
        if (character[0].GetComponent<Status>().SP > character[1].GetComponent<Status>().SP)
        {
            Current = character[0];
            Wait = character[1];
        }else if(character[0].GetComponent<Status>().SP < character[1].GetComponent<Status>().SP)
        {
            Current = character[1];
            Wait = character[0];
        }else if (character[0].GetComponent<Status>().SP == character[1].GetComponent<Status>().SP)
        {
            Same = true;
            SameSpeed();
        }

        BattleMenu.SetActive(false);

        EnemyHP.GetComponent<Slider>().maxValue = Enemy.GetComponent<Status>().MaxHP; 
        PlayerHP.GetComponent<Slider>().maxValue = Player.GetComponent<Status>().MaxHP;
        Slider();
        phase = Phase.Select;
        isFadeIn = true;
    }



    void Update () {
        switch (phase)
        {
            case Phase.Select:
                Menu(0);
                break;
            case Phase.Battle:
                Battle(0);
                break;
            case Phase.Result:
                break;
        }

        Slider();

        if (isFadeIn == true)
        {
            FadeIn();
        }

        if (isFadeOut == true)
        {
            FadeOut();
        }

    }

    void FadeIn()// シーン移動した際にフェードイン
    {
        alfa -= fadeSpeed;                //a)不透明度を徐々に下げる
        SetAlpha();                      //b)変更した不透明度パネルに反映する
        if (alfa <= 0)
        {                    //c)完全に透明になったら処理を抜ける
            isFadeIn = false;
            Fade.enabled = false;    //d)パネルの表示をオフにする
        }
    }

    void FadeOut()　//バトル終了時フェードアウト
    {
        Fade.enabled = true;
        alfa += fadeSpeed;
        SetAlpha();
        if (alfa >= 1)
        {
            isFadeOut = false;
            BackScene();
        }

    }



    void Slider()
    {
        EnemyHP.GetComponent<Slider>().value = Enemy.GetComponent<Status>().HP;
        PlayerHP.GetComponent<Slider>().value = Player.GetComponent<Status>().HP;


        PlayerHP_text.text = Player.GetComponent<Status>().Name+"Lv"+ Player.GetComponent<Status>().Lv+"HP" + Player.GetComponent<Status>().HP+"/" + Player.GetComponent<Status>().MaxHP; 
        EnemyHP_text.text  = Enemy.GetComponent<Status>().Name + "Lv" + Enemy.GetComponent<Status>().Lv + "HP" + Enemy.GetComponent<Status>().HP + "/" + Enemy.GetComponent<Status>().MaxHP;
    }


    public void Menu(int i)
    {
        switch (i)
        {
            case 1:
                BattleMenu.SetActive(true);
                Set();
                Battle(0);
                break;
            case 2:
                Escape();
                break;
        }
        
    }

    void Set()
    {
        if (Same == true)
        {
            SameSpeed();
        }
    }
    public void Battle(int i)
    {
        switch (i)
        {
            case 1:
                int Damege = Current.GetComponent<Status>().AT - Wait.GetComponent<Status>().DF;

                if(Damege == 0)
                {
                    Damege = 1;
                }

                Wait.GetComponent<Status>().HP -= Damege;
                Debug.Log(Wait.GetComponent<Status>().Name+ "に"+ Damege + "のダメージ");
                
                if(Wait.GetComponent<Status>().HP <= 0)
                {
                    Result();
                }
                Change();
                break;
            case 2:

                break;
            case 3:
                GameObject End = Current;
                Current = Wait;
                Wait = End;
                Battle(0);
                break;
        }
    }

    int turn;
    void Change()
    { 
        GameObject End = Current;
            Current = Wait;
            Wait = End;
            Battle(0);
        turn ++;

        if(turn == character.Count)
        {
            phase = Phase.Select;
            BattleMenu.SetActive(false);
            turn = 0;
        }
    }

    void Result()
    {
        Debug.Log(Wait.GetComponent<Status>().Name + "を倒した");
        if(Wait.tag == "Player")
        {
            Debug.Log("GameOver");
            // SceneManager.LoadScene("GameOver");

        }
        else if (Wait.tag == "Enemy")
        {

            Player.GetComponent<Status>().GET = Player.GetComponent<Status>().GET + Enemy.GetComponent<Status>().EXP;
            Player.GetComponent<Status>().TOTAL_EXP += Enemy.GetComponent<Status>().EXP;
            Player.GetComponent<Status>().LevelUP -= Enemy.GetComponent<Status>().EXP;
            int random = Random.Range(0, 255);
            
            if (random >= 200)
            {
                Debug.Log(Wait.GetComponent<Status>().bag[0]._name + "をGetした");
                Player.GetComponent<Status>().bag.Add(Enemy.GetComponent<Status>().bag[0]);
            }

            Player.GetComponent<Status>().MONEY += Enemy.GetComponent<Status>().MONEY;
            Player.GetComponent<Status>().Levelup();
            isFadeOut = true;
            Destroy(Enemy);
        }
        
    }

    int escape;
    void Escape()
    {
        int random = Random.Range(0, 10);

        if(random > 7)
        {
            isFadeOut = true;
        }
        else if(escape ==2)
        {
            isFadeOut = true;
        }
        else
        {
            Battle(3);
            escape++;
        }
    }

    void SameSpeed()
    {
        character = character.OrderBy(a => Guid.NewGuid()).ToList();
        Current = character[0];
           Wait = character[1];
    }


    void SetAlpha()
    {
        Fade.color = new Color(red, green, blue, alfa);
    }

    void BackScene()//シーンの移動および元の位置に戻る
    {
        Player.transform.position = Player.GetComponent<Status>().save;
        SceneManager.LoadScene("GameScene");
    }
}
