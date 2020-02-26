using System.Collections;
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
    public TimerController time;
    public AudioScript Audioplayer;
    public GameObject Highlight;

    // Start is called before the first frame update
    public void ButtonPress()
    {
        if (!Global.moving)
        {
            if (Global.counters == 1)
            {
                Instantiate(Highlight, SpawnPosition2.position, SpawnPosition2.rotation);
                Instantiate(IncorrectPrefab, SpawnPosition1.position, SpawnPosition1.rotation);
                if (Global.examAnswers[0] == Global.answerKeys[0])
                {
                    Global.incorrectCounter++;
                    if (time.time > 2)
                    {
                        time.time -= 2;
                    }
                    else
                    {
                        time.time = .01f;
                        Global.dontSpawnForTheLoveOfGod = true;
                    }
                    Global.incorrect = true;
                    Audioplayer.errorSound();
                }
                else
                {
                    Audioplayer.correctSound();
                    Global.score += 50;
                }
            }
            if (Global.counters == 2)
            {
                Instantiate(Highlight, SpawnPosition3.position, SpawnPosition3.rotation);
                Instantiate(IncorrectPrefab, SpawnPosition2.position, SpawnPosition2.rotation);
                if (Global.examAnswers[1] == Global.answerKeys[1])
                {
                    Global.incorrectCounter++;
                    if (time.time > 2)
                    {
                        time.time -= 2;
                    }
                    else
                    {
                        time.time = .01f;
                        Global.dontSpawnForTheLoveOfGod = true;
                    }
                    Global.incorrect = true;
                    Audioplayer.errorSound();

                }
                else
                {
                    Audioplayer.correctSound();
                    Global.score += 50;
                }
            }
            if (Global.counters == 3)
            {
                Instantiate(Highlight, SpawnPosition4.position, SpawnPosition4.rotation);
                Instantiate(IncorrectPrefab, SpawnPosition3.position, SpawnPosition3.rotation);
                if (Global.examAnswers[2] == Global.answerKeys[2])
                {
                    Global.incorrectCounter++;
                    if (time.time > 2)
                    {
                        time.time -= 2;
                    }
                    else
                    {
                        time.time = .01f;
                        Global.dontSpawnForTheLoveOfGod = true;
                    }
                    Global.incorrect = true;
                    Audioplayer.errorSound();

                }
                else
                {
                    Audioplayer.correctSound();
                    Global.score += 50;
                }
            }
            if (Global.counters == 4)
            {
                Instantiate(Highlight, SpawnPosition5.position, SpawnPosition5.rotation);
                Instantiate(IncorrectPrefab, SpawnPosition4.position, SpawnPosition4.rotation);
                if (Global.examAnswers[3] == Global.answerKeys[3])
                {
                    Global.incorrectCounter++;
                    Global.incorrect = true;
                    if (time.time > 2)
                    {
                        time.time -= 2;
                    }
                    else
                    {
                        time.time = .01f;
                        Global.dontSpawnForTheLoveOfGod = true;
                    }
                    Audioplayer.errorSound();

                }
                else
                {
                    Audioplayer.correctSound();
                    Global.score += 50;
                }
            }
            if (Global.counters == 5)
            {
                Instantiate(Highlight, SpawnPosition1.position, SpawnPosition1.rotation);
                Instantiate(IncorrectPrefab, SpawnPosition5.position, SpawnPosition5.rotation);
                if (Global.examAnswers[4] == Global.answerKeys[4])
                {
                    Global.incorrectCounter++;
                    if (time.time > 2)
                    {
                        time.time -= 2;
                    }
                    else
                    {
                        time.time = .01f;
                        Global.dontSpawnForTheLoveOfGod = true;
                    }
                    Global.incorrect = true;
                    Audioplayer.errorSound();

                }
                else
                {
                    Audioplayer.correctSound();
                    Global.score += 50;
                }
            }
            Global.counters++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
