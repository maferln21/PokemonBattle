using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField]
    private Slider healthSlider;
    private float currenyHealth;
    public float CurrentHelath => currenyHealth;
    private float maxHelath;
    public float MaxHelath{ set { maxHelath = value; }}
    [SerializeField]
    private UnityEvent onReceiveDamage;
    [SerializeField]
    private UnityEvent onDie;
    public void InitializeHelath()
    {
        currenyHealth = maxHelath;
    }  
    private void UpdateBar()
    {
        healthSlider.value = currenyHealth / maxHelath;
    }
    public void TakeDamage(float damage)
    {
        currenyHealth -= damage;
        if (currenyHealth <= 0)
        {
            currenyHealth = 0;
            onDie?.Invoke();
        }
        else
        {
            onReceiveDamage?.Invoke();
        }
        UpdateBar();
    }
}
