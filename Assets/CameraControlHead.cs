using UnityEngine;
using System.Collections;

public class CameraControlHead : MonoBehaviour
{
    public float hSpeed = 2.0F;
    public void Update()
    {
        float h = hSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(0, 0, h);
    }
}