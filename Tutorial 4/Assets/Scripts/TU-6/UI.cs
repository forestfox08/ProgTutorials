using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI : MonoBehaviour
{
    public float health = 100f;
    public float damageAmount = 25f;
    public GameObject player;
    [SerializeField] private string tagToCollideWith = "ProjectileBullet";
    public int hitCount = 0;
    public Text healthText;

    private void Start()
    {
        UpdateHealthText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(tagToCollideWith))
        {
            health -= damageAmount;
            hitCount++;

            UpdateHealthText();

            if (health <= 0)
            {
                health = 0;
                Destroy(gameObject);
            }

            if (hitCount >= 4)
            {
                Destroy(gameObject);
            }
        }
    }

    private void UpdateHealthText()
    {
        healthText.text = "Health: " + health.ToString();
    }
}
