using UnityEditor;
using UnityEngine;

public static class DiscordPresenceSettingsCreator
{
    private const string Folder =
        "Assets/DiscordRichPresence";

    private const string AssetPath =
        "Assets/DiscordRichPresence/DiscordPresenceSettings.asset";


    [MenuItem("Tools/Discord Presence/Create Settings")]
    public static void CreateSettings()
    {
        var existing =
            AssetDatabase.LoadAssetAtPath<DiscordPresenceSettings>(AssetPath);

        if (existing != null)
        {
            Selection.activeObject = existing;
            Debug.Log("Discord Presence Settings already exists.");
            return;
        }


        if (!AssetDatabase.IsValidFolder(Folder))
        {
            AssetDatabase.CreateFolder(
                "Assets",
                "DiscordRichPresence"
            );
        }


        var settings =
            ScriptableObject.CreateInstance<DiscordPresenceSettings>();

        AssetDatabase.CreateAsset(
            settings,
            AssetPath
        );

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();


        Selection.activeObject = settings;

        Debug.Log(
            "Discord Presence Settings created."
        );
    }


    [MenuItem("Tools/Discord Presence/Delete Settings")]
    public static void DeleteSettings()
    {
        if (AssetDatabase.LoadAssetAtPath<DiscordPresenceSettings>(AssetPath))
        {
            AssetDatabase.DeleteAsset(AssetPath);
            Debug.Log("Discord Presence Settings deleted.");
        }
    }
}