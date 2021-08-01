using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyController : MonoBehaviour
{
    [SerializeField] Button buttonPlay;
    [SerializeField] string gameScene;
    private void Awake()
    {
        buttonPlay.onClick.AddListener(LoadGame);
    }

    void LoadGame()
    {
        SceneManager.LoadScene(gameScene);
    }
}
