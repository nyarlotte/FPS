using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour{
  //曲を入れるためのコンポーネント
  public AudioClip audioClip1;
  private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {

      audioSource = gameObject.GetComponent<AudioSource>();
        //ここを変えると音が切り替わる
            audioSource.clip = audioClip1;
            audioSource.Play ();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
