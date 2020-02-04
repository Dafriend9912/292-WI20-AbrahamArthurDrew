using System.Collections;
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
    public ResultsMenu res;

    // Start is called before the first frame update
    void Start()
    {
        Starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (!pause.isPaused)
        {
            active = true;
        }
        if (active)
        {
            time += Time.deltaTime;
            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("F0");
            timetext.text = minutes + ":" + seconds;
        }
        if(Global.countdown == 0)
        {
            active = false;
            done = true;
            pause.isPaused = true;
            res.getResults();
        }

    }

}
