using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Points : MonoBehaviour
{
    public int playerScore;
    public Text score;

    public GameObject RestartButton;
    public PlayerScript player;
    public GameObject EndScreen;


    public void GameOver()
    {
        EndScreen.SetActive(true);
    }
    public void IncrementScore()
    {
        playerScore++;
        score.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
