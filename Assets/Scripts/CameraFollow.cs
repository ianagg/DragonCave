using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;

	private bool choose = false;
	private bool start = false;
    private float currentspeed = 0.001f;

	// Use this for initialization
	void Start () {
	

	}


	// Update is called once per frame
	void Update () {
		if (choose) {
			start = true;
		}
		if (choose && start) {
            transform.Translate(3f * Time.deltaTime * currentspeed, 0f, 0f);

		}
        currentspeed += 0.002f;
	}



	public void OnClick() {
		choose = true;
	}
}
