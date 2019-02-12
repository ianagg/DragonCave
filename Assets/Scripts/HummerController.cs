using UnityEngine;
using System.Collections;

public class HummerController : MonoBehaviour {
	int i=0;
	bool b = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		while (i<60&&b) {
			Debug.Log("HERE"+i);
			transform.rotation.Set(0, i, 0, 0); 
						i++;
				}
		if (i == 60) 
						b = false;
		while(i>60&&!b) {
			transform.rotation.Set(0, i, 0, 0); 			
			i--;
		}

		if (i == 0)
						b = true;
	
	}
}
