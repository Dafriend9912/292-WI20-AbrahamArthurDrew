using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class ResultsMenu : MonoBehaviour
{
    public Text examsGraded;
    public Text HiScore;
    public Text HiScoreText;
    public float Score;
    public float highestScore = 0;
    public TimerController timer;
    public int wrongs = 0;
    public bool first = true;
    public GameObject playAgain;
    public GameObject Exit;
    public GameObject titleScreen;
    public GameObject resultsScreen;
    public ExamGenerator examGenerator;

    // Start is called before the first frame update
    void Start()
    {
        highestScore = 0;
        resultsScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Resultsactive()
    {
        if (timer.done)
        {
            resultsScreen.SetActive(true);
            Score = Global.countdown;
            examsGraded.text = Global.countdown.ToString();
                if (highestScore < Score)
                {
                    HiScore.text = Score.ToString();
                    HiScoreText.text = "NEW HI-SCORE:";
                    highestScore = Score;
                    first = false;
                }
                else
                {
                    HiScore.text = highestScore.ToString();
                    HiScoreText.text = "Hi-Score:";
                    first = false;
                }
        }
    }

    public void Replay()
    {
        resultsScreen.SetActive(false);
        timer.time = 60;
        timer.pause.isPaused = false;
        timer.done = false;
        timer.active = true;
        Global.destroy = true;
        Global.destroyCounters = 10;
        Global.totalDestroyer = true;
        Debug.Log(Global.totalDestroyer);
        Global.countdown = -1;
        
    }
    public void ExittoMenu()
    {
        resultsScreen.SetActive(false);
        titleScreen.SetActive(true);
        timer.active = false;
        timer.pause.isPaused = true;
    }

}
