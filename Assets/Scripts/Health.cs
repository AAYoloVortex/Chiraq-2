using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    private float damage = 0.00875f;
    public Image healthBar;
    public int numFoods = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        health = health - damage;
        if(health <= 0)
        {
            SceneManager.LoadScene(6);
        }
        //health = float(health);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        
        if(other.gameObject.CompareTag("TrashCan") && numFoods > 0)
        {
            health = health + 10;
            Debug.Log("HEALED");
            if(health >= maxHealth)
            {
                health = maxHealth;
            }
        }
    }


}
