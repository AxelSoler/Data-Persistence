using UnityEngine;

public class SaveSystem : MonoBehaviour
{
    public static void SavePlayer(string name, int score)
    {
        PlayerPrefs.SetString("name", name);
        PlayerPrefs.SetInt("score", score);
    }

    public static string LoadPlayerName()
    {
        return PlayerPrefs.GetString("name");
    }

    public static int LoadScore()
    {
        return PlayerPrefs.GetInt("score");
    }
}
