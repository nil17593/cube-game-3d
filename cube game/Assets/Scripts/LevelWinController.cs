using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelWinController : MonoBehaviour
{
    [SerializeField] GameObject levelcomlete;
    [SerializeField] private PlayerController playerController;
    [SerializeField] Button buttonMenu;
    [SerializeField] Button buttonNextLevel;
    [SerializeField] string lobby;

    private void Awake()
    {
        buttonMenu.onClick.AddListener(LoadLobby);
        buttonNextLevel.onClick.AddListener(LoadNextLevel);
    }

    private void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void LoadLobby()
    {
        SceneManager.LoadScene(lobby);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            levelcomlete.SetActive(true);
            playerController.enabled = false;
        }
    }
}
