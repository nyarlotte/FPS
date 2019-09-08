using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class BattleManegment : MonoBehaviour {

    //GameObject
    GameObject _Enemy;
    List<GameObject> _Character = new List<GameObject>();
    GameObject _Player;
    GameObject _Current;
    GameObject _Wait;
    [SerializeField] GameObject _BattleMenu, _EscapeButton, _BattleButton;

    //Script
    [SerializeField] BattleMessage _BattleText;

    //UI
    public Slider EnemyHP;
    public Slider PlayerHP;
    public Text PlayerHP_text;
    public Text EnemyHP_text;

    //bool
    [SerializeField] bool _Same = false;
    bool _IsFadeIn = false;
    bool _IsFadeOut = false;

    [SerializeField] Image _Fade;
    float _FadeSpeed = 0.02f;        //透明度が変わるスピードを管理
    float _Red, _Green, _Blue, _Alfa;   //パネルの色、不透明度を管理
    int _Escape;

    private void Awake() { 
        _Enemy =(GameObject) Resources.Load("Slime");
        _Player = GameObject.FindGameObjectWithTag("Player");
        Instantiate(_Enemy, new Vector3(2, 0, 2), Quaternion.identity);
        _Character.Add(_Player);
        _Character.Add(_Enemy);

        _Enemy.GetComponent<Status>().Awake();

        _Red = _Fade.color.r;
        _Green = _Fade.color.g;
        _Blue = _Fade.color.b;
        _Alfa = _Fade.color.a;
    }

    void Start () {
        Debug.Log(_Enemy.GetComponent<Status>().HP);
        Debug.Log(_Enemy.GetComponent<Status>().DF);
        Debug.Log(_Enemy.GetComponent<Status>().EXP);
        _Character[0].transform.position = new Vector3(0, 0, 0);

        if (_Character[0].GetComponent<Status>().SP > _Character[1].GetComponent<Status>().SP) {
            _Current = _Character[0];
            _Wait = _Character[1];
        } else if(_Character[0].GetComponent<Status>().SP < _Character[1].GetComponent<Status>().SP) {
            _Current = _Character[1];
            _Wait = _Character[0];
        } else {
            _Same = true;
            Set();
        }
        _BattleMenu.SetActive(false);
        EnemyHP.GetComponent<Slider>().maxValue = _Enemy.GetComponent<Status>().MaxHP; 
        PlayerHP.GetComponent<Slider>().maxValue = _Player.GetComponent<Status>().MaxHP;

        Slider();
        _IsFadeIn = true;
    }

    void Update () {                   //Updateの中身が長くなるようならメソッドで分けてもよし

        if (_Current.tag == "Enemy") {
            Battle(1);
        }

        Slider();

        if (_IsFadeIn == true) {         //シーン移動した際にフェードイン
            _Alfa -= _FadeSpeed;          //a)不透明度を徐々に下げる
            _Fade.color = new Color(_Red, _Green, _Blue, _Alfa); //b)変更した不透明度パネルに反映する

            if (_Alfa <= 0) {            //c)完全に透明になったら処理を抜ける
                _IsFadeIn = false;
                _Fade.enabled = false;   //d)パネルの表示をオフにする
            }
        }

        if (_IsFadeOut == true) {        //バトル終了時フェードアウト
            _Fade.enabled = true;
            _Alfa += _FadeSpeed;
            _Fade.color = new Color(_Red, _Green, _Blue, _Alfa);

            if (_Alfa >= 1) {
                _IsFadeOut = false;
                BackScene();
            }
        }
    }

    void Slider() {
        EnemyHP.GetComponent<Slider>().value = _Enemy.GetComponent<Status>().HP;
        PlayerHP.GetComponent<Slider>().value = _Player.GetComponent<Status>().HP;
        PlayerHP_text.text = _Player.GetComponent<Status>().Name+"Lv"+ _Player.GetComponent<Status>().Lv+"HP" + _Player.GetComponent<Status>().HP+"/" + _Player.GetComponent<Status>().MaxHP; 
        EnemyHP_text.text  = _Enemy.GetComponent<Status>().Name + "Lv" + _Enemy.GetComponent<Status>().Lv + "HP" + _Enemy.GetComponent<Status>().HP + "/" + _Enemy.GetComponent<Status>().MaxHP;
    }

    public void Menu(int i) {

        switch (i) {

            case 1:
                _BattleMenu.SetActive(true);
                Set();
                break;

            case 2:
                Escape();
                break;
        }
    }

    void Set() {

        if (_Same == true) {
            _Character = _Character.OrderBy(a => Guid.NewGuid()).ToList();
            _Current = _Character[0];
            _Wait = _Character[1];
        }
    }

    public void Battle(int i) {

        switch (i) {

            case 1:
                _BattleMenu.SetActive(false);
                _BattleButton.SetActive(false);
                _EscapeButton.SetActive(false);
                int Damage = _Current.GetComponent<Status>().AT - _Wait.GetComponent<Status>().DF;

                if(Damage <= 0) {
                    Damage = 1;
                }

                _Wait.GetComponent<Status>().HP -= Damage;
                _BattleText.SetMessage(_Wait.GetComponent<Status>().Name + "に" + Damage + "のダメージ");
                Debug.Log(_Wait.GetComponent<Status>().Name+ "に"+ Damage + "のダメージ");
                
                if (_Wait.GetComponent<Status>().HP <= 0) {
                    Result();
                }

                Change();
                _BattleButton.SetActive(true);
                _EscapeButton.SetActive(true);
                break;

            case 2:             //Item
                break;

            case 3:
                GameObject End = _Current;
                _Current = _Wait;
                _Wait = End;
                break;
        }
    }

    void Change()　{
        GameObject end = _Current;
        _Current = _Wait;
        _Wait = end;
    }

    void Result() {
        _BattleText.SetMessage(_Wait.GetComponent<Status>().Name + "を倒した");
        Debug.Log(_Wait.GetComponent<Status>().Name + "を倒した");

        if (_Wait.tag == "Player") {
            Debug.Log("GameOver");
            _BattleText.SetMessage("Game Over");
            // SceneManager.LoadScene("GameOver");
        }　else {
            _Player.GetComponent<Status>().GET = _Player.GetComponent<Status>().GET + _Enemy.GetComponent<Status>().EXP;
            _Player.GetComponent<Status>().TOTAL_EXP += _Enemy.GetComponent<Status>().EXP;
            _Player.GetComponent<Status>().LevelUP -= _Enemy.GetComponent<Status>().EXP;
            int random = Random.Range(0, 255);
            
            if (random >= 200) {
                _BattleText.SetMessage(_Wait.GetComponent<Status>().bag[0]._name + "をGetした");
                Debug.Log(_Wait.GetComponent<Status>().bag[0]._name + "をGetした");
                _Player.GetComponent<Status>().bag.Add(_Enemy.GetComponent<Status>().bag[0]);
            }
            _Player.GetComponent<Status>().MONEY += _Enemy.GetComponent<Status>().MONEY;
            _Player.GetComponent<Status>().Levelup();
            _IsFadeOut = true;
        }
    }

    void Escape() {
        int random = Random.Range(0, 10);

        if(random > 7) {
            _IsFadeOut = true;
        } else if(_Escape == 2) {
            _IsFadeOut = true;
        } else {
            Battle(3);
            _Escape++;
        }
    }

    void BackScene() {//シーンの移動および元の位置に戻る
        _Player.transform.position = _Player.GetComponent<Status>().save;
        SceneManager.LoadScene("GameScene");
    }
}
()).ToList();
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
