using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainUIHandle : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Awake()
    {
        highScore.text = "Best Score: " + GameManager.Instance.GetPlayerName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("menu");
    }
}
