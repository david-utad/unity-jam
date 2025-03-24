using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManager : MonoBehaviour
{
    /**
    * This method is used to start the game.
    */
    public void ExitGame()
    {
        Application.Quit();
    }

    /**
    * This method is used to load the game.
    */
    public void LoadLevel(string _LevelName)
    {
        SceneManager.LoadScene(_LevelName);
    }
}
