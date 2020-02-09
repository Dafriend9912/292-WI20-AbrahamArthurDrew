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
    public ResultsMenu Results;

    // Start is called before the first frame update
    void Start()
    {
        time = 5f;
        done = false;
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (pause.isPaused == false && !done)
        {
            time -= Time.deltaTime;
            timetext.text = time.ToString("F0");
            if (time <= 0)
            {
                done = true;
                active = false;
                Global.counters = 6;
                Results.Resultsactive();
            }
        }
        else if (pause.isPaused == true)
        {

        }

    }

}
