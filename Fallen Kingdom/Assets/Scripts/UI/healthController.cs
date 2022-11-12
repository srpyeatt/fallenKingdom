using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthController : MonoBehaviour
{
    public Slider healthSlider;
    public Gradient healthGrad;
    public Image healthFill;

    public void SetMaxHealth(int health) {
        healthSlider.maxValue = health;
        healthSlider.value = health;

        healthFill.color = healthGrad.Evaluate(1f);
    }

    public void SetHealth(int health) {
        healthSlider.value = health;
        healthFill.color = healthGrad.Evaluate(healthSlider.normalizedValue);
    }
}
