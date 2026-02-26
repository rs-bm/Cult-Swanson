using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class EnemyBehavior : MonoBehaviour
{
    public TMP_Text hpText;
    public int maxHealth;
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxHealth = 100;
        health = 100;
        hpText.SetText("Enemy HP: " + health + "/" + maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            setHealth(-8);
        }
    }
    void setHealth(int change)
    {
        health += change;
        health = Mathf.Clamp(health, 0, maxHealth);
        hpText.SetText("Enemy HP: " + health + "/" + maxHealth);
    }
}
