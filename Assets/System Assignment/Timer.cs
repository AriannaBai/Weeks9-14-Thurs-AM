using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;



    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 2;
        slider.value = slider.maxValue;

        StartCoroutine(ResetTimer());

    }



    IEnumerator ResetTimer()
    {
        while (slider.value > slider.minValue)
        {
            slider.value += Time.deltaTime;
            yield return null;
        }
    }

}
