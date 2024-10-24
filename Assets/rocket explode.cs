using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float explosionRadius = 5f; // The radius of the explosion
    public float explosionForce = 700f; // The force applied by the explosion
    public int damage = 100; // The damage caused by the rocket

    void OnCollisionEnter(Collision collision)
    {
        Explode();
    }

    void Explode()
    {
        // Find all nearby objects in the explosion radius
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius); // Apply explosion force
            }

            // Deal damage to objects with health components (you can define your own Health component)
            Health targetHealth = nearbyObject.GetComponent<Health>();
            if (targetHealth != null)
            {
                targetHealth.TakeDamage(damage);
            }
        }

        Destroy(gameObject); // Destroy the rocket after explosion
    }
}