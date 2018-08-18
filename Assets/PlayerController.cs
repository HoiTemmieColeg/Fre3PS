using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float ForwardSpeed;
    public float ThreeWaySpeed;
    public float JumpSpeed;
    float moveHorizontal;
    bool isGrounded;
    float moveVertical;
    float moveY;
    float time;
    void FixedUpdate()
    {

        if (Input.GetKey("d"))
            {
                //moveHorizontal = ThreeWaySpeed;
            transform.position += transform.right * ThreeWaySpeed;
            }
        if (Input.GetKey("a"))
            {
                //moveHorizontal = -ThreeWaySpeed;
                transform.position -= transform.right * ThreeWaySpeed;
            }
        //else
          //  {
                //moveHorizontal = 0;
           // }

        if (Input.GetKey("w")){
            //moveVertical = ForwardSpeed;
            transform.position += transform.forward * ForwardSpeed;
        }
        else if (Input.GetKey("s"))
        {
            //moveVertical = -ThreeWaySpeed;
            transform.position -= transform.forward * ThreeWaySpeed;
        }
        //else
        //{
        //    moveVertical = 0;
        //}

        if (Input.GetKey(KeyCode.Space) && isGrounded == true) {
            //Debug.Log("Jump");
            transform.position += Vector3.up * Time.deltaTime * 10f;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
        Debug.Log("Collision Detected");
    }
    void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}