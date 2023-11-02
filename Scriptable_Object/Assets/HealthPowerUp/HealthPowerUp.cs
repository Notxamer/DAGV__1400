using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : MonoBehaviour
{
    public FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Apply the health value to the player
            ApplyHealth(other.gameObject);

            // Destroy the power-up game object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {

    }
}
