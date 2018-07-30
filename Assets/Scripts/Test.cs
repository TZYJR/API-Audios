using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public sealed class Test : MonoBehaviour{

    AudioSource audioSource;
    [SerializeField]
    Slider volumeSlider;


    void Awake()
    {
        // Gameobject.Find("")  查找名字为“”的物体
        audioSource = GameObject.Find("Audios").GetComponent<AudioSource>();
    }

    //  isPlaying  是否正在播放、播放状态测试

    public void OnPlayBtnClick()
    {
        if (!audioSource.isPlaying)
            audioSource.Play();
    }

    public void OnPauseBtnClick()
    {
        if (audioSource.isPlaying)
            audioSource.Pause();
    }

    public void OnStopBtnClick()
    {
        if (audioSource.isPlaying)
            audioSource.Stop();
    }
   
    public void OnVolumeChanged()
    {
        print("七月");
        audioSource.volume = volumeSlider.value;
    }

    public void OnMuteBtnClick()
    {
        //if (audioSource.mute)
        //    audioSource.mute = false;
        //else
        //    audioSource.mute = true;

        volumeSlider.value = 0;
    }
    
}
