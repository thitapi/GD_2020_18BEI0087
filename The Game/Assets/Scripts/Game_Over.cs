
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    bool End = false;
    public float delay = 1f;

    public void EndGame()
    {
        if(!End)
        {
            End = true;
            Debug.Log("Game Over");
            restart();
            Invoke("restart", delay);
        }
        
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
