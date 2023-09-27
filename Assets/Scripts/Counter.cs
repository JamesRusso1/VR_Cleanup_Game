using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public static int Points;

    public TMP_Text Score;
    public TMP_Text Score2;

    private void Update()
    {
        Score.text = "Score:" + Points;
        Score2.text = "Score:" + Points;
    }
}
