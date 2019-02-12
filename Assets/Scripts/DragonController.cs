using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DragonController : ControllableBehaviour
{
		public float speed;
		public float shootPower;
		public GameObject firePref;
		public Transform firePoint;
		public Animator myAnimator;
		public Camera cam;
		public PlayerStats Char;
		public RuntimeAnimatorController an;
		public RuntimeAnimatorController an2;
		public bool death = false;
		public bool choose = false;
		private bool start = false;
        private float currentspeed = 0.001f;
		// Use this for initialization
		void Start ()
		{

		}

	
		// Update is called once per frame
		void Update ()
		{
            
				if (choose && !start) {
						start = true;
						Destroy (GameObject.Find ("one"));
						Destroy (GameObject.Find ("two"));
						this.transform.position = new Vector3 (-5f, 0f, 0f);
				}
				if (choose && start) {

						transform.Translate (3f * Time.deltaTime * currentspeed, 0f, 0f);

						if (Input.GetKey ("space")) {
								DoAction ();		
						} else {
								myAnimator.SetBool ("shoot", false);
						}
				}
                currentspeed += 0.002f;
		}

		void FixedUpdate ()
		{
				float direction = Input.GetAxis ("Vertical");
				GetComponent<Rigidbody2D> ().velocity = new Vector3 (0f, direction * speed, 0f);
	
		}

		public override void DoAction ()
		{
				PlayerStats PlayerSt = (PlayerStats)Char.GetComponent ("PlayerStats");
				myAnimator = GetComponent<Animator> (); 
		
				if (PlayerSt.CurFire == 0) {

						myAnimator.SetBool ("power", false);
				}
				myAnimator.SetBool ("shoot", true);
				
		}

		public void Shoot ()
		{
				PlayerStats PlayerSt = (PlayerStats)Char.GetComponent ("PlayerStats");
				if (PlayerSt.CurFire != 0) {
						//из источника, в этой позиции, с таким вращением
						GameObject newBall = Instantiate (firePref, firePoint.position, transform.rotation) as GameObject;
						newBall.GetComponent<Rigidbody2D> ().velocity = (newBall.transform.right * shootPower) * 0.5f;

						PlayerSt.CurFire = PlayerSt.CurFire - 1;
						Destroy (newBall, 1f);
				} else {
						myAnimator = GetComponent<Animator> (); 
						myAnimator.SetBool ("power", false);
				}
		}

		void OnCollisionEnter2D (Collision2D coll)
		{
				death = true;

		}

		void OnTriggerEnter2D (Collider2D other)
		{
				other.SendMessage ("Points", SendMessageOptions.DontRequireReceiver);
				myAnimator = GetComponent<Animator> (); 
				myAnimator.SetBool ("power", true);
             other.SendMessage("ScorePoints", SendMessageOptions.DontRequireReceiver);

		}

		public void OnClickOne ()
		{
				this.GetComponent<Animator> ().runtimeAnimatorController = an2;
				choose = true;
		}

		public void OnClickTwo ()
		{
				this.GetComponent<Animator> ().runtimeAnimatorController = an;
				choose = true;

		}



}
