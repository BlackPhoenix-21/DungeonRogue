using UnityEditor;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject newGameMenuUI;
    public GameObject startMenuUI;
    public GameObject settingsMenuUI;

    void Start()
    {
        SceneSwitch(4);
    }

    public void SceneSwitch(int index)
    {
        switch (index)
        {
            case 0: // New Game Menu
                mainMenuUI.SetActive(false);
                newGameMenuUI.SetActive(true);
                startMenuUI.SetActive(false);
                settingsMenuUI.SetActive(false);
                break;
            case 1: // Start Menu
                mainMenuUI.SetActive(false);
                newGameMenuUI.SetActive(false);
                startMenuUI.SetActive(true);
                settingsMenuUI.SetActive(false);
                break;
            case 2: // Settings Menu
                mainMenuUI.SetActive(false);
                newGameMenuUI.SetActive(false);
                startMenuUI.SetActive(false);
                settingsMenuUI.SetActive(true);
                break;
            case 3: // Exit Menu
                Application.Quit();
                EditorApplication.Exit(0);
                break;
            case 4: // Main Menu
                mainMenuUI.SetActive(true);
                newGameMenuUI.SetActive(false);
                startMenuUI.SetActive(false);
                settingsMenuUI.SetActive(false);
                break;
            default:
                Debug.LogWarning("Invalid index for SceneSwitch.");
                break;
        }
    }
}
