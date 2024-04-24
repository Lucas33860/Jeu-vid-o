using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flame : MonoBehaviour
{
 void OnTriggerEnter2D(Collider2D col) {
		if (col.gameObject.tag == "Player") {
			//On ajoute une flamme au joueur
			col.gameObject.GetComponent<PlayerManager>().AddFlame();
			Destroy(gameObject); //On détruit l'objet	
		}
	}
}
