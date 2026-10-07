using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Reference: https://discussions.unity.com/t/simple-timer-56201/56201/2
    public float targetTime = 60.0f;

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            SceneManager.LoadScene("Loss");
        }
    }
}
