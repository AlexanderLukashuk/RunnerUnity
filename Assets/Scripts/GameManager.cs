using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int result = 0;
    public Text scoreText;
    
    public void AddCoin(int coinToAdd)
    {
        result += coinToAdd;
        scoreText.text = result.ToString();
    }

    public void AddDiamond(int diamond)
    {
        result += diamond;
        scoreText.text = result.ToString();
    }

    void Start()
    {
        
    }
    void Update()
    {
        if (result == 20)
            Application.LoadLevel(Application.loadedLevel);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
