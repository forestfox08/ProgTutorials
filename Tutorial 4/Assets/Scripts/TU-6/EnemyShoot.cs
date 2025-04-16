using System.Collections;
using System.Collections.Generic;
using UnityEngine;

<<<<<<< HEAD
public class enemyhit : MonoBehaviour
{
    public GameObject Projectile;
    public Transform firepoint;
    public float projspeed = 500f;
    public float firerate = 0.5f;
    private float nextfiretime = 0f;
    void Start()
    {

=======
public class EnemyShoot : MonoBehaviour
{

    public GameObject prefab;
    

    // Start is called before the first frame update
    void Start()
    {
     
>>>>>>> 0f57729faa8dcf3b4756d7910c5d1b5750943c66
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
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
=======
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
         GameObject ob = Instantiate(prefab);
         ob.transform.rotation = transform.rotation;
         ob.transform.position = transform.position + transform.forward;
         Destroy(ob,5f);
        }

    }
}
>>>>>>> 0f57729faa8dcf3b4756d7910c5d1b5750943c66
