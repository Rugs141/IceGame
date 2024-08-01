using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText = default;
    [SerializeField] private TextMeshProUGUI staminaText = default;

    private void OnEnable()
    {
        FirstPersonController.onDamage += UpdateHealth;
        FirstPersonController.onHeal += UpdateHealth;
        FirstPersonController.onStaminaChange += UpdateStamina;
    }
    private void OnDisable()
    {
        FirstPersonController.onDamage -= UpdateHealth;
        FirstPersonController.onHeal -= UpdateHealth;
        FirstPersonController.onStaminaChange -= UpdateStamina;
    }

    private void Start()
    {
        UpdateHealth(100);
        UpdateStamina(100);
    }

    private void UpdateHealth(float currentHealth)
    {
        healthText.text = currentHealth.ToString("00");
    }

    private void UpdateStamina(float currentStamina)
    {
        staminaText.text = currentStamina.ToString("00");
    }

}
