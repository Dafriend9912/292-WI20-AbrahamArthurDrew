using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject TitleMenu;
    public GameObject pauseMenu;
    public bool isPaused;
    public TimerController time;
    public AudioScript audio;
    
        

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

    }




}
