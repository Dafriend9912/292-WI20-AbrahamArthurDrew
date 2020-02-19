using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class HighlightDestroyer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.highlightIsCreated == false)
        {
            Destroy(gameObject);
        }
    }
}
