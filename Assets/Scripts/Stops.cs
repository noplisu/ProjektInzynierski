using UnityEngine;
using System.Collections;

public class Stops : Requirement {
    Rigidbody player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    public override bool passed()
    {
        if (player.velocity.magnitude < 0.1)
            return true;
        else
            return false;
    }
}
