using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour
{

    [SerializeField] Canvas gameOverCanvas;
    public AudioSource BGM;

    private void Start()
    {
        gameOverCanvas.enabled = false;
        //BGM = GetComponent<AudioSource>();
        
    }

    public void HandleDeath()
    {
        gameOverCanvas.enabled = true;
        Time.timeScale = 0;
        // below is to stop WeaponSwitcher Script
        FindObjectOfType<WeaponSwitcher>().enabled = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        BGM.Stop();

        
    }

}
