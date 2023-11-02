using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AmmoPowerup : MonoBehaviour
{
    [SerializeField] private IntData ammoValue;

    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Add ammo to weapon
            AddAmmo(other.gameObject);

            //Destroy power up
            Destroy(gameObject);

            triggerEnterEvent.Invoke();
        }
    }

    private void AddAmmo(GameObject player)
    {    // Retrive players weapon
        WeaponController weaponController = player.GetComponent<WeaponController>();
        // Check if the player has a weapon component
        if (weaponController != null)
        {
            // Add the ammo value to the player's current ammo count
            weaponController.AddAmmo();
        }

    }
}
