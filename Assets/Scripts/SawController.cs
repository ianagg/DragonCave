using UnityEngine;
using System.Collections;

public class SawController : MonoBehaviour
{
		public float direction = 1f; 
	
		// Update is called once per frame
		void Update ()
		{

					//transform.position += new Vector3 (0f, direction * 0.02f, 0f);
						transform.Rotate (Vector3.forward * 3);
				
		}

		void OnCollisionEnter2D (Collision2D col)
		{
				if (col.gameObject.name.Contains("Rock")) {
		
						direction = -direction;
		
				}



		}


}
