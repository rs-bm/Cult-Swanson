using TMPro;
using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class CultBehavior : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource winMusic;
    public AudioSource loseMusic;
    public TMP_Text hpText;
    public TMP_Text enemyHpText;
    public GameObject gameEndTextContainer;
    public TMP_Text gameEndText;
   int maxHealth;
    int health;
    int enemyMaxHealth;
    int enemyHealth;
    private float time;
    private Boolean gameOver;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = 100;
        health = 100;
        enemyMaxHealth = 100;
        enemyHealth = 100;
        hpText.SetText("HP: " + health + "/" + maxHealth);
        enemyHpText.SetText("Enemy HP: " + enemyHealth + "/" + enemyMaxHealth);
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            return;
        }
        // damage player
        if (Time.time - time > 0.5)
        {
            time = Time.time;
            health += -5;
            health = Mathf.Clamp(health, 0, maxHealth);
            hpText.SetText("HP: " + health + "/" + maxHealth);
            if (health == 0)
            {
                gameOver = true;
                BGM.Stop();
                loseMusic.Play();
                gameEndTextContainer.SetActive(true);
                gameEndText.SetText("You lost...");
            }
        }
        // damage enemy
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            enemyHealth += -5;
            enemyHealth = Mathf.Clamp(enemyHealth, 0, enemyMaxHealth);
            enemyHpText.SetText("Enemy HP: " + enemyHealth + "/" + enemyMaxHealth);
            if (enemyHealth == 0)
            {
                gameOver = true;
                BGM.Stop();
                winMusic.Play();
                gameEndTextContainer.SetActive(true);
                gameEndText.SetText("You win!");
            }
        }
    }
}
