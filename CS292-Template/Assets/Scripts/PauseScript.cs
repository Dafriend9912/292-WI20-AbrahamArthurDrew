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
    
    
        

    // Start is called before the first frame update
    void Start()
    {
        TitleMenu.SetActive(true);
        pauseMenu.SetActive(false);
        isPaused = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    
        
    }
    public void PauseGame()
    {
        //Time.timeScale = 0f;
        pauseMenu.SetActive(true);
        TitleMenu.SetActive(false);
  
        isPaused = true;
    }

    public void ContinueGame()
    {
        //Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        isPaused = false;
    }

    public void Exit()
    {
        //GameObject a = GameObject.Find("Title Screen").GetComponent<TitleScript>().GetT();
        
        //Time.timeScale = 0f;
        pauseMenu.SetActive(false);
        isPaused = false;
        TitleMenu.SetActive(true);
        
       
    }

    public void PlayGame()
    {
        //Time.timeScale = 0f;
        TitleMenu.SetActive(false);
        pauseMenu.SetActive(false);
        isPaused = false;
    }




}
