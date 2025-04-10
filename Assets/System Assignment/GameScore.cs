using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScore : MonoBehaviour
{
    public TextMeshPro scoreText;
    private int currentScore = 0;

    public void AddScore()
        {
        currentScore++;
        scoreText.text = string.Format("score:{0}/20", currentScore);
        if(currentScore >= 20)
        {
            Time.timeScale = 0;
            Debug.Log("Win The Game!!");
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
