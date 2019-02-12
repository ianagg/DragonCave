using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
	
public class SpriteGenerator : MonoBehaviour
{
		public Transform backgroundup;
		public Transform backgrounddown;
		public List<Transform> obstacles;
        public List<Transform> bonus;
		//public Transform bonus;
		public Camera cam;
		private float laststop = -5f;
		private float prev = 10f;
        private float prevbon = 5f;
		public ChooseCharacter ch;
		int i = 0;
		Transform fon;
		// Use this for initialization
		void Start ()
		{
				Debug.Log (ch.i + " here we go");

		}
			
		
		// Update is called once per frame
		void Update ()
		{

            if (cam.transform.localPosition.x > (laststop - 20))
            {
                GeneratePath();
            }
			
		}

		public void GeneratePath ()
		{
				Instantiate (backgroundup, new Vector3 (laststop, 3.9f, 0), Quaternion.identity);
				Instantiate (backgrounddown, new Vector3 (laststop, -4.5f, 0), Quaternion.identity);
				laststop += 9.5f;
				GenerateObstacles ();
                GenerateBonus();
				Debug.Log (laststop);
		}

		public void GenerateObstacles ()
		{

				Transform obs = obstacles [Random.Range (0, 6)];
                Vector3 vec;
                if (obs.name == "hummer")
                {
                    vec = new Vector3(prev, 5f, 0f); 
                }
                else
                {
                    vec = new Vector3(prev, Random.Range(-2.5f, 1.5f), 0f);

                }
                while (Physics.CheckSphere(vec, 5))
                {
                    if (obs.name == "hummer")
                    {
                        vec = new Vector3(prev+Random.Range(1f, 4f), 5f, 0f);
                    }
                    else
                    {
                        vec = new Vector3(prev, Random.Range(-2.5f, 1.5f), 0f);

                    }
                }

						Instantiate (obs, vec, Quaternion.identity);	
				
			
				prev += 10;
		}


        public void GenerateBonus()
        {

            Transform bon = bonus[Random.Range(0, 4)];
            Vector3 vec = new Vector3(prevbon, Random.Range(-2.5f, 1.5f), 0f);
            while (Physics.CheckSphere(vec, 5))
            {
                vec = new Vector3(prevbon, Random.Range(-2.5f, 1.5f), 0f);
            }


            Instantiate(bon, vec, Quaternion.identity);
            prevbon += Random.Range(10, 50);
        
        
        }

		
}
