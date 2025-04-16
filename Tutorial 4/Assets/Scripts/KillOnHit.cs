using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    public float effectLifetime = 2f;
    public string playerTag = "Player";

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }

        if (effect != null)
        {
            ContactPoint contact = coll.contacts[0];
            GameObject expl = Instantiate(effect, contact.point, Quaternion.identity);
            Destroy(expl, effectLifetime);
        }


        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }

        if (effect != null)
        {
            GameObject expl = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(expl, effectLifetime);
        }
        if (coll.gameObject.tag == playerTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }

            Destroy(gameObject);
    }

}
