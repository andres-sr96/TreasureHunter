using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTerrain : MonoBehaviour
{
    public void LoadTerrainMap()
    {
        Debug.Log("Loading the Treasure Terrain scene...");
        SceneManager.LoadScene("TreasureTerrain");
    }

    // Reference: https://discussions.unity.com/t/how-to-make-a-quit-button-work/651917/10
    public void ExitGame()
    {
        Debug.Log("Exiting the game...");

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit ();
        #endif
    }
}
