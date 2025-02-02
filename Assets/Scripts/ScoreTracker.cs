using Unity.VisualScripting;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //checks both scores and prints them. starts the ball spawn bc having it in ScoreDistribute will x2?
    //remember -  this is gonna get weird left goal = right score, right goal = left goal? MAYBE
    public GameObject goalLeft;
    public GameObject goalRight;

    public SpawnRules spawnRules;
    public int GameOverScore = 11;

    private ScoreDistribute scoreLeft;
    private ScoreDistribute scoreRight;



    public bool firstTime = true;
    void Start()
    {
        scoreLeft = goalLeft.GetComponent<ScoreDistribute>();
        scoreRight = goalRight.GetComponent<ScoreDistribute>();

        if (firstTime)
        {
            //ball spawns?
            Debug.Log("First time spawing ball");
            spawnRules.spawnBall("right");

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void printResults(string side)
    {

        Debug.Log("Game Over!");
        if (side.Equals("right"))
        {
            Debug.Log("Left Wins!");
        }
        else
        {
            Debug.Log("Right Wins!");
        }
        Debug.Log($"SCORE[ Left:{scoreLeft.score} | Right:{scoreRight.score}]");
        


    }
}
