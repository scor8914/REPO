using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour {

    public int damageToGive;
    private int currentDamage;
    public GameObject damageBurst;
    public Transform hitBox;
    public GameObject damageNumber;


    private PlayerStats thePS;

	// Use this for initialization
	void Start () {
        thePS = FindObjectOfType<PlayerStats>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            //Destroy(other.gameObject);
            currentDamage = damageToGive + thePS.currentAttack;

            other.gameObject.GetComponent<EnemyHealthManager>().hurtEnemy(currentDamage);
            Instantiate(damageBurst, hitBox.position, hitBox.rotation);
            var clone = (GameObject) Instantiate(damageNumber, hitBox.transform.position, Quaternion.Euler(Vector3.zero));
            clone.GetComponent<FloatingNumbers>().damageNumber = currentDamage;
        }
    }
}
