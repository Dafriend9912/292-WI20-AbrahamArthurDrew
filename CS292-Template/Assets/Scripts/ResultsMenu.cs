using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultsMenu : MonoBehaviour
{
    public Text timeTaken;
    public Text timeAdded;
    public Text timeFinal;
    public Text HiScore;
    public Text HiScoreText;
    public float Score;
    public float highestScore = 100000000;
    public TimerController timer;
    public int wrongs = 0;
    public bool first = true;
    public GameObject playAgain;
    public GameObject Exit;
    public GameObject titleScreen;
    public GameObject resultsScreen;

    // Start is called before the first frame update
    void Start()
    {
        highestScore = 1000000;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timer.active)
        {
            Score = timer.time;
            timeTaken.text = ((int)Score / 60) + ":" + ((int)Score % 60);
            timeAdded.text = (wrongs).ToString();
            Score = Score + wrongs;
            timeFinal.text = ((int)Score / 60) + ":" + ((int)Score % 60);
            if (first)
            {
                if (highestScore > Score)
                {
                    HiScore.text = ((int)Score / 60) + ":" + ((int)Score % 60);
                    HiScoreText.text = "NEW HI-SCORE:";
                    highestScore = Score;
                    first = false;
                }
                else
                {
                    HiScore.text = ((int)highestScore / 60) + ":" + ((int)highestScore % 60);
                    HiScoreText.text = "Hi-Score:";
                    first = false;
                }
            }
        }
    }
    private void OnMouseUp()
    {
        if (this.gameObject == Exit)
        {
            resultsScreen.SetActive(false);
            titleScreen.SetActive(true);
            timer.active = false;
        }
        else
        {
            resultsScreen.SetActive(false);
            timer.active = true;
        }
    }
}
