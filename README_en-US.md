# Discord Rich Presence for Unity

> **Note:** This README is a translated version of the main Traditional Chinese documentation. Please refer to the [Traditional Chinese README](README_zh-TW.md) for the latest and authoritative documentation.

A lightweight Discord Rich Presence plugin for the Unity Editor.

This plugin automatically displays information about the current Unity project and Editor state as a Discord status, shown in the "Playing" section of your Discord profile.

## Features

- Automatically displays the current Unity project
- Displays the currently active Scene
- Displays the Unity version
- Displays the current Editor state
- Displays elapsed time
- Supports custom Rich Presence icons
- Automatically updates Rich Presence while using Unity

## Requirements

- Unity 2022.3 or later
- Discord Social SDK for Unity
- Discord desktop application

**Tested with Unity `2022.3.22f1`.**

Other Unity versions may work, but have not been tested.

---

## Installation

### 1. Download the Plugin

Go to the [Releases](../../releases) page and download the latest `.unitypackage`.

In Unity, select:

**Assets → Import Package → Custom Package...**

Select the downloaded `.unitypackage` and import all files.

### 2. Install Discord Social SDK

Discord Presence requires the **Discord Social SDK for Unity**.

The SDK is **not included with this plugin** and must be downloaded separately from Discord.

Please refer to the official Discord Unity guide:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

Download the **Unity Plugin** and import it into your Unity project.

> **Note:** Download the **Unity Plugin**, not the Unity Sample.

### ⚠️ You Do Not Need to Complete the Entire Discord Guide

The official Discord documentation includes additional steps for OAuth, authentication, login, and other Social SDK features.

**You do not need any of these steps for this plugin, so do not follow the later steps in the official documentation.**

You only need to:

**Create a Discord Application → Get the Application ID. That's it.**

This plugin handles the required SDK initialization automatically.

**Do not configure any of the following:**

- OAuth
- Discord login
- User authentication
- Authorization flow
- Other Social SDK features

### 3. Restart Unity

After importing the Discord Social SDK and the plugin, **restart the Unity Editor**.

---

## Setup

### 1. Create the Settings Asset

In the Unity Editor, open:

**Tools → Discord Presence → Create Settings**

This will create a settings asset in your project.

Select the generated settings asset in the Project window.  
(It should be selected automatically, but there may be bugs.)

### 2. Enter the Discord Application ID

First, create a Discord Application.

For the official instructions on creating an Application:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

After creating the Application, copy your **Application ID**.

The Application ID is the shorter numeric value, for example:

```text
123456789012345678
```

Do not accidentally enter the **Public Key**. It is not required by this plugin.

Paste the Application ID into the **Application ID** field in the Discord Presence Settings Inspector.

### 3. Configure the Icon ID

Discord Presence supports custom Rich Presence icons.

Open your Discord Application in the Discord Developer Portal and upload an image to the Rich Presence assets section.

After uploading the image, configure the **Asset Key/Name** for the image.

Enter the **Asset Key** into the **Icon ID** field in the Discord Presence Settings Inspector.

**Do not enter the Name. The SDK does not use it.**

The Icon ID must match the asset name configured in your Discord Application.

> The only configurable values provided by the plugin are **Application ID** and **Icon ID**. All other Rich Presence information is automatically generated based on the current Unity Editor state.

---

## Usage

Once the setup is complete, simply open your Unity project while the Discord desktop application is running.

The plugin will automatically update your Discord Rich Presence.

The displayed information is automatically generated based on the current Unity Editor state, for example:

```text
Unity Editor

(Project Name)
Scene: (Scene Name)
Unity (Version)

01:23:45
```

---

## Troubleshooting

### Discord Rich Presence Does Not Appear

Please make sure:

- The Discord desktop application is running.
- Discord Social SDK for Unity is installed correctly.
- The plugin has been imported correctly.
- A settings asset has been created using **Tools → Discord Presence → Create Settings**.
- The Application ID is correct.
- The Application ID belongs to the Discord Application you configured.
- You have restarted the Unity Editor after installation.
- Discord can only display two Rich Presences at the same time. Are you running too many applications?

### Custom Icon Does Not Appear

Please make sure:

- The image has been uploaded to the correct Discord Application.
- The Icon ID is correct.
- The Icon ID exactly matches the Asset ID / Key configured in Discord.
- The Discord desktop application is running.
- You have restarted the Unity Editor after changing the settings.

### SDK Errors

Make sure you downloaded and imported the **Unity Plugin**, not the **Unity Sample**.

If you encounter problems with the Discord Social SDK installation, please refer to the official Discord documentation:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

Please note that Discord Presence **does not require** the OAuth, authentication, or login steps described later in the official documentation.

---

## License

This project is licensed under the [Apache License 2.0](LICENSE).

The Discord Social SDK is a separate third-party dependency and its license is not included under this project's [Apache License 2.0](LICENSE).

The Discord Social SDK is copyrighted by Discord Inc.