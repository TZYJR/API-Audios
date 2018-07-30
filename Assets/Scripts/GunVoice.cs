using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GunVoice : MonoBehaviour,IPointerClickHandler {

    [SerializeField]
    AudioClip clip;

    public float Volume = 0.5f;

    public void OnPointerClick(PointerEventData evenDate)
    {
        GunVoiceTest.Instance.Play(clip,Volume);
    }

}
