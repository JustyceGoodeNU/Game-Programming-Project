using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject Door;
    private static int entitiesOnButton = 0;

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
        entitiesOnButton++;
        //doorController.OpenDoor();
        Debug.Log(entitiesOnButton);

    }

    private void OnTriggerExit(Collider other)
    {
        var doorController = Door.GetComponent<DoorController>();
        //doorController.OpenDoor();
        entitiesOnButton--;
        if (entitiesOnButton < 1)
        {
            doorController.open = false;
        }
        Debug.Log(entitiesOnButton);
        //Debug.Log("Close");
    }
}
