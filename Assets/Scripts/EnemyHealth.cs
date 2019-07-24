using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float starthealth = 100f;
    [SerializeField] private float health;

    [SerializeField] GameObject enemyDeathEffect;
    [SerializeField] GameObject glowEffect;

    bool isDead = false;

    public AudioSource deathSound;
    public AudioSource zonbieVoice;


    [Header("Unity Stuff")]
    public Image healthBar;

    


    public bool IsDead()
    {
        return isDead;
    }

    void Start()
    {

        health = starthealth;

    }


    public void TakeDamage(float damage)
    {
        //GetComponent<EnemyAI>().OnDamageTaken();
        BroadcastMessage("OnDamageTaken");
        health -= damage;
        healthBar.fillAmount = health / starthealth;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {

        enemyDeathEffect.SetActive(true);
        glowEffect.SetActive(true);

        if (isDead)
        {
            //Destroy(gameObject);
            return;
        }


        //deathSound.Play();

        isDead = true;
        GetComponent<Animator>().SetTrigger("die");

        Destroy(gameObject, 2f);

        deathSound.Play();
        zonbieVoice.Play();

    }

}
