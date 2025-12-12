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

    // private void OnTriggerEnter(Collider other)
    // {
    //     var doorController = Door.GetComponent<DoorController>();
    //     doorController.open = true;
    //     //entitiesOnButton++;
    //     //doorController.OpenDoor();
    //     Debug.Log(entitiesOnButton);
    // }

    private void OnTriggerStay(Collider other)
    {
        var doorController = Door.GetComponent<DoorController>();
        doorController.open = true;

        //Debug.Log("Open");

    }

    private void OnTriggerExit(Collider other)
    {
        var doorController = Door.GetComponent<DoorController>();
        doorController.open = false;

        //Debug.Log("Close");
    }
}
