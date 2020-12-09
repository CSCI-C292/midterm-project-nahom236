using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthSystem : MonoBehaviour
{
    [SerializeField] Slider slider;

    
    public void SetMaxHealth(int health) {
        slider.maxValue = health;
        slider.value = health;
    }

    public void decreaseHealth(int health) {
        slider.value = slider.value - health;
    }

    public bool isDone() {
        if (slider.value == 0) {
            return true;
        }
        else {
            return false;
        }
    }

    public int currentHealth() {
        return (int) slider.value;
    }
}
