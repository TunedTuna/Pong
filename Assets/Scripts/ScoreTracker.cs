using UnityEngine;

public class ScoreTracker : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;

    public string side;
    public string otherSide;
    public SpawnRules SpawnRules;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //when ball enters: destroy ball, add score to , console side n point, 
        //right goal = left score, left goal = right score.

    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        score += 1;
        Debug.Log(otherSide+" "+ score);
        if (score == 11)
        {
            //xxx
        }
        //make an outside funcion to print so goals dont have to refer to each other, same function will reset scores to both side xxx

        //call function to spawn ball on other side?
        SpawnRules.spawnBall(side);
       
    }

    
}
