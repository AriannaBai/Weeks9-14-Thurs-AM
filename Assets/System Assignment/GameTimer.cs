using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private Text timerText;
    private float timeLeft = 120f;
    public TextMeshProUGUI time;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            timerText.text = "0:00";
            Time.timeScale = 0;
            Debug.Log("GAME FINISHED");


        }
    }
    void UpdateTimerDisplay()
    {
        int minutes = (int)(timeLeft / 60);
        int seconds = (int)(timeLeft % 60);
        timerText.text = minutes + ":" + seconds.ToString("00");

    }
}