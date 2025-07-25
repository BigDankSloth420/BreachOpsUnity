using UnityEngine;

public class DoorBreach : MonoBehaviour
{
    private bool isOpen = false;
    public GameObject doorObject;

    void OnTriggerEnter(Collider other)
    {
        if (!isOpen && other.CompareTag("Player"))
        {
            doorObject.transform.Rotate(0, 90, 0);
            isOpen = true;
        }
    }
}
