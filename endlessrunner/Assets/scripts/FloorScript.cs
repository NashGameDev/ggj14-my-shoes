using UnityEngine;
using System.Collections;

public class FloorScript : MonoBehaviour {

	PlatformerCharacter2D player;
	public string shoetype;
	private PhysicsMaterial2D origMaterial;
	public PhysicsMaterial2D offMaterial;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player").GetComponentInChildren<PlatformerCharacter2D>();
		origMaterial = collider2D.sharedMaterial;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col) {
		if(player.getShoeType().Equals(shoetype)){
			collider2D.enabled = false;
			collider2D.sharedMaterial = null;
			collider2D.enabled = true;
		}
		else{
			collider2D.enabled = false;
			collider2D.sharedMaterial = origMaterial;
			collider2D.enabled = true;
		}
	}
}
