using UnityEngine;

public class SpawnRules : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ballPrefab;
    public void Start()
    {
        //ball spawns?
        Vector3 spot= new Vector3(0f,0.5f,0f);
        GameObject newOb = Instantiate(ballPrefab,spot, Quaternion.identity );
    }

    public void spawnBall(string x)
    {
        //spawn another?
        Vector3 spot = new Vector3(0f, 0.5f, 0f);
        GameObject newOb = Instantiate(ballPrefab, spot, Quaternion.identity);
        if (x.Equals("right"))
        {

            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(-5f, 0f, 0f); // Adjust the X value for desired speed

        }
        else
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.linearVelocity = new Vector3(5f, 0f, 0f); // Adjust the X value for desired speed
        }
    }
}
