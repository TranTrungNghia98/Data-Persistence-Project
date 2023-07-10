using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandle : MonoBehaviour
{
    public TextMeshProUGUI highScoreText;
    private string playerName;
    private int highScore;
    // Start is called before the first frame update
    void Start()
    {
        DisplayHighScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    void DisplayHighScore()
    {
        playerName = GameManager.Instance.GetPlayerHighScoreName();
        highScore = GameManager.Instance.GetHighScore();

        highScoreText.text = "High Score: " + playerName + " : " + highScore;
    }
}
