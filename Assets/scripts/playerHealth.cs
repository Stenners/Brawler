using UnityEngine;
using System.Collections;

public class playerHealth : MonoBehaviour {
	

	void Start () {
		//healthBar = Resources.Load ("health");
	}
	//public Animator anim;

	void awake () {
		//anim = GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update () {


	}

	void OnGUI(){
		//GUI.Box(new Rect(10, 10, 10, 10), new GUIContent(healthBar));
	}
	
	void OnCollisionEnter2D (Collision2D col) {
		//bool isAttacking = anim.GetBool("attacking");
		if(col.gameObject.tag == "Enemy") {	
			//if (isAttacking){
				//Debug.Log("THEY GOT HIT");
			//}
		}
	}
}
