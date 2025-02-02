using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;

    //for new inputsystem?
    public KeyCode moveUp;
    public KeyCode moveDown;
    //old input system?
    public string input;


    public float movement =1f;
    public float paddleForce = 1f;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //roll a ball eg
    //private void OnMove(InputValue movementValue)
    //{
    //    Vector2 movementVector = movementValue.Get<Vector2>();

    //    movementX = movementVector.x;
    //    movementY = movementVector.y;
    //}


    void Update()
    {
        //roll a ball eg
       
        //rb.AddForce(movement * speed);

        float movementAxis = Input.GetAxis($"{input}");
        Vector3 force = new Vector3(0f, 0.0f, 1f * movementAxis * paddleForce);

        rb.AddForce(force,ForceMode.Force);

    }
}
