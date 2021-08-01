using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Button buttonRestart;
  //  [SerializeField] private Button buttonResume;
    [SerializeField] private Button buttonMenu;
    [SerializeField] private string lobby;

    private void Awake()
    {
        buttonMenu.onClick.AddListener(LoadLobbyScene);
        buttonRestart.onClick.AddListener(LoadCurrentScene);
    }

    void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void LoadLobbyScene()
    {
        SceneManager.LoadScene(lobby);
    }
}
