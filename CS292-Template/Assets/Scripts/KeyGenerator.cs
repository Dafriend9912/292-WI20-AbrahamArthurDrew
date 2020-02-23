using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class KeyGenerator : MonoBehaviour
{
    public Transform SpawnPosition1;
    public Transform SpawnPosition2;
    public Transform SpawnPosition3;
    public Transform SpawnPosition4;
    public Transform SpawnPosition5;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Prefab1;
    public GameObject Prefab2;
    public GameObject Prefab3;
    public GameObject Prefab4;
    public GameObject Prefab5;
    void Start()
    {
    }
    public void keyGenerate() {
        Global.answerKeys.Clear();
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);

        for (int i = 0; i < 5; i++)
        {
            int prefabIndex = UnityEngine.Random.Range(0, 5);
            if (i == 0)
            {
                Instantiate(prefabList[prefabIndex], SpawnPosition1.position, SpawnPosition1.rotation);
                Global.answerKeys.Add(prefabIndex);
            }
            if (i == 1)
            {
                Instantiate(prefabList[prefabIndex], SpawnPosition2.position, SpawnPosition2.rotation);
                Global.answerKeys.Add(prefabIndex);

            }
            if (i == 2)
            {
                Instantiate(prefabList[prefabIndex], SpawnPosition3.position, SpawnPosition3.rotation);
                Global.answerKeys.Add(prefabIndex);

            }
            if (i == 3)
            {
                Instantiate(prefabList[prefabIndex], SpawnPosition4.position, SpawnPosition4.rotation);
                Global.answerKeys.Add(prefabIndex);

            }
            if (i == 4)
            {
                Instantiate(prefabList[prefabIndex], SpawnPosition5.position, SpawnPosition5.rotation);
                Global.answerKeys.Add(prefabIndex);

            }
        }

    }
    private void Update()
    {
        if (Global.keyDestroyDone)
        {
            Global.totalDestroyer = false;
            Global.keyDestroyDone = false;
            Global.keyDestroyCount = 0;
            print("worked");
        }
    }
}

