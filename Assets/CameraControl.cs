using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    public float hSpeed = 2.0F;
    public void Update()
    {
        float h = hSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);
    }
}