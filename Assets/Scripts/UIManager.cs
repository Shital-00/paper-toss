using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager 
{
   // [Header("UI Initialization")]
    //[SerializeField] public  TextMeshProUGUI scoreText;
    //[SerializeField] public TextMeshProUGUI gameOverText;
   // [SerializeField] public Button restartBtn;
   // private int score;

    
    //public void ScoreCard(TextMeshProUGUI text, int score)
    //{
    //    text.text = "0" + score.ToString();
    //}
    public void Restart(TextMeshProUGUI text1, TextMeshProUGUI text2)
    {

        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        text1.gameObject.SetActive(false);
        text2.text = "0";


    }
    public void GameOver(TextMeshProUGUI text, Button btn)
    {
        text.gameObject.SetActive(true);
        Time.timeScale = 0;
        btn.gameObject.SetActive(true);
    }


}
