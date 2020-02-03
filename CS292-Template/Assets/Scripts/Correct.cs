using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Correct : MonoBehaviour
{
    public Transform SpawnPosition1;
    public Transform SpawnPosition2;
    public Transform SpawnPosition3;
    public Transform SpawnPosition4;
    public Transform SpawnPosition5;
    public GameObject CorrectPrefab;
    public class Global
    {
        public static int counters = 1;
    }
    public void ButtonPress()
    {
        if (Global.counters == 1)
        {
            Instantiate(CorrectPrefab, SpawnPosition1.position, SpawnPosition1.rotation);
        }
        if (Global.counters == 2)
        {
            Instantiate(CorrectPrefab, SpawnPosition2.position, SpawnPosition2.rotation);
        }
        if (Global.counters == 3)
        {
            Instantiate(CorrectPrefab, SpawnPosition3.position, SpawnPosition3.rotation);
        }
        if (Global.counters == 4)
        {
            Instantiate(CorrectPrefab, SpawnPosition4.position, SpawnPosition4.rotation);
        }
        if (Global.counters == 5)
        {
            Instantiate(CorrectPrefab, SpawnPosition5.position, SpawnPosition5.rotation);
        }
        Global.counters++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
