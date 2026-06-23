using UnityEngine;

public class Fighter : MonoBehaviour
{
  [SerializeField]
  private Animator animator;
  public Animator Animator => animator;
  [SerializeField]
  private Health health;
  public Health Health => health;
  [SerializeField]
  private FighterData fighterData;
  public FighterData FighterData => fighterData;
  private void Awake()
    {
        health.MaxHelath = fighterData.maxHealth;
    }
    public void TakeDamage()
    {
        Animator.Play("Damage", 0, 0f);
    }
    public void Die()
    {
        Animator.Play("Die", 0, 0f);
    }
}
