using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour
{
    public GUITexture gt;
    void Start()
    {
        gt = GetComponent<GUITexture>();
    }
    void DidLockCursor()
    {
        Debug.Log("Locking cursor");
        gt.enabled = false;
    }
    void DidUnlockCursor()
    {
        Debug.Log("Unlocking cursor");
        gt.enabled = true;
    }
    void OnMouseDown()
    {
        Screen.lockCursor = true;
    }
    private bool wasLocked = false;
    void Update()
    {
        if (Input.GetKeyDown("escape"))
            Screen.lockCursor = false;

        if (!Screen.lockCursor && wasLocked)
        {
            wasLocked = false;
            DidUnlockCursor();
        }
        else
            if (Screen.lockCursor && !wasLocked)
        {
            wasLocked = true;
            DidLockCursor();
        }
    }
}