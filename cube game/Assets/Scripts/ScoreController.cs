using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject gameOver;
    private TextMeshProUGUI scoreText;
    [SerializeField] PlayerCollisions playerCollisions;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    
    void Update()
    {
        IncreaseScore();
    }

    void IncreaseScore()
    {
        if (!playerCollisions.gameover)
        {
            scoreText.text = player.position.z.ToString("Score:0");
        }
        else
        {
            gameOver.SetActive(true);
        }
    }
}
