using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, IDamagable
{
    public int Health { get; set; }
    [SerializeField] private int playerHealth;
    [SerializeField] private TextMeshProUGUI playerHealthText;

    private void Start()
    {
        Health = playerHealth;
        playerHealthText.text = Health.ToString();
    }

    public void TakeDamage()
    {
        Health--;
        playerHealthText.text = Health.ToString();
        if(Health <= 0)
        {
            Death();
        }
    }
    public void Death()
    {
        print("Player is dead");
        SceneManager.LoadScene("Menu");
    }
}