using UnityEngine;
using System.Collections;

public class enemyHealth : MonoBehaviour {

	public Animator anim;
	public int hp = 1;

	void awake () {
		//anim = GetComponent<Animator>();
	}

	public void Damage(int damageCount)	{
		hp -= damageCount;
		if (hp <= 0)
		{
			Destroy(gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		//bool isAttacking = anim.GetBool("attacking");
		if(col.gameObject.tag == "Player") {	
			//if (isAttacking) {
				Debug.Log("They GOT HIT");
				Damage(1);
			//}
		}
	}

}