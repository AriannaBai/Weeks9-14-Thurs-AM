using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Slider slider;
    float timeLeft = 20f;

    public GameObject gameLose;

    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0;
        slider.maxValue = 20f;
        slider.value = 20f;
    }

    void Update()
    {

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            slider.value = timeLeft;
        }
        else
        {
            slider.value = 0;
        }

        if(slider.value<=0)
        {
            gameLose.SetActive(true);
        }
    }

}