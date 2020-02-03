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
        if(Global.counters > 5)
        {
            Destroy(gameObject);
        }
    }
}
