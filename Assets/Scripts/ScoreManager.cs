using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager
{
    private int score = 0;
    //private UIManager uimanager;
    //public GameObject gameManager;


    //private void Start()
    //{
    //    uimanager = gameManager.GetComponent<UIManager>();
    //}
    //private void Update()
    //{
        
    //}
    
    public void Score(TextMeshProUGUI text)
    {
        Debug.Log("score");
        score += 2;
        text.text = "Score : " + score.ToString();
        //UI text is active to true
        
    }


}
