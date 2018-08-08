using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float speed;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public float TimerSpeed;
    public float ForwardSpeed;
    public float ThreeWaySpeed;
    public float JumpSpeed;
    float moveHorizontal;
    float moveVertical;
    float moveY;
    float time;
    void FixedUpdate()
    {
        time += -TimerSpeed;

        Debug.Log(time);
        if (Input.GetKey("d"))
        {
            moveHorizontal = ThreeWaySpeed;
        }
        else if (Input.GetKey("a"))
            {
                moveHorizontal = -ThreeWaySpeed;
            }
        else
            {
                moveHorizontal = 0;
            }

        if (Input.GetKey("w")){
            moveVertical = ForwardSpeed;
        }
        else if (Input.GetKey("s"))
        {
            moveVertical = -ThreeWaySpeed;
        }
        else
        {
            moveVertical = 0;
        }

        if (Input.GetKey(KeyCode.Space) && time <= 0) {
            //Debug.Log("Pressing Space");  //This line tells the console you're  pressing space. Uncomment for Debug Purposes.
            if (time <= -4)
            {
                time = 2;
            }
            if (time >= 0)
            {
                moveY = JumpSpeed;
            }
            if (time <= -1)
            {
                moveY = JumpSpeed * -2;
            }
        }



        Vector3 movement = new Vector3(moveHorizontal, moveY, moveVertical);

        rb.AddForce(movement * speed);
    }
}