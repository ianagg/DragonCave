/// <summary>
/// Player bar display.
/// Выводит на экран бары игрока
/// Вешать на игрока
/// </summary>
using UnityEngine;
using System.Collections;

public class PlayerBarDisplay : MonoBehaviour {
	//playerBar разделительные линии панели здоровья и маны
	//HealthBar полоса здоровья игрока
	//ManaBar Полоса маны игрока
	//Bar фон панели
	public GUISkin mySkin; // Скин где хранятся текстуры баров
	public PlayerStats Char; // Объект на котором висят статы
	public bool Visible = true; //Видимость бара

	// Use this for initialization
	void Start () {
	
	}
	
	void OnGUI () {
		if(Visible)
		{
			//назначаем mySkin текущим скином для GUI
			GUI.skin = mySkin;
			//получаем переменную PlayerSt компонент PlayerStats
			//В инспекторе в Unity нужно указать на игрока
			PlayerStats PlayerSt = (PlayerStats)Char.GetComponent("PlayerStats");
			//получаем значения
			float MaxFire= (float)PlayerSt.MaxFire;
			float CurFire= (float)PlayerSt.CurFire;
			//расчитываем коэффицент длинны полосы здоровья
			float FireBarLen = CurFire/MaxFire; //если умножить на сто то будут проценты
			//расчитываем коэффицент длинны полосы маны

			//рисуем общий фон панели здоровья и маны
			GUI.Box(new Rect(10,10,153,20), " ", GUI.skin.GetStyle("Bar"));
			
			//полоса здоровья игрока
			GUI.Box(new Rect(10,10,153*FireBarLen,20), " ", GUI.skin.GetStyle("fireBar")); 

			//рисуем разделительные линии панели здоровья и маны
			GUI.Box(new Rect(10,10,153,20), " ", GUI.skin.GetStyle("playerBar"));
			
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
