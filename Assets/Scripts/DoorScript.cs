using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    // Update is called once per frame
    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }
}
