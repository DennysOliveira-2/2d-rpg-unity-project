using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Entity entity;

    [Header("Player UI")]
    public Slider healthSlider;
    public Slider manaSlider;
    public Slider staminaSlider;
    public Slider expSlider;

    void Start()
    {
        entity.currentHealth = entity.maxHealth;
        entity.currentMana = entity.maxMana;
        entity.currentStamina = entity.maxStamina;

        healthSlider.maxValue = entity.maxHealth;
        healthSlider.value = healthSlider.maxValue;

        manaSlider.maxValue = entity.maxMana;
        manaSlider.value = manaSlider.maxValue;

        staminaSlider.maxValue = entity.maxStamina;
        staminaSlider.value = entity.maxStamina;

        expSlider.value = 0;
    }

    private void Update()
    {
        healthSlider.value = entity.currentHealth;
        manaSlider.value = entity.currentMana;
        staminaSlider.value = entity.currentStamina;

        
    }
}


