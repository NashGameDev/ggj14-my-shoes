using UnityEngine;
using System.Collections;

public class ShoeScript : MonoBehaviour {
	public string type;
	public string key = "";

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(key != null && key != ""){
			if(Input.GetKeyDown(key)){
				modify();
			}
		}
	}
	
	void OnMouseUp(){
		modify ();
	}

	void modify(){
		player.GetComponent<PlatformerCharacter2D>().setShoes(type);
	}

}
