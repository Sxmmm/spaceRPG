using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombatScript : MonoBehaviour {

    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    private int currentHealth;

    [SerializeField]
    private GameObject uiObject;

    [SerializeField]
    private UIManagerScript healthBar;

    private void OnEnable() {
        currentHealth = maxHealth;
        uiObject = GameObject.Find("UI");
        healthBar = uiObject.GetComponent<UIManagerScript>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) & currentHealth > 0) {
            ChangeHealth(-10);
        }
        if (Input.GetKeyDown(KeyCode.R)) {
            int toMaxHealth = maxHealth - currentHealth;
            ChangeHealth(toMaxHealth);
        }
    }

    private void ChangeHealth(int hpChange) {
        currentHealth += hpChange;

        // Must convert to float in order to get result out of 1 (percentage for fill amount)
        float currentHealthPer = (float)currentHealth / (float)maxHealth;

        healthBar.HandleHealthChanged(currentHealthPer);
    }
}
