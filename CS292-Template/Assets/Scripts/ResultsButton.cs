using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResultsButton : MonoBehaviour
{
    public GameObject playAgain;
    public GameObject Exit;
    public GameObject titleScreen;
    public GameObject resultsScreen;
    public TimerController timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseUp()
    {
        if (this.gameObject == Exit)
        {
            resultsScreen.SetActive(false);
            titleScreen.SetActive(true);
            timer.active = false;
            timer.pause.isPaused = true;
        }
        else
        {
            resultsScreen.SetActive(false);
            timer.active = true;
        }
    }
}
