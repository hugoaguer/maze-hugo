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
    }

    public void Win()
    {
        running = false;
        Debug.Log("YOU WIN - TIME: " + timer.ToString("F2"));
        Invoke("Restart", 2f);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}