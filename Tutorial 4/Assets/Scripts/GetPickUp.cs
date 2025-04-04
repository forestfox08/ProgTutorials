using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPickUp : MonoBehaviour
{
    private Renderer r;
    private ParticleSystem ps;
    private AudioSource src;
    private KeepScore sc0re;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Renderer>();
        ps = GetComponent<ParticleSystem>();
        src = GetComponent<AudioSource>();
        sc0re = FindObjectOfType<KeepScore>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            r.enabled = false;
            GameObject.Destroy(gameObject, 0.5f);
            ps.Play();
            src.Play();
            sc0re.addscore(5);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
