using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text timerText; // Reference to the UI Text component
    public float countdownTime = 60f; // Set the countdown time in seconds
    private float timer; // Current timer value

    // Start is called before the first frame update
    void Start()
    {
        timer = countdownTime; // Set the timer to the initial countdown time
        UpdateTimerText(); // Update the UI text with the initial timer value
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f); // Wait for 1 second
            timer--; // Decrease the timer by 1 second
            UpdateTimerText(); // Update the UI text with the new timer value
        }

        // Timer has reached 0, you can perform actions here
        Debug.Log("Time's up!");
    }

    void UpdateTimerText()
    {
        // Format the timer value into minutes and seconds (MM:SS)
        string minutes = Mathf.Floor(timer / 60).ToString("00");
        string seconds = (timer % 60).ToString("00");

        // Update the UI text
        timerText.text = minutes + ":" + seconds;
    }
}