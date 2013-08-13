using UnityEngine;
using System.Collections;

public class enemyBehaviour : MonoBehaviour {

	private string enemyName = "Craig";
	private int enemyHealth;
	private float height = 5.8f;

	private string[] gunArray;
	private string currentGun;

	void Start(){
		
		enemyHealth = pickHealth(40, 150);

		Debug.Log(enemyHealth);

	}

	public int pickHealth(int minHealth, int maxHealth){

		int randomHealth = Random.Range(minHealth, maxHealth);

		return randomHealth;
	}

}
