using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Correct;

public class PauseScript : MonoBehaviour
{
    public GameObject TitleMenu;
    public GameObject pauseMenu;
    public GameObject resultsScreen;
    public bool isPaused;
    public TimerController time;
    public AudioScript audio;
    public KeyGenerator keys;
    public ExamGenerator exam;
    
        

    // Start is called before the first frame update
    void Start()
    {
        TitleMenu.SetActive(true);
        audio.playTitleAudio();
        pauseMenu.SetActive(false);
        isPaused = true;
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
        
        Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        isPaused = false;
        TitleMenu.SetActive(true);
        time.time = 60;
        Global.destroy = true;
        Global.destroyCounters = 10;
        Global.totalDestroyer = true;
        Global.countdown = -1;

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
        keys.keyGenerate();
        exam.ExamGenerate();
        

        resultsScreen.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }



}
