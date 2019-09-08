using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManegement : MonoBehaviour {

    public GameObject character ;
    public Serihu charcterSerihu;
    public enum Turn
    {
        Run,
        Menu,
        Battle
    }
    public Turn turn;


    [SerializeField]
    public List<GameObject> MenuButton = new List<GameObject>();
    public List<GameObject> MenuScreen = new List<GameObject>();
    public List<Transform>  Scene = new List<Transform>();
    public GameObject panel;
    public GameObject FadePanel;
    [SerializeField] public bool _event = false;
    float time = 0;

    float fadeSpeed = 0.02f;        //透明度が変わるスピードを管理
    float red, green, blue, alfa;   //パネルの色、不透明度を管理
    //Bool
    public bool isFadeOut = false;  //フェードアウト処理の開始、完了を管理するフラグ
    public bool isFadeIn = false;   //フェードイン処理の開始、完了を管理するフラグ
    public bool isBattle = false;
    public Vector3 position_save;

    Image Fade;


    private void Awake()
    {
        Fade = FadePanel.GetComponent<Image>();
        red = Fade.color.r;
        green = Fade.color.g;
        blue = Fade.color.b;
        alfa = Fade.color.a;
    }

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");

        panel.SetActive(false);
        turn = Turn.Run;

        for (int i = 0; i < MenuButton.Count; i++)
        {
            MenuButton[i].SetActive(false);
        }
        for (int i = 0; i < MenuScreen.Count; i++)
        {
            MenuScreen[i].SetActive(false);
        }
        
        
    }

    void Update () {

        switch (turn)
        {
            case Turn.Run:
                character.GetComponent<Move>().CharacterMove = true;
                Encount(); 
                break;

            case Turn.Menu:
                character.GetComponent<Move>().CharacterMove = false;
                break;

            case Turn.Battle:
                isBattle = true;
                break;
        }

        Menu();

        if(_event == true)
        {
            time += Time.deltaTime;
            if(time >= 2)
            {
                BattleEvent();
            }
        }

        if(isFadeOut == true)
        {
            alfa += fadeSpeed;
            character.GetComponent<Move>().CharacterMove = false;

            SetAlpha();
            if (alfa >= 1)
            {
                isFadeOut = false;
                SceneManager.LoadScene("BattleScene");
                isFadeIn = true;
            }
        }
    }

    void Encount()
    {
        int random = 0;

        if (Input.GetKey("w") | Input.GetKey("s") | Input.GetKey("a") | Input.GetKey("d"))
        {
           //  random = Random.Range(0, 100);
        }

        if (random > 97)
        {
            Debug.Log("敵が現れた");
            turn = Turn.Battle;
            Fade.enabled = true;
            isFadeOut = true;
            character.GetComponent<Status>().SavePosition();
            
            character.GetComponent<Move>().x = 0;
            character.GetComponent<Move>().z = 0;

        }
    }

    void SetAlpha()
    {
        Fade.color = new Color(red, green, blue, alfa);
    }




    bool MenuCheck= false;
    public void Menu(int Button=0) //メニューの画面を開く
    {
        if (isBattle == false) {
            if (MenuCheck == false)//最初に押されたとき
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    turn = Turn.Menu;
                    MenuCheck = true;　//bool切り替え
                    for (int i = 0; i < MenuButton.Count; i++)
                    {
                        MenuButton[i].SetActive(true);
                    }
                }
                //2回目に押したとき
            }else if(MenuCheck == true){
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Button = 4;
                    Debug.Log(Button);
                }
            }
        }

        switch (Button)
        {
            case 1:　// ステータスボタン
                StatusMenu();
                break;
            case 2:　//持ち物ボタン
                BagMenu();
                break;
            case 3:　//　セーブボタン
                SaveMenu();
                break;
            case 4: //戻るボタン
                Back();
                break;
        }
    }

    void Back()
    {
        for (int i = 0; i < MenuButton.Count; i++)
        {
            MenuButton[i].SetActive(false);
        }
        for (int i = 0; i < MenuScreen.Count; i++)
        {
            MenuScreen[i].SetActive(false);
        }
        Debug.Log("メニュー画面を閉じる");
        turn = Turn.Run;
        MenuCheck = false;
    }

    void StatusMenu()
    {
        Debug.Log("ステータス画面を開く");
        MenuScreen[0].SetActive(true);

        Text text =Scene[0].GetChild(0).gameObject.GetComponent<Text>();

        text.text = character.GetComponent<Status>().Name + "Lv"+ character.GetComponent<Status>().Lv + "\r\n"
                  + "HP" + character.GetComponent<Status>().HP + "/"+ character.GetComponent<Status>().MaxHP+"\r\n"
                  + "AT" + character.GetComponent<Status>().AT + "\r\n"
                  + "DE" + character.GetComponent<Status>().DF + "\r\n"
                  + "SP" + character.GetComponent<Status>().SP + "\r\n"
                  + "EXP" + character.GetComponent<Status>().EXP + "\r\n"
                  + "残り"+ character.GetComponent<Status>().LevelUP + "EXPでレベルアップ"+"\r\n"
                  + "所持金" + character.GetComponent<Status>().MONEY + "円";
    }

    void BagMenu() {
        Debug.Log("持ち物画面を開く");
        MenuScreen[0].SetActive(true);
        Text text = Scene[0].GetChild(0).gameObject.GetComponent<Text>();
        
        if (character.GetComponent<Status>().bag.Count == 0)
        {
            text.text = "なにも持っていません";
        }
        else
        {
            for (int i = 0; i < character.GetComponent<Status>().bag.Count; i++)
            {
                text.text = character.GetComponent<Status>().bag[i]._name + "\r\n";
            }
        }  
    }

    void SaveMenu()
    {
        Debug.Log("セーブします");
    }

    public void Event(int i)
    {
        switch (i)
        {
            case 1:
                Shop();
                break;
            case 2:
                Battle();
                character.GetComponent<Move>().CharacterMove = false;
                break;
        }
    }

    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void Battle()
    {

    }

    void BattleEvent()
    {
        panel.SetActive(true);
        character.transform.position = new Vector3(0, 0, 22);
        Text text = Scene[1].GetChild(0).gameObject.GetComponent<Text>();
        text.text = charcterSerihu.SERIFU[ClickCount];

        if(ClickCount == 3)
        {
            SceneManager.LoadScene("EventBattle");
        }
    }

    int ClickCount;
    public void Click()
    {
        ClickCount += 1;
    }

}

