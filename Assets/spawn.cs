using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject cubePrefab; // Assign the Cube prefab in the Inspector
    public GameObject spherePrefab; // Assign the Sphere prefab in the Inspector
    public float spawnDistance = 5f; // Distance from the camera where the object will spawn

    void Update()
    {
        // Check if the player presses the "1" key to spawn a cube
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SpawnObject(cubePrefab);
        }

        // Check if the player presses the "2" key to spawn a sphere
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SpawnObject(spherePrefab);
        }
    }

    void SpawnObject(GameObject prefab)
    {
        // Get the camera's forward direction and position
        Camera mainCamera = Camera.main;
        Vector3 spawnPosition = mainCamera.transform.position + mainCamera.transform.forward * spawnDistance;

        // Instantiate the object at the calculated position and the camera's rotation
        Instantiate(prefab, spawnPosition, mainCamera.transform.rotation);
    }
}
