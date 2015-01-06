﻿using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
    public InZone slot;
	public InZone front;
	public InZone back;
	public InZone right;
	public InZone left;
	Checkpoints controller;

    void Start()
    {
		controller = GetComponentInParent<Checkpoints>();
    }

    void Update()
    {
		if (slot.playerInBounds && !front.playerInBounds && !back.playerInBounds && !right.playerInBounds && !left.playerInBounds)
        {
			controller.clear();
        }
    }
}
