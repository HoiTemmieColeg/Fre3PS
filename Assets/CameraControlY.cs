using UnityEngine;
using System.Collections;

public class CameraControlY : MonoBehaviour
{
    public float vSpeed = 2.0F;
    public void Update()
    {
        float v = vSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, 0, 0);
    }
}