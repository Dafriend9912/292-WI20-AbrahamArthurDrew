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
    public KeyGenerator keys;
    public ExamGenerator examGenerator;
    public HighlightSpawn highlightSpawn;
    public gamePlayMusic audio1;
    public TitleSound audio2;
    // Start is called before the first frame update
    void Start()
    {
        highestScore = PlayerPrefs.GetFloat("HI-SCORE");
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
            Score = Global.score;
            examsGraded.text = Global.score.ToString();
                if (highestScore < Score)
                {
                    HiScore.text = Score.ToString();
                    HiScoreText.text = "NEW HI-SCORE:";
                    highestScore = Score;
                    first = false;
                    PlayerPrefs.SetFloat("HI-SCORE", highestScore);
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
        Global.dontSpawnForTheLoveOfGod = false;
        timer.time = 60;
        Global.totalDestroyer = true;
        keys.keyGenerate();
        Global.destroy = true;
        Global.counters = 6;
        Global.destroyCounters = 10;
        Debug.Log(Global.totalDestroyer);
        Global.countdown = -1;
        Global.highlightIsCreated = false;
        highlightSpawn.SpawnHightlight();
        Global.score = 0;
        timer.pause.isPaused = false;
        timer.done = false;
        timer.active = true;
        resultsScreen.SetActive(false);
    }
    public void ExittoMenu()
    {
        resultsScreen.SetActive(false);
        titleScreen.SetActive(true);
        timer.active = false;
        timer.pause.isPaused = true;
        timer.time = 60;
        audio1.stopGamePlayAudio();
        if (!Global.isMuted)
        {
            audio2.playTitleAudio();
        }
        Global.counters = 6;
        Global.destroy = false;
        Global.destroyCounters = 0;
        Global.totalDestroyer = true;
        Global.countdown = 0;
        Global.highlightIsCreated = true;
        Global.score = 0;
    }
}
