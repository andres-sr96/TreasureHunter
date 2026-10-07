using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    // Reference: https://discussions.unity.com/t/simple-timer-56201/56201/2
    // Reference: https://www.youtube.com/watch?v=POq1i8FyRyQ 
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float targetTime = 60.0f;

    void Update()
    {
        targetTime -= Time.deltaTime;

        if (targetTime <= 10)
        {
            timerText.color = Color.red;
        }

        if (targetTime <= 0.0f)
        {
            SceneManager.LoadScene("Loss");
            return;
        }

        int minutes = Mathf.FloorToInt(targetTime /  60);
        int seconds = Mathf.FloorToInt(targetTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
