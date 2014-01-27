using UnityEngine;

[RequireComponent(typeof(BossCharacter2D))]
public class BossControlScript : MonoBehaviour 
{
	private BossCharacter2D character;
	private bool jump;
	public float speed;
	
	
	void Awake()
	{
		character = GetComponent<BossCharacter2D>();
	}
	
	void Update ()
	{
		// Read the jump input in Update so button presses aren't missed.
//		if (CrossPlatformInput.GetButtonDown("Jump"))
//			jump = true;
	}
	
	void FixedUpdate()
	{
		// Read the inputs.
		//		bool crouch = Input.GetKey(KeyCode.LeftControl);
		//		float h = CrossPlatformInput.GetAxis("Horizontal");
//		bool crouch = Input.GetKey(KeyCode.LeftControl);
//		float h = CrossPlatformInput.GetAxis("Horizontal");
		
		// Pass all parameters to the character control script.
		character.Move( speed, false , false );
		
		// Reset the jump input once it has been used.
		jump = false;
	}
}
