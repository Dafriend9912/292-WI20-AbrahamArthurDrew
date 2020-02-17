using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;


public class KeyDestroyer : MonoBehaviour
{
    public KeyGenerator key;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Global.totalDestroyer == true)
        {
            Global.keyDestroyCount++;
            Destroy(gameObject);
            if(Global.keyDestroyCount == 5)
            {
                Global.keyDestroyDone = true;
            }
        }
    }
    public void Dest()
    {
        Destroy(gameObject);
    }
}
