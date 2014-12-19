using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lost : MonoBehaviour {
	public string comment;
	public GameObject lost;
	public Text text;
	CarUserControl player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<CarUserControl>();
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
			text.text = comment;
			print (player);
			player.enabled = false;
			lost.SetActive (true);
		}
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Player") {
			text.text = comment;
			print (player);
			player.enabled = false;
			lost.SetActive (true);
		}
	}
}
