using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class HighlightSpawn : MonoBehaviour
{
    public GameObject Highlight;
    public Transform SpawnPosition1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void SpawnHightlight()
    {
       Instantiate(Highlight, SpawnPosition1.position, SpawnPosition1.rotation);
    }
}
