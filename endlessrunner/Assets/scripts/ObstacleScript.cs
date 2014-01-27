using UnityEngine;
using System.Collections;

public class ObstacleScript : MonoBehaviour {

	public GameObject obstacle;
	public GameObject no_obstacle;
	private PlatformerCharacter2D player;
	public string shoetype;
	public bool floor;

	// Use this for initialization
	void Start () {
		no_obstacle.SetActive(false);
		player = GameObject.FindWithTag("Player").GetComponent<PlatformerCharacter2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.getShoeType().Equals (shoetype)){
			obstacle.SetActive(false);
			no_obstacle.SetActive(true);
		}
		else{
			obstacle.SetActive(true);
			no_obstacle.SetActive(false);
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		if(no_obstacle.activeSelf && !floor){
			Destroy(gameObject);
		}
	}
}
