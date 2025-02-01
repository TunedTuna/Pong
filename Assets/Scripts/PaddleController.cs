using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Rigidbody rb;

    //public Input moveUp;
    public KeyCode moveUp;
    public KeyCode moveDown;


    //roll a ball
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
        //Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        //rb.AddForce(movement * speed);

        float movementAxis = Input.GetAxis("LeftPaddle");

        Transform paddleTransformer = GetComponent<Transform>();
        paddleTransformer.position += new Vector3(0f, 0f,movementAxis * movement * Time.deltaTime);

        //if (Input.GetKey(moveUp)) 
        //{ 
        //    Transform paddleTransformer = GetComponent<Transform>();
        //    paddleTransformer.position += new Vector3(0f, 0f, -movement *Time.deltaTime);
        //}
        //if (Input.GetKey(moveDown))
        //{
        //    Transform paddleTransformer = GetComponent<Transform>();
        //    paddleTransformer.position += new Vector3(0f, 0f, movement * Time.deltaTime);
        //}
    }
}
