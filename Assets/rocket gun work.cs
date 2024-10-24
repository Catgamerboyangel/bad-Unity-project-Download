using UnityEngine;
using System.Collections;

public class RocketLauncher : MonoBehaviour
{
    public Transform rocketSpawnPoint; // The point where rockets spawn
    public GameObject rocketPrefab; // Prefab of the rocket
    public float rocketSpeed = 30f; // Speed of the rocket
    public float fireRate = 1.5f; // Fire rate of the rocket launcher (seconds between shots)
    public float explosionRadius = 5f; // The radius of the explosion
    public float explosionForce = 700f; // The force applied by the explosion
    public int rocketDamage = 100; // Damage caused by the rocket
    public int maxAmmo = 5; // Maximum ammo for the rocket launcher
    public float reloadTime = 3f; // Time taken to reload

    private int currentAmmo;
    private float nextTimeToFire = 0f;
    private bool isReloading = false;

    void Start()
    {
        currentAmmo = maxAmmo; // Start with full ammo
    }

    void Update()
    {
        if (isReloading)
            return; // Prevent shooting while reloading

        // Check if the "E" key is pressed and if enough time has passed since the last shot
        if (Input.GetKeyDown(KeyCode.E) && Time.time >= nextTimeToFire && currentAmmo > 0)
        {
            nextTimeToFire = Time.time + fireRate; // Set the time for the next shot
            FireRocket();
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload()); // Automatically reload when out of ammo
        }

        // Manual reload with 'R' key
        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo && !isReloading)
        {
            StartCoroutine(Reload());
        }
    }

    void FireRocket()
    {
        currentAmmo--; // Reduce ammo count
        GameObject rocket = Instantiate(rocketPrefab, rocketSpawnPoint.position, rocketSpawnPoint.rotation);
        Rigidbody rb = rocket.GetComponent<Rigidbody>();
        rb.velocity = rocketSpawnPoint.forward * rocketSpeed; // Set rocket speed
    }

    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime); // Wait for reload time
        currentAmmo = maxAmmo; // Refill ammo
        isReloading = false;
        Debug.Log("Reloaded!");
    }
}