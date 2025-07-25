using UnityEngine;

public class CameraToggle : MonoBehaviour
{
    public Camera fpsCam;
    public Camera shoulderCam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            fpsCam.enabled = !fpsCam.enabled;
            shoulderCam.enabled = !shoulderCam.enabled;
        }
    }
}
