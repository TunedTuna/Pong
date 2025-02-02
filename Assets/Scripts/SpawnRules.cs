using UnityEngine;

public class SpawnRules : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ballPrefab;
    public bool firstTime = true;
    public void Start()
    {
        if (firstTime)
        {
            //ball spawns?
            Vector3 spot = new Vector3(0f, 0.5f, 0f);
            GameObject newOb = Instantiate(ballPrefab, spot, Quaternion.identity);
            firstTime = false;
        }



    }

    public void spawnBall(string x)
    {
        //spawn another?
        Vector3 spot = new Vector3(0f, 0.5f, 0f);
        GameObject newOb = Instantiate(ballPrefab, spot, Quaternion.identity);
        Rigidbody rb = GetComponent<Rigidbody>();
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
