using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;

    [Header("------Audio Clip------")]
    public AudioClip fire;
    public AudioClip death;
    public AudioClip collision;

    public void Playbeat(AudioClip clip){
        musicSource.PlayOneShot(clip);
    }
}
