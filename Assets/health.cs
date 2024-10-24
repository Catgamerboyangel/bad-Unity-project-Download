using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; // Initialize health to maximum
    }

    // Function to take damage
    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount; // Subtract the damage from current health
        Debug.Log("Took " + damageAmount + " damage. Current health: " + currentHealth);

        if (currentHealth <= 0)
        {
            Die(); // Call the Die function if health reaches zero
        }
    }

    // Function to heal
    public void Heal(int healAmount)
    {
        currentHealth += healAmount; // Add healing to current health
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth; // Ensure health does not exceed maxHealth
        }
        Debug.Log("Healed " + healAmount + " health. Current health: " + currentHealth);
    }

    // Function called when health reaches zero
    void Die()
    {
        Debug.Log("Character died.");
        // You can destroy the object, trigger animations, or handle respawn logic here
        Destroy(gameObject); // Destroy the object
    }
}