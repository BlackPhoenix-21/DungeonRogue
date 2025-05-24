using UnityEngine;

public class ObjectSheet : MonoBehaviour
{
    public SkillAttack[] skills;
    public SkillAttack[] attacks;
    public Character[] playerCharacter;
    public Character[] enemyCharacter;

    public SkillAttack GetSkill(int index)
    {
        if (index < 0 || index >= skills.Length)
        {
            Debug.LogError("Skill index out of range: " + index);
            return null;
        }
        return skills[index];
    }

    public SkillAttack GetAttack(int index)
    {
        if (index < 0 || index >= attacks.Length)
        {
            Debug.LogError("Attack index out of range: " + index);
            return null;
        }
        return attacks[index];
    }

    public Character GetPlayerCharacter(int index)
    {
        if (index < 0 || index >= playerCharacter.Length)
        {
            Debug.LogError("Player character index out of range: " + index);
            return null;
        }
        return playerCharacter[index];
    }

    public Character GetEnemyCharacter(int index)
    {
        if (index < 0 || index >= enemyCharacter.Length)
        {
            Debug.LogError("Enemy character index out of range: " + index);
            return null;
        }
        return enemyCharacter[index];
    }
}
