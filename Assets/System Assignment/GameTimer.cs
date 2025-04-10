using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Slider slider; // use slider
    float timeLeft = 20f;// the limit of the time

    public GameObject gameLose;

    // Start is called before the first frame update
    void Start()
    {
        slider.minValue = 0; // time finished
        slider.maxValue = 20f;// how long does the time take
        slider.value = 20f;// the time
    }

    void Update()
    {

        if (timeLeft > 0) // when the time is over 0
        {
            timeLeft -= Time.deltaTime; // slider going to move
            slider.value = timeLeft;
        }
        else // when the slider's time going to 0
        {
            slider.value = 0;
        }

        if(slider.value<=0)
        {
            gameLose.SetActive(true); // the oage of lose the game will appear
        }
    }

}