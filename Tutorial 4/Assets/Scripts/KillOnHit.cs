using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KillOnHit : MonoBehaviour
{
    public string targetTag;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {
    GameObject expl = Instantiate(effect);
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }
        
    }
    private void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == targetTag)
        {
            Destroy(coll.gameObject, 0.1f);
        }
    }
}
