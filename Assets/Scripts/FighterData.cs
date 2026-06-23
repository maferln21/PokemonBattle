using UnityEngine;

[CreateAssetMenu(fileName = "FighterData", menuName = "Scriptable Objects/FighterData")]
public class FighterData : ScriptableObject
{
    public float maxHealth;
    public string fighterName;
    public AttackData[] attacks;
    public float chargeTime = 2f;
    public AttackData GetRandomAttack()
    {
        return attacks[Random.Range(0, attacks.Length)];
    }
    
}
[System.Serializable]
public class AttackData
{
    public string name;
    public string animationName;
    public float minDamage;
    public float maxDamage;
    public GameObject chargeParticles;
    public GameObject attackParticles;
}
