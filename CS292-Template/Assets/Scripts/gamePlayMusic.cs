using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class gamePlayMusic : MonoBehaviour
{
    public AudioSource audio1;
    public GameObject TitleMenu;
    public AudioClip gamePlayAudio1;
    
    // Start is called before the first frame update
    void Start()
    {
        Global.isMuted = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void mute()
    {
        if (Global.isMuted)
        {
            audio1.Play();

            Global.isMuted = false;
        }
        else
        {
            Global.isMuted = true;
            audio1.Pause();
        }
    }

    public void playGamePlayAudio()
    {
        audio1.Play();
        Global.isMuted = false;
    }

    public void stopGamePlayAudio()
    {
        audio1.Stop();
        //Global.isMuted = true;
    }



}
