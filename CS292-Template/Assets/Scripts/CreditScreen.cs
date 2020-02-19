using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScreen : MonoBehaviour
{
    public GameObject Creditscreen;

    // Start is called before the first frame update
    void Start()
    {
        Creditscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openCredits()
    {
        Creditscreen.SetActive(true);
    }

    public void closeCredits()
    {
        Creditscreen.SetActive(false);
    }
}
