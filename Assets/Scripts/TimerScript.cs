using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public float TimeValue;

    //in-game timer
    public TMP_Text Timer;
    public TMP_Text Timer2;
    //Final score
    public TMP_Text FinalScore;

    public GameObject EndScreen;

    public GameObject RedBox;
    public GameObject GreenBox;
    public GameObject YellowBox;
    public GameObject RedBarrel;
    public GameObject GreenBarrel;
    public GameObject YellowBarrel;

    public GameObject Spawner;

    void Start()
    {
        TimeValue = 45;

        EndScreen.SetActive(false);

    }

    void Update()
    {
        //countdown
        TimeValue -= Time.deltaTime;

        //display time        //rounds to single digits from float
        Timer.text = "Time:" + Mathf.Round(TimeValue) / 1f;
        Timer2.text = "Time:" + Mathf.Round(TimeValue) / 1f;

        //activate end state
        if (TimeValue <= 0)
        {
            EndScreen.SetActive(true);

            //record final score
            FinalScore.text = "Score:" + Counter.Points;

            RedBox.SetActive(false);
            GreenBox.SetActive(false);
            YellowBox.SetActive(false);
            RedBarrel.SetActive(false);
            GreenBarrel.SetActive(false);
            YellowBarrel.SetActive(false);

            Spawner.SetActive(false);
        }
    }
}
