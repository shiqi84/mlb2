using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public stats damage;
    public stats armor;
     void Awake()
    {
        currentHealth = maxHealth;
    }
     void Update()
    {
    }
    public void TakeDamage(int damage)
    {
        damage -= armor.getValue();
        currentHealth -= damage;
        Debug.Log(currentHealth);
        if (currentHealth <= 0)
        {
            Die();
        }
    }
    public virtual void Die()
    {
        Debug.Log(transform.name + "die");
    }
}
