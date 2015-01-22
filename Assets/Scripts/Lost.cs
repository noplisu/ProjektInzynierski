using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lost : MonoBehaviour {
	public string comment;
	public GameObject lost;
	public Text text;
	CarController player;

	void Start(){
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<CarController>();
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "Player") {
            execute();
		}
	}

	void OnTriggerEnter(Collider collision){
		if (collision.gameObject.tag == "Player") {
            execute();
		}
	}

    void execute()
    {
        lost.SetActive(true);
        text.text = comment;
        //player.enabled = false;
        player.Immobilize();
    }
}
