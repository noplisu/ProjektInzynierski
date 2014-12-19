using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
    InZone[] playerInBounds;
    Rigidbody player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        playerInBounds = GetComponentsInChildren<InZone>();
    }

    void Update()
    {
        if (playerInBounds[0] && !playerInBounds[1] && !playerInBounds[2] && !playerInBounds[3] && !playerInBounds[4] && !playerInBounds[5])
        {
            print(player.velocity.sqrMagnitude < 0.01f);
        }
    }
}
