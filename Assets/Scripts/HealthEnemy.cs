using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthEnemy : MonoBehaviour
{
    public int health;
    [SerializeField] int plusscore;
    [SerializeField] Scoremanager scoremanager;

    private void Awake()
    {
        scoremanager = GameObject.FindWithTag("Manager").GetComponent<Scoremanager>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            health -= 1;
            Destroy(collision.gameObject);
            Debug.Log("destroy");
        }
    }

    private void Update()
    {
        if (health <= 0)
        {
            scoremanager.score += plusscore;
            Debug.Log("Destroy self");
            Destroy(gameObject);
        }
    }
}
