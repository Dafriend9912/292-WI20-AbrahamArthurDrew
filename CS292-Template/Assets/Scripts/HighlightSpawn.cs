using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class HighlightSpawn : MonoBehaviour
{
    public GameObject Highlight;
    public Transform SpawnPosition1;
    public Transform SpawnPosition2;
    public Transform SpawnPosition3;
    public Transform SpawnPosition4;
    public Transform SpawnPosition5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.counters == 1 && Global.highlightIsCreated == false)
        {
            Instantiate(Highlight, SpawnPosition1.position, SpawnPosition1.rotation);
            Global.highlightIsCreated = true;
        }
        if (Global.counters == 2 && Global.highlightIsCreated == false)
        {
            Instantiate(Highlight, SpawnPosition2.position, SpawnPosition2.rotation);
            Global.highlightIsCreated = true;
        }
        if (Global.counters == 3 && Global.highlightIsCreated == false)
        {
            Instantiate(Highlight, SpawnPosition3.position, SpawnPosition3.rotation);
            Global.highlightIsCreated = true;
        }
        if (Global.counters == 4 && Global.highlightIsCreated == false)
        {
            Instantiate(Highlight, SpawnPosition4.position, SpawnPosition4.rotation);
            Global.highlightIsCreated = true;
        }
        if (Global.counters == 5 && Global.highlightIsCreated == false)
        {
            Instantiate(Highlight, SpawnPosition5.position, SpawnPosition5.rotation);
            Global.highlightIsCreated = true;
        }

    }
}
