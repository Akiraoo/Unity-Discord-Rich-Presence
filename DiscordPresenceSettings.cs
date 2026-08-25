using UnityEngine;

public class DiscordPresenceSettings : ScriptableObject
{
    public string applicationId = "";

    [Header("Discord Developer Portal Icon Keys")]
    public string largeIconKey = "";
    public string smallIconKey = "";
}