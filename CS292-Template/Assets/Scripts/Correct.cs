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
    public TimerController time;
    public AudioScript Audioplayer;
    public class Global
    {
        public static int counters = 1;
        public static bool destroy = false;
        public static int destroyCounters = 0;
        public static int countdown = 0;
        public static List<int> answerKeys = new List<int>(5);
        public static List<int> examAnswers = new List<int>(5);
        public static int incorrectCounter = 0;
        public static bool totalDestroyer = false;
        public static int keyDestroyCount = 0;
        public static bool incorrect = false;
        public static bool keyDestroyDone = false;
    }
    public void ButtonPress()
    {
        if (Global.counters == 1)
        {
            Instantiate(CorrectPrefab, SpawnPosition1.position, SpawnPosition1.rotation);
            if (Global.examAnswers[0] != Global.answerKeys[0])
            {
                Global.incorrectCounter++;
                time.time -= 2;
                Global.incorrect = true;
                Audioplayer.errorSound();

            }
            else
            {
                Audioplayer.correctSound();
            }
        }
        if (Global.counters == 2)
        {
            Instantiate(CorrectPrefab, SpawnPosition2.position, SpawnPosition2.rotation);
            if (Global.examAnswers[1] != Global.answerKeys[1])
            {
                time.time -= 2;
                Global.incorrectCounter++;
                Global.incorrect = true;
                Audioplayer.errorSound();

            }
            else
            {
                Audioplayer.correctSound();
            }
        }
        if (Global.counters == 3)
        {
            Instantiate(CorrectPrefab, SpawnPosition3.position, SpawnPosition3.rotation);
            if (Global.examAnswers[2] != Global.answerKeys[2])
            {
                Global.incorrectCounter++;
                time.time -= 2;
                Global.incorrect = true;
                Audioplayer.errorSound();

            }
            else
            {
                Audioplayer.correctSound();
            }
        }
        if (Global.counters == 4)
        {
            Instantiate(CorrectPrefab, SpawnPosition4.position, SpawnPosition4.rotation);
            if (Global.examAnswers[3] != Global.answerKeys[3])
            {
                Global.incorrectCounter++;
                time.time -= 2;
                Global.incorrect = true;
                Audioplayer.errorSound();

            }
            else
            {
                Audioplayer.correctSound();
            }
        }
        if (Global.counters == 5)
        {
            Instantiate(CorrectPrefab, SpawnPosition5.position, SpawnPosition5.rotation);
            if (Global.examAnswers[4] != Global.answerKeys[4])
            {
                Global.incorrectCounter++;
                time.time -= 2;
                Global.incorrect = true;
                Audioplayer.errorSound();

            }
            else
            {
                Audioplayer.correctSound();
            }
        }
        Global.counters++;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
