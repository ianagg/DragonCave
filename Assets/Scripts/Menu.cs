using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
		
		private int _window = 0;
		
		void  OnGUI (){ 
		int width = 1360; int height = 768; Screen.SetResolution(width,height ,true);
			
			if (_window == 0) { // теперь главное меню активировано при _window = 0 
				GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 70,180,150), "MENU"); 
				if (GUI.Button ( new Rect(Screen.width/2 - 85,Screen.height/2 - 30,150,30), "Play")) { 
				Application.LoadLevel(1); 
				} 
					
				if (GUI.Button ( new Rect(Screen.width/2 - 85,Screen.height/2 + 10,150,30), "Exit game")) { 
					Application.Quit(); 
				} 
			}

}
}