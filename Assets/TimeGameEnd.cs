using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float gameTimeInSeconds = 60f; // Set the initial game time in seconds
    private float timer; // Current timer value
    
    // Start is called before the first frame update
    void Start()
    {
        timer = gameTimeInSeconds; // set the timer to the initial game time
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        while (timer > 0f)
        {
            yield return new WaitForSeconds(1f); // wait for 1 second
            timer--; // Decreases the timer by 1 second
        }

        // scene loader
        SceneManager.LoadScene(0);
    }
}