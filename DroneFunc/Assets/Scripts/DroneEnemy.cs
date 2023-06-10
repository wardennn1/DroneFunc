using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneEnemy : MonoBehaviour
{
    public float Speed = 0f;
    public float raycastLength = 10f;
    float upForce;
    private Rigidbody _rb;
    
    [SerializeField] public float health, maxHealth = 100f;

    [SerializeField] FloatingHealthBar healthBar;
    RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        health = maxHealth;
        healthBar.UpdateHealthBar(health,maxHealth);
        healthBar = GetComponentInChildren<FloatingHealthBar>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rb.AddRelativeForce(Vector3.up * upForce);
                
        Ray ray = new Ray (transform.position, -transform.up);

        MovementLogic ();
        

    }

    private void MovementLogic ()
    {
        // float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis("Vertical");

        // if(Input.GetKey(KeyCode.LeftShift))
        //     {
        //         upForce = 8f;
        //     } 
        // else if (Input.GetKey(KeyCode.LeftControl))
        //     {
        //         upForce = -8f;
        //     } 
        // else if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl))
        //     {
        //         upForce = 0f;
        //     }
        // Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // _rb.AddRelativeForce(movement * Speed);

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

