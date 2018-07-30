using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GunVoiceTest : MonoBehaviour {


    private GunVoiceTest() { }
    private static GunVoiceTest instance;
    public static GunVoiceTest Instance { get { return instance; } }

    void Awake()
    {
        instance = this;
    }

    public void Play(AudioClip clip_1, float volume_1 = 1)
    {
        GameObject newobj = new GameObject();
        newobj.transform.parent = this.transform;
        AudioSource newaudio = newobj.AddComponent<AudioSource>();
        newaudio.playOnAwake = false;
        newaudio.clip = clip_1;
        newaudio.volume = volume_1;
        newaudio.Play();
        Destroy(newobj, clip_1.length);
    }

}
