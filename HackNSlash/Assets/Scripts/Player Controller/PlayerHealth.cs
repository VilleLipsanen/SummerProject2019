using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{

    private int startingHealth = 100;
    public int currentHealth;

    private void Start()
    {
        currentHealth = startingHealth;
        Debug.Log("chad " + currentHealth);
    }

    public PlayerHealth(int health)
    {
        currentHealth = health;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
    }


}
