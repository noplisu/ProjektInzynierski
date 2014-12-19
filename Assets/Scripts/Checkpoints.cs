using UnityEngine;
using System.Collections;

public class Checkpoints : MonoBehaviour {
	int currentCheckpoint = 0;
	Checkpoint[] checkpoints;

	void Start()
	{
		checkpoints = GetComponentsInChildren<Checkpoint>();
		for (int i = 0; i<checkpoints.Length; i++){
			checkpoints[i].gameObject.SetActive(false);
		}
		checkpoints[currentCheckpoint].gameObject.SetActive(true);
	}

	public bool clear()
	{
		checkpoints[currentCheckpoint].gameObject.SetActive (false);
		if (currentCheckpoint + 1 >= checkpoints.Length) {
			return true;
		}
		else {
			currentCheckpoint++;
			checkpoints [currentCheckpoint].gameObject.SetActive (true);
			return false;
		}
	}
}
