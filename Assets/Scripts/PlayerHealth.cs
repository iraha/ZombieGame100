using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float hitPoints = 100f;

    public AudioSource takeDamageSound;

    public void TakeDamage(float damage)
    {
        hitPoints -= damage;
        takeDamageSound.Play();
        if (hitPoints <= 0)
        {
            Debug.Log("Player is died");
            GetComponent<DeathHandler>().HandleDeath();

            
        }
    }



}
