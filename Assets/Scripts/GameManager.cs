using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager 
{
    //private BallManager ballManager;
    //private UIManager uimanager;
    //private ScoreManager scoremanager;
    //public GameObject gameManager;
    //public WindManager windManager;
    //public GameObject ballPrefab;
    //public int throwsCount;
    //public int score;
    //public bool isGrounded;
    //public bool readyToThrow;
    //public AudioSource backgroundMusic;
    
    //void Start()
    //{
    //    Time.timeScale = 1;
    //    score = 0;
    //    isGrounded = true;
    //    readyToThrow = true;
    //    ballManager = ballPrefab.GetComponent<BallManager>();
    //    uimanager = gameManager.GetComponent<UIManager>();
    //    scoremanager = gameManager.GetComponent<ScoreManager>();
    //    uimanager.scoreText.gameObject.SetActive(true);
    //    uimanager.gameOverText.gameObject.SetActive(false);
    //    uimanager.restartBtn.gameObject.SetActive(false);
    //    uimanager.restartBtn.onClick.RemoveAllListeners();
    //    uimanager.restartBtn.onClick.AddListener(() => uimanager.Restart());
    //    InvokeRepeating("BackgroundMusicPlay", 1f, 7f);
    //}

    // Update is called once per frame
    //void Update()
    //{

    //    throwsCount = ballManager.throws;
        
    //    if (ballManager.totalThrows < 0)
    //    {
    //        GameOver();
    //    }
    //    //windManager.MoveGameObject();
    //    //StartCoroutine(windManager.MoveGameObject());
       

    //}
    /*private void OnMouseDown()
    {
        mzcoord = Camera.main.WorldToScreenPoint(ballPrefab.transform.position).z;
        moffset = ballPrefab.transform.position - GetMouseWorldPos();
    }*/
   /* private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = mzcoord;
        return Camera.main.ScreenToWorldPoint(mousePos);
    }*/
   /* private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + moffset;
    }*/
    
    //void GameOver()
    //{
    //    uimanager.gameOverText.gameObject.SetActive(true);
    //    Time.timeScale = 0;
    //    uimanager.restartBtn.gameObject.SetActive(true);    
    //}
    //void BackgroundMusicPlay()
    //{
    //    backgroundMusic.Play();
    //}
   





}
