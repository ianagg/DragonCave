using UnityEngine;
using System.Collections;

public class Points : MonoBehaviour {

    public Pause P;

    void Start()
    {
        P = (Pause) GameObject.Find("Menu").GetComponent("Pause");
    }

    public void ScorePoints()
    {
        Pause bonus = (Pause)P.GetComponent("Pause");
        bonus.points += int.Parse(this.gameObject.name.Remove(3));
        Destroy(this.gameObject);
    }
}
