using UnityEngine;
using UnityEngine.SceneManagement;

public class DownZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}