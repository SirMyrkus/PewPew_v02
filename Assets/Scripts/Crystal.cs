using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    public int health;
    Scoremanager scoremanager;

    bool healthDelay;
    private void Awake()
    {
        scoremanager = GameObject.FindWithTag("Manager").GetComponent<Scoremanager>();
    }

    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && healthDelay)
        {
            health -= 1;
            healthDelay = false;
            Invoke("Delay", 1);
        }
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
