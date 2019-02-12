using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Pause : MonoBehaviour {

		// Игровая пауза
		public bool _paused = false;
		// Окна меню
		private int _window = 100;
		public DragonController dc;
	private Text score;
	public int points=0;
    public ScoreList table;
	void Start(){
		score = GameObject.Find ("score").GetComponent<Text>();

	}
		
		// Update выполняется на каждый кадр 
		void Update () { 
		if (!_paused&&dc.choose) {

			points+=1;
			score.text= points+"";		
		}
				// Ставим игру на паузу
				if (dc.death) {
						if (!_paused) {  
								Time.timeScale = 0;  
								_paused = true; 
								_window = 1;
                                table.scoretable.Add(points, points);

						}
				}

						if (Input.GetKeyUp (KeyCode.Escape)) {				
								if (!_paused) {  
										Time.timeScale = 0;  
										_paused = true; 
										_window = 0;
								} else {  
										Time.timeScale = 1;  
										_paused = false;
										_window = 100;
								} 
						} 
				}
		
		
		void  OnGUI (){ 
			
			if (_window == 0) { 
				GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "PAUSE");
				
				if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 80,180,30), "Continue")) { // Продолжить
					Time.timeScale = 1;
					_paused=false;
					_window = 100; 
				} 
				
				if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Exit game")) { // Выход из игры
					Application.Quit(); 
				} 
			}
			
			// Смерть
			if (_window == 1) {  
				GUI.Box ( new Rect(Screen.width/2 - 100,Screen.height/2 - 100,200,180), "Sorry, you're dead"); 
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 - 80,180,30), "Try again")) { // Продолжить
				Time.timeScale = 1;
				_paused=false;
				_window = 100;
				dc.death=false;
				Application.LoadLevel("Level1"); 
			
			}
          /*  if (GUI.Button(new Rect(Screen.width / 2 - 90, Screen.height / 2 - 40, 180, 30), "Show best score"))
            {
                GameObject.Find("Table").GetComponentInChildren().gameObject.SetActive(true);
            }*/
			if (GUI.Button ( new Rect(Screen.width/2 - 90,Screen.height/2 + 40,180,30), "Exit game")) { // Выход из игры
				Application.Quit(); 
			} 
	
			}
					 
	}


        public void OnClickBack()
        {
            GameObject.Find("Scoretable").SetActive(false);
        }
}
