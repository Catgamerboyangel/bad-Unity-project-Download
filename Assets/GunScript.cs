
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform bulletSpawnPoint; // The point where bullets spawn
    public GameObject bulletPrefab; // Prefab of the bullet
    public float bulletSpeed = 50f; // Speed of the bullet (now 50)
    public int maxAmmo = 10; // Maximum ammo in the gun
    public float fireRate = 0.5f; // Fire rate of the gun (seconds between shots)
    private float nextTimeToFire = 0f;
    private int currentAmmo;

    void Start()
    {
        currentAmmo = maxAmmo; // Start with full ammo
    }

    void Update()
    {
        // Check if the player presses the fire button and if enough time has passed since the last shot
        if (Input.GetButton("Fire2") && Time.time >= nextTimeToFire && currentAmmo > 0)
        {
            nextTimeToFire = Time.time + fireRate; // Set the time for the next shot
            Shoot();
        }
    }

    void Shoot()
    {
        currentAmmo--; // Reduce the ammo count
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation); // Create the bullet
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.velocity = bulletSpawnPoint.forward * bulletSpeed; // Set bullet speed to 50
    }

    public void Reload()
    {
        currentAmmo = maxAmmo; // Refill the ammo
    }
}
