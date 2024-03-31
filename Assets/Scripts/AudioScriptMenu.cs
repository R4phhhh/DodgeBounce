using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScriptMenu : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip bgm;

    public void Start()
    {
        musicSource.clip = bgm;
        musicSource.Play();
    }
}
