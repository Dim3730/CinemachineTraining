using System.Collections;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}