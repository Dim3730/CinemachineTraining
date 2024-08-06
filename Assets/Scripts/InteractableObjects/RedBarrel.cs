using UnityEngine;

public class RedBarrel : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerHealth.TakeDamage();
            Destroy(gameObject);
        }
    }
}