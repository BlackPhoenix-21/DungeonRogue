using System;
using UnityEngine;

[CreateAssetMenu(menuName = "MyObjects/Chracter", fileName = "Character")]
public class Character : ScriptableObject
{
    public string basename;
    public int baseHP;
    public int baseMP;
    public int[] baseSkillsPos;
    public int[] baseAttackPos;
    public int[] stats = new int[4];
    public int description;

    [HideInInspector]
    public string characterName;
    [HideInInspector]
    public int characterHP, maxHP, characterMP, maxMP, level, experience;
    [HideInInspector]
    public SkillAttack[] skills, attacks;
    [HideInInspector]
    public int[] characterstats;

    public void Rest()
    {
        characterName = basename;
        characterHP = baseHP;
        maxHP = baseHP;
        characterMP = baseMP;
        maxMP = baseMP;
        skills = new SkillAttack[baseSkillsPos.Length];
        for (int i = 0; i < baseSkillsPos.Length; i++)
        {
            skills[i] = GameManager.Instance.objectSheet.GetSkill(baseSkillsPos[i]);
        }
        attacks = new SkillAttack[baseAttackPos.Length];
        for (int i = 0; i < baseAttackPos.Length; i++)
        {
            attacks[i] = GameManager.Instance.objectSheet.GetAttack(baseAttackPos[i]);
        }
        characterstats = new int[stats.Length];
        for (int i = 0; i < stats.Length; i++)
        {
            characterstats[i] = stats[i];
        }
    }

    public void ChangeSkill(int index, SkillAttack newSkill)
    {
        if (index < 0 || index >= skills.Length)
        {
            Debug.LogError("Skill index out of range: " + index);
            return;
        }
        skills[index] = newSkill;
    }

    public void ChangeAttack(int index, SkillAttack newAttack)
    {
        if (index < 0 || index >= attacks.Length)
        {
            Debug.LogError("Attack index out of range: " + index);
            return;
        }
        attacks[index] = newAttack;
    }

    public void UseSkill(int index)
    {
    }

    public void UseAttack(int index)
    {
    }

    public void TakeDamage(int damage)
    {
        characterHP -= damage / stats[1];
        if (characterHP < 0)
        {
            characterHP = 0;
        }
    }

    public int GetXpForLevelUP(int level)
    {
        return Mathf.RoundToInt(100 * Mathf.Pow(level, 1.5f));
    }

    public void XP(int newXP)
    {
        experience += newXP;
        do
        {
            experience -= GetXpForLevelUP(level);
            level++;
            // IncreaseStats
        }
        while (experience >= GetXpForLevelUP(level));
    }
}
