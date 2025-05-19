using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public static string PlayerName;

    public static string GetPlayerName()
    {
        return PlayerName;
    }

    public static void SetPlayerName(string name)
    {
        PlayerName = name;
    }
}
