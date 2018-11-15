using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour {

    public float fullHealthBar;
    public float EnemyHealth;
    public Image healthBar;

	void Start () {
        EnemyHealth = fullHealthBar;

        
    }
	
	
	void Update () {

        healthBar.fillAmount = EnemyHealth / fullHealthBar;

        if (EnemyHealth <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
