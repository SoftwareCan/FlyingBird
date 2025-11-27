using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource addSound, gameOverSound;

    private bool isGameOver = false;

    private void Awake()
    {
        addSound = gameObject.AddComponent<AudioSource>();
        gameOverSound = gameObject.AddComponent<AudioSource>();

        addSound.clip = Resources.Load<AudioClip>("Audio/puan");
        gameOverSound.clip = Resources.Load<AudioClip>("Audio/gameOver");
    }

    private void Start()
    {
        
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        addSound.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {

        if (isGameOver) return;

        isGameOver = true;
        gameOverScreen.SetActive(true);
        gameOverSound.Play();
    }
   
}
 