using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // UI uchun bu kutubxonani qo'shish kerak

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;  // Maksimal jon
    public int currentHealth;    // Hozirgi jon

    // UI Text komponenti (Count Score Text) uchun
    public Text countScoreText; 
    
    void Start()
    {
        // O'yin boshida maksimal jon bilan boshlaymiz
        currentHealth = maxHealth;

        // UI da joriy jonni yangilash
        UpdateHealthText();
    }

    // Jonga zarar beradigan funksiyani chaqiramiz
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        // Jon nolga teng bo'lsa o'lim funksiyasini chaqiramiz
        if (currentHealth <= 0)
        {
            currentHealth = 0;  // Jon nol bo'lib qolishini ta'minlaymiz
            Die();
        }

        // UI da joriy jonni yangilash
        UpdateHealthText();
    }

    // Jonni oshirish funksiyasi
    public void Heal(int amount)
    {
        currentHealth += amount;

        // Jon maksimal darajadan oshib ketmasligi kerak
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        // UI da joriy jonni yangilash
        UpdateHealthText();
    }

    // Joriy jonni UI text komponentida yangilash (Count Score Text)
    void UpdateHealthText()
    {
        countScoreText.text = "Health: " + currentHealth.ToString();
    }

    // Belgi o'lganida nima bo'lishini aniqlaydigan funksiya
    void Die()
    {
        Debug.Log("Player died!");
        // O'lim animatsiyasi yoki boshqa effektlar bu yerga qo'shiladi
    }
}
