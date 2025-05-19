using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TMP_InputField nameInputField;

    public void PlayGame()
    {
        string playerName = nameInputField.text;
        if (playerName != "")
        {
            PlayerData.SetPlayerName(playerName);

            SceneManager.LoadScene(1);
        }
    }
}
