using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    [Header("Object Initialization")]
    [SerializeField] public GameObject ballPrefab;
    private Rigidbody ballRb;
    [SerializeField] private GameObject bin;

    [Header("Throwing")]
    [SerializeField] private float forwardForce;
    private float jumpSpeed;
    [SerializeField] private Vector3 originalPos;

    [Header("Extra")]
    public bool isGrounded ;
    public bool readyToThrow;
    public int totalThrows;
    ScoreManager scoreManager = new ScoreManager();
    UIManager uimanager = new UIManager();
    public GameObject gameManager;
    private float Delay;
    private Vector3 jump;
    public AudioSource audioOfCollision;
    public AudioClip scoreClip;
    public AudioClip collisionClip;
    [SerializeField] TextMeshProUGUI scoreText;
    
    public AudioSource backgroundMusic;



    [HideInInspector]
    public int throws;
    public bool ballMoving;

    [Header("Score")]
    private int score = 0;
    [SerializeField] TextMeshProUGUI gameOverText;
    [SerializeField] Button restartBtn;

    //InteractionManager interactionManager = new InteractionManager();
    private bool touchDown;
    public AudioClip swipeSound;
    [SerializeField] int pixelToSwipe;
    private Vector2 startPos;//15




    private void Start()
    {
        //if (scoreManager == null)
        //{
        //    ScoreManager scoreManager = new ScoreManager();
        //}
        //if (uimanager == null)
        //{
        //    UIManager uimanager = new UIManager();
        //}
        //if (interactionManager == null)
        //{
        //    InteractionManager interactionManager = new InteractionManager();
        //}
        Time.timeScale = 1;
        score = 0;
        originalPos = ballPrefab.transform.position;
        ballRb = ballPrefab.GetComponent<Rigidbody>();
        InvokeRepeating("BackgroundMusicPlay", 1f, 7f);
        scoreText.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(false);
    }
    private void Update()
    {
        //  interactionManager.InteractionActivity(touchDown, startPos, pixelToSwipe, audioOfCollision, swipeSound, this);
        if (touchDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            touchDown = true;
        }
        if (touchDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelToSwipe)
            {
                Debug.Log("Swipe up");
                audioOfCollision.clip = swipeSound;
                audioOfCollision.Play();
                Throw();
                touchDown = false;
            }
        }
        if (touchDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            touchDown = false;
        }
        
        if (totalThrows < 0)
        {
            uimanager.GameOver(gameOverText, restartBtn);
        }
        restartBtn.onClick.RemoveAllListeners();
        restartBtn.onClick.AddListener(() => uimanager.Restart(gameOverText, scoreText));
       
    }
    public void ResetPosition()
    {
        ballPrefab.transform.position = originalPos;
       
    }
    public void Throw()
    {
       
         Vector3 jump = new Vector3(Random.Range(-0.2f,0.2f), 1.3f, 1.1f);
        //Vector3 relativePos = target.position - transform.position;
        //Quaternion Rotation = Quaternion.LookRotation(jump, relativePos);
        //ballRb.transform.rotation = Rotation;
        jumpSpeed = 10f;
        ballRb.AddForce(jump * jumpSpeed, ForceMode.Acceleration);
        ballMoving = true;
        
        if(ballMoving == true)
        {
            throws++;
        }
        totalThrows--;
        Delay = 4.9f;
        Invoke("ResetPosition",Delay);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bin")
        {
            audioOfCollision.clip = scoreClip;
            audioOfCollision.Play();
            Debug.Log("score");
            scoreManager.Score(scoreText);
            //uimanager.ScoreCard(scoreText, score);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "bin")
        {
            Debug.Log("collide");
            audioOfCollision.clip = collisionClip;
            audioOfCollision.PlayDelayed(0.8f);
        }
    }
    void BackgroundMusicPlay()
    {
        backgroundMusic.Play();
    }


}
