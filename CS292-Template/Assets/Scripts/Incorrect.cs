﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class Incorrect : MonoBehaviour
{
    public Transform SpawnPosition1;
    public Transform SpawnPosition2;
    public Transform SpawnPosition3;
    public Transform SpawnPosition4;
    public Transform SpawnPosition5;
    public GameObject IncorrectPrefab;
    
    // Start is called before the first frame update
    public void ButtonPress()
    {
        Global.counters++;
        if (Global.counters == 1)
        {
            Instantiate(IncorrectPrefab, SpawnPosition1.position, SpawnPosition1.rotation);
        }
        if (Global.counters == 2)
        {
            Instantiate(IncorrectPrefab, SpawnPosition2.position, SpawnPosition2.rotation);
        }
        if (Global.counters == 3)
        {
            Instantiate(IncorrectPrefab, SpawnPosition3.position, SpawnPosition3.rotation);
        }
        if (Global.counters == 4)
        {
            Instantiate(IncorrectPrefab, SpawnPosition4.position, SpawnPosition4.rotation);
        }
        if (Global.counters == 5)
        {
            Instantiate(IncorrectPrefab, SpawnPosition5.position, SpawnPosition5.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
