using UnityEngine;

public class Player : MonoBehaviour
{
    private Character character;
    private Inventory inventory;
    void Start()
    {
        character = GameManager.Instance.playerCharacter;
        inventory = new Inventory(6);
    }


}
