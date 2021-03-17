using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

[ExecuteInEditMode]
public class HourFromSlider : MonoBehaviour
{

	public Slider slider;
	public TextMeshProUGUI text;

    void Update()
    {
		text.text = ToHourAndMinutes(slider.value);
    }

    string ToHourAndMinutes(float time)
    {
    	// time displayed as hh:mm, like 12:34

    	int hours = Mathf.FloorToInt(time * 24);
		int minutes = Mathf.FloorToInt((time * 24 * 60) % 60);

    	return (hours < 10 ? "0" : "") + hours.ToString() + ":" + (minutes < 10 ? "0" : "") + minutes.ToString();
    }
}
