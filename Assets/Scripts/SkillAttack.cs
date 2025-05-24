using UnityEngine;

[CreateAssetMenu(menuName = "MyObjects/SkillAttack", fileName = "SkillAttack")]
public class SkillAttack : ScriptableObject
{
    public string basename;
    public string basedescription;
    public int basedamage;
    public int baseuseMP;

    [HideInInspector]
    public string skillattackName, skillattackDescription;
    [HideInInspector]
    public int skillattackDamage, skillattackUseMP;

    public void Rest()
    {
        skillattackName = basename;
        skillattackDescription = basedescription;
        skillattackDamage = basedamage;
        skillattackUseMP = baseuseMP;
    }
}
