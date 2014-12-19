using UnityEngine;
using System.Collections;

public class InZone : MonoBehaviour {

    public bool playerInBounds = false;

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInBounds = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerInBounds = false;
        }
    }
}
