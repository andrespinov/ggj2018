using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

    public GameObject currentInterObj = null;
    public bool bandera = false;
    public GameObject door;
    public GameObject audio_archivos;
    public GameObject player;

    void Start()
    {        
        door = GameObject.FindGameObjectWithTag("door");
        audio_archivos = GameObject.FindGameObjectWithTag("audio_archivos");
        player = GameObject.FindGameObjectWithTag("Player");
        bandera = false;
    }
   
    void Update()
    {
        if (Input.GetButtonDown("Recolect") && currentInterObj && !bandera)
        {
            currentInterObj.SendMessage("Disappear");
            player.SendMessage("PickBook");            
            audio_archivos.GetComponent<AudioSource>().Play();
            Debug.Log("Inside Recolect");
            bandera = true;
        }
        if (Input.GetButtonDown("Recolect") && currentInterObj && bandera)
        {
            currentInterObj.SendMessage("OpenDoor");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            currentInterObj = other.gameObject;
        }
        if (bandera && other.CompareTag("door"))
        {
            currentInterObj = other.gameObject;
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
        }
    }
}
