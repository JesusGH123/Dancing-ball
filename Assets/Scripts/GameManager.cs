using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //Our singleton
    public Modes gameStatus = Modes.paused;
    public int score, pickup, highScore, highPickup;

    void GetHighScore()
    {
        if(PlayerPrefs.HasKey("highScore") || PlayerPrefs.HasKey("highPickup"))
        {
            highScore = PlayerPrefs.GetInt("highScore", 0);
            highPickup = PlayerPrefs.GetInt("highPickup", 0);
        }
    }

    private void Awake()
    {
        if (instance == null)   //If it does not exist, create it ONCE!
            instance = this;

        GetHighScore();
    }

    public void IncrementScore()
    {
        score++;
    }
    public void IncrementPickup()
    {
        pickup++;
    }

    public void StartGame()
    {
        gameStatus = Modes.running; //Starts the game

        gameObject.GetComponent<BlockSpawner>().StartSpawning();  //Start spawning blocks
    }

    public void EndGame()
    {
        gameStatus = Modes.over;    //Ends the game

        //Stop spawning blocks 
        gameObject.GetComponent<BlockSpawner>().StopSpawning();
        //Stop trailing
        gameObject.GetComponent<TrailScript>().StopTrailing();

        SaveHighScores();
    }

    void SaveHighScores()
    {
        if(pickup > highPickup)
            PlayerPrefs.SetInt("highPickup", pickup);

        if(score > highScore)
            PlayerPrefs.SetInt("highScore", score);
    }
}
