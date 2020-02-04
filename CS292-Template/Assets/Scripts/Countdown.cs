using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public Text numLeft; 

    // Update is called once per frame
    void Update()
    {
        numLeft.text = Global.countdown.ToString();
    }
}
