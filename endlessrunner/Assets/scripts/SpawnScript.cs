using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public float hillyStart = 1.0f;//-1.610176f;
	public float waterStart = 2.0f;
	public float xStart = 11.27003f;

	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	void Spawn(){
		Vector3 pos = transform.position;

		GameObject randomObject = obj[Random.Range(0, obj.GetLength(0))];
		if(randomObject == null){
			Invoke("Spawn", Random.Range (spawnMin, spawnMax));
			return;
		}
		if(randomObject.tag == "Hill"){
			pos.y = hillyStart;
		}

		GameObject newobj = (GameObject) Instantiate(randomObject, pos, Quaternion.identity);


		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
