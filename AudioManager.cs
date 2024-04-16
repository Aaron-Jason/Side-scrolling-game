using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("-Audio Source --")]
    [SerializeField] AudioSource SFXSource;

    [Header("-- Audio Clip --")]
    public AudioClip jump;
    public AudioClip death;
    public AudioClip point;
    public AudioClip button;
    public AudioClip portal;
    public AudioClip finish;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
