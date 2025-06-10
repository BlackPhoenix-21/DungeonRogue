using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState state;

    public enum GameState
    {
        None,
        MainMenu,
        Start,
        Battle,
        End
    }

    public ObjectSheet objectSheet;
    public Character playerCharacter;
    public Character enemyCharacter;
    public GameObject player;
    public GameObject enemy;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            state = GameState.MainMenu;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        player = GameObject.FindGameObjectWithTag("Player");
        enemy = GameObject.FindGameObjectWithTag("Enemy");
    }
}
