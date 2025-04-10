using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int currentScore = 0;

    public void AddScore()
        {
        currentScore++;
        scoreText.text = currentScore.ToString();
        if(currentScore >= 20)
        {
            Time.timeScale = 0;
            Debug.Log("Win The Game!!");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
