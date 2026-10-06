using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    private float timeRemaining = 60f; // Set initial time in seconds
    private bool timerIsRunning = false;

    public TMP_Text loseText;

    public TextMeshProUGUI timerText; // Drag your TextMeshPro UI object here

    private void Start()
    {
        // Starts the timer automatically when the scene begins
        timerIsRunning = true;
    }

    private void Update()
    {

        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                // Subtract the time passed since the last frame
                timeRemaining -= Time.deltaTime;

            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                Time.timeScale = 0.0f;
                loseText.enabled = true;
            }

            GameObject timeTextGO = GameObject.Find("Timer (TMP)");
            timeTextGO.GetComponent<TMP_Text>().text = timeRemaining.ToString();
        }
    }
}