using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionScript : MonoBehaviour {

    public GameObject currentInterObj = null;
    public bool bandera = false;
 //  public GameObject door = GameObject.FindGameObjectWithTag("door");

    void Update()
    {
        if (Input.GetButtonDown("Recolect") && currentInterObj)
        {
            currentInterObj.SendMessage("Disappear");
            bandera = true;
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
            other.SendMessage("Disappear");
            Debug.Log("Pasar lvl");
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
