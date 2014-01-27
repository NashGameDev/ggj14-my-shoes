using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

	float playerScore = 60f;

	// Update is called once per frame
	void Update () {
		playerScore -= Time.deltaTime;
		if(playerScore <= 0){
			playerScore = 0;
			Application.LoadLevel(0);
		}
	}

	public void IncreaseScore(int amount){
		playerScore += amount;
	}

	void OnGUI(){
		GUI.Label(new Rect(10, 10, 100, 30), "Score: " + (int)(playerScore * 100));
	}

	void OnDisable(){
		PlayerPrefs.SetInt ("score", (int)(playerScore * 100));
	}
}
