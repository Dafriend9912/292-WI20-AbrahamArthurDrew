using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class PauseScript : MonoBehaviour
{
    public GameObject TitleMenu;
    public GameObject AboutScreen;
    public GameObject pauseMenu;
    public GameObject resultsScreen;
    public bool isPaused;
    public TimerController time;
    public AudioScript audio;
    public KeyGenerator keys;
    public ExamGenerator exam;
    public HighlightSpawn highlightSpawn;


    // Start is called before the first frame update
    void Start()
    {
        TitleMenu.SetActive(true);
        audio.playTitleAudio();
        pauseMenu.SetActive(false);
        AboutScreen.SetActive(false);
        isPaused = true;
        Global.isMuted = false;
    }

    // Update is called once per frame
    void Update()
    {



    }
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        TitleMenu.SetActive(false);

        isPaused = true;
        time.active = false;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isPaused = false;
        time.active = true;
    }

    public void Exit()
    {
        //GameObject a = GameObject.Find("Title Screen").GetComponent<TitleScript>().GetT();

        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
        isPaused = true;
        time.active = false;
        TitleMenu.SetActive(true);
        time.time = 60;
        audio.stopGampPlayAudio();
        Global.destroy = true;
        Global.counters = 6;
        Global.destroyCounters = 0;
        Global.totalDestroyer = true;
        Global.countdown = 0;
        Global.highlightIsCreated = true;

    }

    public void PlayGame()
    {
        Time.timeScale = 1f;
        TitleMenu.SetActive(false);
        pauseMenu.SetActive(false);
        isPaused = false;
        time.done = false;
        time.active = true;
        audio.playGamePlayAudio();
        Global.counters = 1;
        Global.destroyCounters = 0;
        keys.keyGenerate();
        exam.ExamGenerate();
        Global.highlightIsCreated = false;
        highlightSpawn.SpawnHightlight();
        
        resultsScreen.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


    public void DisplayAbout()
    {
        Time.timeScale = 0f;
        AboutScreen.SetActive(true);
        time.active = false;
    }

    public void CloseAbout()
    {
        Time.timeScale = 0f;
        AboutScreen.SetActive(false);
        
    }
}
