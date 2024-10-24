
using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint; // The point where bullets spawn
    public GameObject bulletPrefab; // Prefab of the bullet
    public float bulletSpeed = 50f; // Speed of the bullet
    public int maxAmmo = 10; // Maximum ammo in the gun
    public float fireRate = 0.5f; // Fire rate of the gun (seconds between shots)
    public float reloadTime = 2f; // Time taken to reload
    private float nextTimeToFire = 0f;
    private int currentAmmo;
    private bool isReloading = false;

    void Start()
    {
        currentAmmo = maxAmmo; // Start with full ammo
    }

    void Update()
    {
        if (isReloading)
            return; // Prevent shooting while reloading

        // Use right mouse button (Fire2) to shoot
        if (Input.GetButton("Fire2") && Time.time >= nextTimeToFire)
        {
            if (currentAmmo > 0) // Check if there is ammo left
            {
                nextTimeToFire = Time.time + fireRate; // Set the time for the next shot
                Shoot();
            }
            else
            {
                StartCoroutine(Reload()); // Automatically reload when ammo is empty
            }
        }

        // Reload manually when pressing the 'R' key
        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo && !isReloading)
        {
            StartCoroutine(Reload()); // Start the reload process when 'R' is pressed
        }
    }

    void Shoot()
    {
        currentAmmo--; // Reduce the ammo count
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation); // Create the bullet
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = bulletSpawnPoint.forward * bulletSpeed; // Set bullet speed

        Destroy(bullet, 3f); // Destroy the bullet after 3 seconds to avoid clutter
    }

    IEnumerator Reload()
    {
        isReloading = true; // Set reloading state
        Debug.Log("Reloading...");
        yield return new WaitForSeconds(reloadTime); // Wait for reload time
        currentAmmo = maxAmmo; // Refill the ammo
        isReloading = false; // Done reloading
        Debug.Log("Reloaded!");
    }
}
