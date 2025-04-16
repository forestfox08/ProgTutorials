using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{

    Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_Animator.SetTrigger("Walk");
            //m_Animator.ResetTrigger("Idle");
        }
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            m_Animator.SetTrigger("WalkR");
            //m_Animator.ResetTrigger("Idle");
        }
    }
}
