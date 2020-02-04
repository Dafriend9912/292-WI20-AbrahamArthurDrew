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
    public bool active = false;
    

    // Start is called before the first frame update
    void Start()
    {
        Starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.countdown == 0)
        {
            active = false;
        }
        if(active && !paused)
        {
            time += Time.deltaTime;
            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("F0");
            timetext.text = minutes + ":" + seconds;
        }

    }

}
