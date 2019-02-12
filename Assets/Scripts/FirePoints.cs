using UnityEngine;
using System.Collections;

public class FirePoints : MonoBehaviour {

	public PlayerStats Char;

    void Start()
    {

        Char = (PlayerStats) GameObject.Find("hero").GetComponent("PlayerStats");
    }

	public void Points()
	{
		PlayerStats PlayerSt = (PlayerStats)Char.GetComponent("PlayerStats");
		if (PlayerSt.CurFire < PlayerSt.MaxFire) {
						PlayerSt.CurFire = PlayerSt.CurFire + 1;
                        Debug.Log("I'M HERE");
				}
		Destroy (gameObject);
	}

}
