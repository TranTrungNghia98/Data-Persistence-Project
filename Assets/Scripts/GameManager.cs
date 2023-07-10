using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_InputField playerNameText;
    private int highScore = 0;
    private string playerHighScoreName = "";

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Update diffirent name when player back from Main Scene
        
        if (SceneManager.GetActiveScene().name == "menu")
        {
            playerNameText = GameObject.Find("Player Input Name").GetComponent<TMP_InputField>();
        }
       
    }

    // Set Name of player High Score
    public void SetPlayerName(string name)
    {
        playerHighScoreName = name;
    }

    // Get Player High Score Name
    public string GetPlayerHighScoreName()
    {
        return playerHighScoreName;
    }

    // Get New Player Name
    public string GetPlayerName()
    {
        return playerNameText.text;
    }

    public void SetHighScore(int score)
    {
        highScore = score;
    }

    public int GetHighScore()
    {
        return highScore;
    }
}
