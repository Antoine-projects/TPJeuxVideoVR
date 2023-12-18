using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
public TextMeshProUGUI timerText;

public float currentTime;

public bool countDown;

public bool hasLimit;

public float timerLimit;



void Update(){
    currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;

    if(hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit))){
            currentTime = timerLimit;
            timerText.color = Color.red;
            enabled = false;
    }

    timerText.text = currentTime.ToString("0");
}
}
