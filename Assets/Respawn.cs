using UnityEngine;

public class QuitOnTouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is on the "Respawn" layer
        if (collision.gameObject.layer == LayerMask.NameToLayer("Respawn"))
        {
            Debug.Log("Touched an object with Respawn layer. Quitting game...");
            QuitGame();
        }
    }

    private void QuitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit();  // Quits the application when built
    }
}