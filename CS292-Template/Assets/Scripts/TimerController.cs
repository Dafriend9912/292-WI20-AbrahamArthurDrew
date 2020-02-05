﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class TimerController : MonoBehaviour
{
    public Text timetext;
    private float Starttime;
    public float time;
    public PauseScript pause;
    public bool active;
    public bool done;

    // Start is called before the first frame update
    void Start()
    {
        time = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.isPaused && !done)
        {
            time -= Time.deltaTime;
            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("F0");
            timetext.text = minutes + ":" + seconds;
        }
        else
        {
            active = false;
            done = true;
        }

    }

}
