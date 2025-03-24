using UnityEngine;
using UnityEngine.SceneManagement;
using Utils;

public class GameManager : TemporalSingleton<GameManager>
{

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.LogFormat("Scene loaded: {0}", scene.name);
    }

    

    public void LoadLevel(string _LevelName)
    {
        SceneManager.LoadScene(_LevelName);
    }
}
