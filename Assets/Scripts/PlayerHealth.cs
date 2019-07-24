using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float startHealth = 100f;
    [SerializeField] float health;

    public Image playerHealthBar;
    public AudioSource takeDamageSound;



    void Start()
    {

        health = startHealth;

    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        playerHealthBar.fillAmount = health / startHealth;

        takeDamageSound.Play();
        if (health <= 0)
        {
            Debug.Log("Player is died");
            GetComponent<DeathHandler>().HandleDeath();

            
        }
    }



}
