using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {
	int score = 0;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("score");
	}

	void OnGUI(){
		string text = "GAME OVER";

		if(score > 0){
			text = "YOU WIN!!!!";
		}
		GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), text);

		GUI.Label (new Rect(Screen.width / 2 - 40, 300, 80, 30), "Score: " + score);

		if(GUI.Button(new Rect(Screen.width / 2 - 30, 350, 60, 30), "Retry?")){
			Application.LoadLevel(1);
		}
	}
	
}
