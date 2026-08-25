using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using Discord.Sdk;
using System;


[InitializeOnLoad]
public static class DiscordEditorPresence
{
    private static Client client;

    private static DiscordPresenceSettings settings;

    private static double nextUpdate;

    private static bool initialized;


    private static string SettingsPath =
        "Assets/DiscordRichPresence/DiscordPresenceSettings.asset";



    static DiscordEditorPresence()
    {
        EditorApplication.update += EditorUpdate;

        EditorApplication.playModeStateChanged +=
            OnPlayModeChanged;


        Initialize();
    }



    private static void Initialize()
    {
        if(initialized)
            return;


        settings =
            AssetDatabase.LoadAssetAtPath
            <DiscordPresenceSettings>(
                SettingsPath
            );


        if(settings == null)
        {
            Debug.LogWarning(
                "DiscordPresenceSettings.asset not found.\n" +
                "Tools > Discord Presence > Create Settings"
            );

            return;
        }


        if(!ulong.TryParse(
            settings.applicationId,
            out ulong appId))
        {
            Debug.LogError(
                "Discord Application ID invalid."
            );

            return;
        }



        try
        {
            client = new Client();


            client.SetApplicationId(
                appId
            );


            initialized = true;


            Debug.Log(
                "Discord Rich Presence Initialized"
            );


            UpdatePresence();
        }
        catch(Exception e)
        {
            Debug.LogError(
                "Discord init failed:\n" + e
            );
        }
    }





    private static void EditorUpdate()
    {
        if(!initialized)
            return;


        if(EditorApplication.timeSinceStartup
            >= nextUpdate)
        {
            UpdatePresence();


            nextUpdate =
                EditorApplication.timeSinceStartup
                + 10;
        }
    }





    private static void UpdatePresence()
    {
        if(client == null)
            return;


        try
        {
            Activity activity =
                new Activity();



            activity.SetName(
                "Unity Editor"
            );


            activity.SetDetails(
                Application.productName
            );



            string scene =
                "No Scene";


            Scene current =
                SceneManager.GetActiveScene();


            if(current.IsValid())
            {
                scene = current.name;
            }



            string state =
                $"Editing {scene}";



            if(EditorApplication.isPlaying)
            {
                state =
                    $"Playing {scene}";
            }



            activity.SetState(
                state
            );



            ActivityAssets assets =
                new ActivityAssets();



            if(!string.IsNullOrEmpty(
                settings.largeIconKey))
            {
                assets.SetLargeImage(
                    settings.largeIconKey
                );
            }



            if(!string.IsNullOrEmpty(
                settings.smallIconKey))
            {
                assets.SetSmallImage(
                    settings.smallIconKey
                );
            }



            activity.SetAssets(
                assets
            );



            client.UpdateRichPresence(
                activity,
                result =>
                {
                    Debug.Log(
                        "Discord Rich Presence Updated"
                    );
                }
            );

        }
        catch(Exception e)
        {
            Debug.LogError(
                "Discord Presence Error:\n" + e
            );
        }
    }





    private static void OnPlayModeChanged(
        PlayModeStateChange state)
    {
        if(!initialized)
            return;


        EditorApplication.delayCall +=
            UpdatePresence;
    }
}