﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionsCorrect : MonoBehaviour
{
    public static int Correct = 0;
    public static int Streak = 0;
    public static string last = "";
    Text count;
    // Start is called before the first frame update
    void Start()
    {
        count = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        last = count.text;
        count.text = Correct.ToString();
        if (count.text != last)
        {
            Streak += 1;
        }
        else
        {
            Streak = 0;
        }
    }
}
