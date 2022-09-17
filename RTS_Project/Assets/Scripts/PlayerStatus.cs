using System;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int currentHunger;
    private int currentThirst;
    private float activeTimeHunger = 0;
    private float activeTimeThirst = 0;
    private int maxHunger = 100;
    private int maxThirst = 100;
    public event Action<float> OnHungerPctChanged = delegate { };
    public event Action<float> OnThirstPctChanged = delegate { };
    private void Awake() {
        currentHunger = maxHunger;
        currentThirst = maxThirst;
    }

    void Update()
    {
        RemoveHunger();
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Cup_water"))
        {
            Drink();
            other.gameObject.SetActive(false);
        }
        if(other.gameObject.CompareTag("Food"))
        {
            Eat();
            Destroy(other.gameObject);
        }
    }

    public void Drink()
    {
        currentThirst += 30;
        float pct = (float)currentThirst / (float)maxThirst;
        OnThirstPctChanged(pct);
    }

    public void Eat()
    {
        currentHunger--;
        float pct = (float)currentHunger / (float)maxHunger;
        OnHungerPctChanged(pct);
    }

    public void RemoveHunger()
    {
        activeTimeHunger += Time.deltaTime;
        activeTimeThirst += Time.deltaTime;
        if(activeTimeHunger > 30)
        {
            currentHunger--;
            float pct = (float)currentHunger / (float)maxHunger;
            OnHungerPctChanged(pct);
            activeTimeHunger = 0;
        }
    
        if(activeTimeThirst > 10)
        {
            currentThirst--;
            float pct = (float)currentThirst / (float)maxThirst;
            OnThirstPctChanged(pct);
            activeTimeThirst = 0;
        }
    }
}
