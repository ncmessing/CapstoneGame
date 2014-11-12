using UnityEngine;
using System.Collections;

public class ZombieHealth : MonoBehaviour {


	public int HP = 1;
	public bool isEnemy = true;

	public void Damage(int damageCount)
	{
				HP -= damageCount;
		if (HP <= 0) 
		{
			Destroy (gameObject);
		}

	}

	void OnTriggerEnter2D(Collider2D otherCollider)
	{

				ProjectileCollide shot = otherCollider.gameObject.GetComponent<ProjectileCollide> ();
				if (shot != null) {

								Destroy (shot.gameObject);
						
				}
		}


}
