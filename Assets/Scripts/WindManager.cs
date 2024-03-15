//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Threading.Tasks;

//public class WindManager : MonoBehaviour
//{
   
//    [SerializeField] private GameObject ballPrefab;
//    [SerializeField] private GameObject gamemanager;
//    //[SerializeField] private Transform[] positions;
//    [SerializeField] private float objectSpeed;
//    //[SerializeField] private float spawnDelay;
//    // private Transform nextPos;
//    //private int nextPosIndex;
//   // public Vector3 transPos;
//    private BallManager ballManager;
//    private GameManager gameManager;
//    public Vector3 originPos;
//    public Vector3 secPos;

//    public float seconds = 28;
//    public float timer;
//    public Vector3 Point;
//    public Vector3 Difference;
//    public Vector3 start;
//    public float percent;

//    private void Start()
//    {
//        ballManager = ballPrefab.GetComponent<BallManager>();
//        gameManager = gamemanager.GetComponent<GameManager>();
//        // nextPos = positions[0];

        
        
//        start = transform.position;
//        Point = new Vector3(2.15f, 0.56f, 5.5f);
//        Difference = Point - start;
//    }
//    void Update()
//    {

//        if (timer <= seconds)
//        {
//            // basic timer
//            timer += Time.deltaTime;
//            // percent is a 0-1 float showing the percentage of time that has passed on our timer!
//            percent = timer / seconds;
//            // multiply the percentage to the difference of our two positions
//            // and add to the start
//            transform.position = start + Difference * percent;
//        }
//    }
//    //public void CheckPosition()
//    //{
//    //    if (transform.position == positions[0].position)
//    //    {
//    //        //if fan is left then ball move to right

//    //        ballManager.jump = new Vector3(Random.Range(0f,0.3f), 1.3f, 1f);
//    //        ballManager.jumpSpeed = 10f;
//    //        ballManager.Throw();

//    //    }
//    //    else if (transform.position == positions[1].position)
//    //    {
//    //        ballManager.jump = new Vector3(Random.Range(-0.3f,0f), 1.3f, 1f);
//    //        ballManager.jumpSpeed = 10f;
//    //        ballManager.Throw();

//    //    }
//    //}
//    //public  void MoveGameObject()
//    //{
//    //    Debug.Log("game");
//    //    if (transform.position == nextPos.position)
//    //    {
//    //        nextPosIndex++;
//    //        if (nextPosIndex >= positions.Length)
//    //        {
//    //            nextPosIndex = 0;
//    //        }

//    //        nextPos = positions[nextPosIndex];
//    //    }
//    //    else
//    //    {
//    //        Debug.Log("check");

//    //        transform.position = Vector3.MoveTowards(transform.position, nextPos.position, objectSpeed * Time.deltaTime);
//    //    }


//    //}
//    //public IEnumerator MovePosition()
//    //{
//    //    yield return new WaitForSeconds(6);
//    //    transform.position = secPos;
//    //    yield return new WaitForSeconds(6);
//    //    transform.position = originPos;

//    //}

//}

