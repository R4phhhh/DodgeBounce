using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource sfxSource;

    public AudioClip bgm;
    public AudioClip dieSfx;

    public void Start()
    {
        musicSource.clip = bgm;
        musicSource.Play();
    }
    public void die()
    {
        sfxSource.PlayOneShot(dieSfx);
        sfxSource.Play();
    }
}
