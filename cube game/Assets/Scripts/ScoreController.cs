using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private int score;
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        RefreshUI();
    }
    
    void Update()
    {
        //Debug.Log(player.position.z);
        scoreText.text = player.position.z.ToString("0");
    }

    void RefreshUI()
    {
        scoreText.text = "Score" + score;
    }
}
