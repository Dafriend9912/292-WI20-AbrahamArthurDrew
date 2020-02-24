using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class TitleSound : MonoBehaviour
{
    public AudioSource audio2;
    public GameObject TitleMenu;
    public AudioClip titleSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mute()
    {
        if (Global.isMuted)
        {
            audio2.Play();

            Global.isMuted = false;
        }
        else
        {
            Global.isMuted = true;
            audio2.Pause();
        }
    }
    public void playTitleAudio()
    {
        audio2.Play();
        Global.isMuted = false;
    }

    public void stopTitleAudio()
    {
        audio2.Stop();
        
    }
}
