using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    [SerializeField] GameObject bullet, rohr;
    [SerializeField] float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject ShotBullet = Instantiate(bullet, rohr.transform.position, Quaternion.identity);
        ShotBullet.GetComponent<Rigidbody>().AddForce(rohr.transform.forward * speed, ForceMode.Impulse);
        StartCoroutine("DestroyBullet", ShotBullet);
    }

    IEnumerator DestroyBullet(GameObject bullet)
    {
        yield return new WaitForSeconds(3);
        Destroy(bullet);
    }
}