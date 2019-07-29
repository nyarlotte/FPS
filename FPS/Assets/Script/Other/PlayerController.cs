using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float Speed;         //移動スピード変更用変数
    [SerializeField] float MouseSpeed = 10;    // マウススピード変更用変数
    //[SerializeField] GameObject FPCamera;
    //[SerializeField] GameObject TPCamera;

    private Transform PlayerTrans;             //PlayerとCameraのTransform参照
    private Status Status;
    //private Animator Anim;                     //Animatorコンポーネントへの参照

    private void Awake()
    {
        PlayerTrans = GetComponent<Transform>();
        Status = GetComponent<Status>();
        //Speed = Status.Speed;　Awakeだと読み込むのが少し遅かったので

        //Anim = GetComponent<Animator>();
    }
    private void Start()
    {
      Speed = Status.Speed;
    }

    private void Update()
    {
        float X_Rotation = Input.GetAxis("Mouse X");    //マウスのX軸の値をPlayerのY軸回転に代入し、横方向だけ変えられるようにする

        PlayerTrans.transform.Rotate(0, X_Rotation * MouseSpeed, 0);

        float angleDir = PlayerTrans.transform.eulerAngles.y * (Mathf.PI / 180.0f);

        var dir1 = new Vector3(Mathf.Sin(angleDir), 0, Mathf.Cos(angleDir));

        var dir2 = new Vector3(-Mathf.Cos(angleDir), 0, Mathf.Sin(angleDir));

        if (Input.GetKey(KeyCode.W))                    //各キーに合わせて移動
        {
            PlayerTrans.transform.position += dir1 * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            PlayerTrans.transform.position += dir2 * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            PlayerTrans.transform.position += -dir2 * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            PlayerTrans.transform.position += -dir1 * Speed * Time.deltaTime;
        }

        //Animating();

        //CameraSwitching();
    }

  /*  private void Animating()    //指定されたキーに合わせてアニメーションを実行
    {
        Anim.SetBool("Run_F", Input.GetKey(KeyCode.W));　　　　

        Anim.SetBool("Walk_B", Input.GetKey(KeyCode.S));

        Anim.SetBool("Run_L", Input.GetKey(KeyCode.A));

        Anim.SetBool("Run_R", Input.GetKey(KeyCode.D));
    }

    private void CameraSwitching()
    {
        if (Input.GetMouseButtonDown(2))                    //もしマウス中央ボタンを押したら、、、
        {
            FPCamera.SetActive(!FPCamera.activeSelf);     //FPCameraがオフならFPCameraをオンにする
            TPCamera.SetActive(!TPCamera.activeSelf);     //TPCameraがオフならTPCameraをオンにする
        }
    }*/
}
