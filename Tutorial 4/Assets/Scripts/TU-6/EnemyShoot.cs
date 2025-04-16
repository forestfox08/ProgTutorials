using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    public GameObject prefab;
    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
         GameObject ob = Instantiate(prefab);
         ob.transform.rotation = transform.rotation;
         ob.transform.position = transform.position + transform.forward;
         Destroy(ob,5f);
        }

    }
}
