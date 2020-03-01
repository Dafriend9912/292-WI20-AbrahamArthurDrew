using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Correct;

public class ExamGenerator : MonoBehaviour
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
    public int AnswerSkew = 80;
    public Animator paper1;
    public Animator paper2;
    public GameObject Highlight;
    void Start()
    { 
    }

    private void Update()
    {
        if(Global.destroy == true && Global.destroyCounters == 10)
        {
            Global.destroy = false;
            Global.counters = 1;
            Global.destroyCounters = 0;
            Global.examAnswers.Clear();
            Global.countdown++;
            Global.counters = 1;
            Global.moving = true;
            Global.highlightIsCreated = true;
            if (Global.incorrect == false)
            {
                Global.score += 250;
            }
            else
            {
                Global.incorrect = false;
            }
            paper1.Play("Moving paper");
            paper2.Play("Moving on");
            StartCoroutine(Coroutine());
            print("aaa");
        }
    }




    public void ExamGenerate(){
        prefabList.Add(Prefab1);
        prefabList.Add(Prefab2);
        prefabList.Add(Prefab3);
        prefabList.Add(Prefab4);
        prefabList.Add(Prefab5);

        for (int i = 0; i < 5; i++)
        {
            if (!Global.dontSpawnForTheLoveOfGod == true)
            {
                int prefabIndex = UnityEngine.Random.Range(0, 5);
                int skew = UnityEngine.Random.Range(0, 100);
                if (i == 0 && skew >= AnswerSkew)
                {
                    Instantiate(prefabList[prefabIndex], SpawnPosition1.position, SpawnPosition1.rotation);
                    Global.examAnswers.Add(prefabIndex);
                }
                if (i == 1 && skew >= AnswerSkew)
                {
                    Instantiate(prefabList[prefabIndex], SpawnPosition2.position, SpawnPosition2.rotation);
                    Global.examAnswers.Add(prefabIndex);
                }
                if (i == 2 && skew >= AnswerSkew)
                {
                    Instantiate(prefabList[prefabIndex], SpawnPosition3.position, SpawnPosition3.rotation);
                    Global.examAnswers.Add(prefabIndex);
                }
                if (i == 3 && skew >= AnswerSkew)
                {
                    Instantiate(prefabList[prefabIndex], SpawnPosition4.position, SpawnPosition4.rotation);
                    Global.examAnswers.Add(prefabIndex);
                }
                if (i == 4 && skew >= AnswerSkew)
                {
                    Instantiate(prefabList[prefabIndex], SpawnPosition5.position, SpawnPosition5.rotation);
                    Global.examAnswers.Add(prefabIndex);
                }
                if (i == 0 && skew < AnswerSkew)
                {
                    Instantiate(prefabList[Global.answerKeys[0]], SpawnPosition1.position, SpawnPosition1.rotation);
                    Global.examAnswers.Add(Global.answerKeys[0]);
                }
                if (i == 1 && skew < AnswerSkew)
                {
                    Instantiate(prefabList[Global.answerKeys[1]], SpawnPosition2.position, SpawnPosition2.rotation);
                    Global.examAnswers.Add(Global.answerKeys[1]);
                }
                if (i == 2 && skew < AnswerSkew)
                {
                    Instantiate(prefabList[Global.answerKeys[2]], SpawnPosition3.position, SpawnPosition3.rotation);
                    Global.examAnswers.Add(Global.answerKeys[2]);
                }
                if (i == 3 && skew < AnswerSkew)
                {
                    Instantiate(prefabList[Global.answerKeys[3]], SpawnPosition4.position, SpawnPosition4.rotation);
                    Global.examAnswers.Add(Global.answerKeys[3]);
                }
                if (i == 4 && skew < AnswerSkew)
                {
                    Instantiate(prefabList[Global.answerKeys[4]], SpawnPosition5.position, SpawnPosition5.rotation);
                    Global.examAnswers.Add(Global.answerKeys[4]);
                }
            }
        }
    }
    public IEnumerator Coroutine()
    {
        yield return new WaitForSeconds(.5f);
        ExamGenerate();
        Global.highlightIsCreated = false;
        Instantiate(Highlight, SpawnPosition1.position, SpawnPosition1.rotation);
        Global.moving = false;
    }
}
