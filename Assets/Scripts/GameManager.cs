using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float timer = 0f;
    bool running = true;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (running)
            timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = Time.timeScale == 0 ? 1 : 0;
        }
    }

    public void Win()
    {
        running = false;
        Time.timeScale = 0f;
        Debug.Log("YOU WIN - TIME: " + timer.ToString("F2"));
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}