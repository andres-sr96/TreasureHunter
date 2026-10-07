using UnityEngine;
using UnityEngine.SceneManagement;

public class Treasure : MonoBehaviour
{
    void Update()
    {
        GameObject cubePlayer = GameObject.Find("CubePlayer");

        if (GetComponent<Collider>().bounds.Contains(cubePlayer.transform.position))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
