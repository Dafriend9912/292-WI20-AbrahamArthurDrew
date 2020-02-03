using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Global.counters == 6)
        {
            Destroy(gameObject);
            Global.destroy = true;
            Global.destroyCounters++;
            Debug.Log(Global.destroyCounters);
        }
    }
}
