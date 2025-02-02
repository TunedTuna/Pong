using UnityEngine;

public class SpawnRules : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject ballPrefab;
    
    public void Start()
    {




    }

    public void spawnBall(string x)
    {
        //spawn another?
        Vector3 spot = new Vector3(0f, 0.5f, 0f);
        GameObject newOb = Instantiate(ballPrefab, spot, Quaternion.identity);
        Rigidbody rb = newOb.GetComponent<Rigidbody>();
        if (x.Equals("right"))
        {
            Debug.Log("GOING LEFT?");

            rb.linearVelocity = new Vector3(-5f, 0f, 0f); // Adjust the X value for desired speed

        }
        else
        {
            Debug.Log("GOING RIGHT?");
            rb.linearVelocity = new Vector3(5f, 0f, 0f); // Adjust the X value for desired speed
        }
    }
}
