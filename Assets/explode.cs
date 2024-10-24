using UnityEngine;

public class ExplosionOnTouch : MonoBehaviour
{
    public GameObject explosionPrefab;  // Assign your explosion prefab in the inspector
    public int numberOfExplosions = 5;  // How many explosions to trigger
    public float explosionRadius = 5f;  // The radius around the object where explosions will spawn
    public float explosionForce = 500f; // The force applied to nearby rigidbodies
    public float explosionUpwardModifier = 1f;  // To make the objects fly upwards
    public float explosionCooldown = 1f;  // Time between explosions
    public LayerMask rigidbodyLayer; // Layer to check for objects with Rigidbody

    private bool canExplode = true;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is on the "Ground" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground") && canExplode)
        {
            StartMultipleExplosions();
        }
    }

    private void StartMultipleExplosions()
    {
        for (int i = 0; i < numberOfExplosions; i++)
        {
            // Generate random position around the object within the explosion radius
            Vector3 randomOffset = Random.insideUnitSphere * explosionRadius;
            randomOffset.y = 0; // Keep explosions at the same height (if desired)

            // Instantiate an explosion effect at the offset position
            Instantiate(explosionPrefab, transform.position + randomOffset, Quaternion.identity);

            // Apply explosive force to nearby objects with a Rigidbody
            ApplyExplosionForce(transform.position + randomOffset);
        }

        // Temporarily prevent explosions until cooldown passes
        canExplode = false;
        Invoke("ResetExplosion", explosionCooldown);
    }

    private void ApplyExplosionForce(Vector3 explosionPosition)
    {
        // Find all objects within the explosionRadius
        Collider[] colliders = Physics.OverlapSphere(explosionPosition, explosionRadius, rigidbodyLayer);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                // Apply an explosive force to the rigidbody
                rb.AddExplosionForce(explosionForce, explosionPosition, explosionRadius, explosionUpwardModifier, ForceMode.Impulse);
            }
        }
    }

    private void ResetExplosion()
    {
        canExplode = true;
    }
}