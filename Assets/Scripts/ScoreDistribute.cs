using UnityEngine;

public class ScoreDistribute : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score;

    public string side;
    public string otherSide;
    public SpawnRules SpawnRules;
    public GameObject ballPrefab;

    public ScoreTracker st;


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
        if (score != st.GameOverScore)
        {
           
            Debug.Log(otherSide + " " + score);
            //make an outside funcion to print so goals dont have to refer to each other, same function will reset scores to both side xxx

            //call function to spawn ball on other side?
            spawnBall(side);
        }
        else
        {
            // scoreTracker.results GO, l#| r#
            st.printResults(side);
        }

       
    }

    public void spawnBall(string x)
    {
        //spawn another?
        Vector3 spot = new Vector3(0f, 0.5f, 0f);
        GameObject newOb = Instantiate(ballPrefab, spot, Quaternion.identity);
        //get compnent from new obj, not this obj(the goal)
        Rigidbody rb = newOb.GetComponent<Rigidbody>();

        if (x.Equals("right"))
        {


            rb.linearVelocity = new Vector3(-5f, 0f, 0f); // Adjust the X value for desired speed

        }
        else
        {

            rb.linearVelocity = new Vector3(5f, 0f, 0f); // Adjust the X value for desired speed
        }
    }


}
