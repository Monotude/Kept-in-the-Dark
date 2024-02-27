using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }
    [SerializeField] private Sound[] musicSounds, sFXSounds;
    [SerializeField] private AudioSource musicSource, sFXSource;

    public void PlayMusic(string name)
    {
        Sound sound = Array.Find(musicSounds, sound => sound.Name == name);
        musicSource.clip = sound.AudioClip;
        musicSource.Play();
    }

    public void PlaySFX(string name)
    {
        Sound sound = Array.Find(sFXSounds, sound => sound.Name == name);
        sFXSource.PlayOneShot(sound.AudioClip);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayMusic("Section 1 Horror");
    }
}

[Serializable]
internal class Sound
{
    [SerializeField] private string name;
    [SerializeField] private AudioClip audioClip;

    public string Name { get => this.name; set => this.name = value; }
    public AudioClip AudioClip { get => this.audioClip; set => this.audioClip = value; }
}