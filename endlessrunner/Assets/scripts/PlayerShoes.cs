using UnityEngine;
using System.Collections;

public class PlayerShoes : MonoBehaviour {

	public string type;

	void Start(){
		this.enabled = false;	
	}

	public void setShoes(string type){
		this.enabled = true;
	}
}
