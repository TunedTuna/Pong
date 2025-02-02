using UnityEngine;

public class BallRules : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speedIncrease = 1.5f;

    void Start()
    {
        //Rigidbody rb = GetComponent<Rigidbody>();
        //rb.linearVelocity = new Vector3(-5f, 0f, 0f); // Adjust the X value for desired speed


    }



    // Update is called once per frame
    void Update()
    {
       //Vector3 up = new Vector3(-1f, 0f,0f);
       //Quaternion posRotation = Quaternion.Euler(0f, 0f, 45f);
       // Quaternion negRotation = Quaternion.Euler(0f, 0f, -45f);

       // Vector3 posVector = posRotation * up;
       // Vector3 negVector = negRotation * up;

       // Debug.DrawRay(transform.position, posVector*2f, Color.red);
       // Debug.DrawRay(transform.position, negVector * 2f, Color.green);
    }
    private void OnCollisionEnter(Collision other)
    {
        //increase speed, change direction
        //
        Rigidbody rb = GetComponent<Rigidbody>();
        float speed = other.relativeVelocity.magnitude;
        float newSpeed = speed * speedIncrease;

        Vector3 newVelocity = other.relativeVelocity;
        newVelocity = newVelocity.normalized * newSpeed;
        rb.linearVelocity = newVelocity;
        //Debug.Log($"made contact with {other.gameObject.name}");


    }
}
