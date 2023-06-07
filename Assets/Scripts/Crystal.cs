using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public int health;
    Scoremanager scoremanager;

    bool healthDelay = true;
    private void Awake()
    {
        scoremanager = GameObject.FindWithTag("Manager").GetComponent<Scoremanager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
            
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy") && healthDelay)
        {
            Debug.Log("Crystal");
            health -= 1;
            healthDelay = false;
            Invoke("Delay", 1);
        }
    }

    private void OnCollision(Collision collision)
    {
        
    }

    void Delay()
    {
        healthDelay = true;
    }

    private void Update()
    {
        if (health <= 0)
        {
            scoremanager.End();
        }
    }
}
