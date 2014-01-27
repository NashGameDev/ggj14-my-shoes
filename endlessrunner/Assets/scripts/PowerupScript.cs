using UnityEngine;
using System.Collections;

public class PowerupScript : MonoBehaviour {

	HudScript hud;

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			hud = GameObject.Find("Main Camera").GetComponent<HudScript>();
			hud.IncreaseScore(5);
			Destroy(this.gameObject);
		}
	}

}
