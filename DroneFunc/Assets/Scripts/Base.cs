using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    [SerializeField] public float health, maxHealth = 500;
    [SerializeField] FloatingHealthBar healthBar;
    
    
    // Start is called before the first frame update



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


        public void TakeDamage (float damageAmount)
    {
        health -= damageAmount;
        healthBar.UpdateHealthBar(health,maxHealth);
        if (health <= 0)
        {   
            Die();
        }
    }

        public void Die()
    {
        Destroy(gameObject);
    }
}
