using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimePassing : MonoBehaviour
{
    public Slider slider;
    public float timeMultiplier = 2f;
    float secondsInADay = 86400;

    void Update()
    {
        slider.value += Time.deltaTime * timeMultiplier / secondsInADay;
    }
}
