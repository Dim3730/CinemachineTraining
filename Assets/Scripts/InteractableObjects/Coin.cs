using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int coinsCount = 0;
    [SerializeField] private TextMeshProUGUI coinsText;

    private void Start()
    {
        coinsCount = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            coinsCount++;
            coinsText.text = coinsCount.ToString();
            Destroy(gameObject);
        }
    }
}