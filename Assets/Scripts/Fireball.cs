using UnityEngine;
using System.Collections;

public class Fireball : MonoBehaviour
{

		void OnTriggerEnter2D (Collider2D other)
		{
		other.SendMessage ("KillItWithFire", SendMessageOptions.DontRequireReceiver);

	//	Destroy (GameObject.FindWithTag("Distructible"));


		}


}
