using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundConfig : MonoBehaviour
{
  [SerializeField]
  public Slider VolumeBar;
  public GameObject Camera;
   AudioSource Sound;
  public void Start()
    {
      Sound= Camera.GetComponent<AudioSource>();
      VolumeBar = gameObject.GetComponent<Slider>();
    }
    public void Update()
      {
         VolumeChange();
      }
    public void VolumeChange(){
      Sound.volume = VolumeBar.value;
    }

}
