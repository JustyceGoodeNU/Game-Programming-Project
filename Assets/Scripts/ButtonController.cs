using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Door;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        var doorController = Door.GetComponent<DoorController>();
        doorController.open = true;
        //doorController.OpenDoor();
        //Debug.Log("Open");

    }

    private void OnTriggerExit(Collider other)
    {
        var doorController = Door.GetComponent<DoorController>();
        //doorController.OpenDoor();
        doorController.open = false;
        //Debug.Log("Close");
    }
}
