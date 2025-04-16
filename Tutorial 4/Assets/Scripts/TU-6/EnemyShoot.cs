using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhit : MonoBehaviour
{
    public GameObject Projectile;
    public Transform firepoint;
    public float projspeed = 500f;
    public float firerate = 0.5f;
    private float nextfiretime = 0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Animator animator = GetComponent<Animator>(); 
        if (gameObject.CompareTag("Player"))
        {
            if (Input.GetMouseButton(0) && Time.time > nextfiretime)
            {
                ShootProjectile();
                nextfiretime = Time.time + firerate;
            }

        }
        else
        {
            if (Time.time >= nextfiretime)
            {
                ShootProjectile();
                nextfiretime = Time.time + firerate;
            }
        }

    }
    void ShootProjectile()
    {
        GameObject projectile = Instantiate(Projectile, firepoint.position, firepoint.rotation);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(firepoint.forward * projspeed, ForceMode.VelocityChange);
        }
    }
}