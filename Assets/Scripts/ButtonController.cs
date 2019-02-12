using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {

    public void OnClickStart()
    {
        Application.LoadLevel(1); 

    }

    public void OnClickExit() {
        Application.Quit();
    }
    public void OnClickOptions()
    {
    }
    public void OnClickHelp()
    {
    }
}
