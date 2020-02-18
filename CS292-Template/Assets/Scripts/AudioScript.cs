using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;


public class AudioScript : MonoBehaviour
{
    public GameObject TitleMenu;
    public AudioClip incorrectAudio;
    public AudioClip correctAudio;
    public AudioClip titleAudio;
    public AudioSource audio;
    public AudioClip gamePlayAudio;
    public bool MuteSfx = false;
    //public Button CorrectButton;    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mute()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    public void muteSfx()
    {
        if (MuteSfx == false)
        {
            MuteSfx = true;
        }else
        {
            MuteSfx = false;
        }
    }
    public void errorSound()
    {
        if (!MuteSfx)
            audio.PlayOneShot(incorrectAudio);
    }
    public void correctSound()
    {
        if (!MuteSfx)
            audio.PlayOneShot(correctAudio);
    }
    public void playTitleAudio()
    {
               audio.PlayOneShot(titleAudio);  
    }

    public void playGamePlayAudio()
    {
        audio.PlayOneShot(gamePlayAudio);
    }
    }
