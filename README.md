# Discord Prescene for Unity

A lightweight Discord Rich Presence plugin for the Unity Editor.

Discord Prescene displays information about your current Unity project and editor state as a Discord Rich Presence.

## Features

- Display Unity project name
- Display active Scene
- Display Unity version
- Display current Editor state
- Display elapsed time
- Custom Rich Presence icons
- Automatically updates Rich Presence while working in Unity

## Requirements

- Unity 2022.3 or later
- Discord Social SDK for Unity
- Discord desktop application

**Tested with Unity `2022.3.22f1`.**

Other Unity versions may work, but have not been tested.

---

## Installation

### 1. Download Discord Prescene

Download the latest `.unitypackage` from the [Releases](../../releases) page.

In Unity, select:

**Assets → Import Package → Custom Package...**

Select the downloaded `.unitypackage` and import all files.

### 2. Install Discord Social SDK

Discord Prescene requires the **Discord Social SDK for Unity**.

The SDK is **not included** with Discord Prescene and must be downloaded separately.

Follow the official Discord Unity guide:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

Download the **Unity Plugin** and import it into your Unity project.

> **Important:** Download the **Unity Plugin**, not the Unity Sample.

### ⚠️ You do NOT need to complete the entire Discord guide

The official Discord documentation contains additional steps for OAuth, authentication, login, and other Social SDK features.

**Do not follow those steps for Discord Prescene.**

You only need to:

**Create a Discord Application → Get the Application ID → Stop.**

Discord Prescene handles the required SDK initialization itself.

You do **not** need to implement:

- OAuth
- Discord login
- User authentication
- Authorization flow
- Other Social SDK features

### 3. Restart Unity

After importing the Discord Social SDK and Discord Prescene, **restart the Unity Editor**.

A restart is required for the plugin and SDK to initialize correctly.

---

## Setup

### 1. Create a Settings Asset

In the Unity Editor, open:

**Tools → Discord Prescene → Create Settings**

This will create a Discord Prescene settings asset in your project.

Select the generated settings asset in the Project window.

### 2. Get your Discord Application ID

Create a Discord Application through the official Discord Developer Portal.

For the official setup instructions, see:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

After creating your application, copy its **Application ID**.

The Application ID is a long numeric value, for example:

```text
123456789012345678
```

Paste this value into the **Application ID** field in the Discord Prescene Settings Inspector.

### 3. Configure Discord Prescene

Select the Discord Prescene Settings asset and fill in the available fields in the Inspector.

Configure the Rich Presence information you want to display, such as:

- Project name
- Scene name
- Unity version
- Editor state
- Details
- State
- Large icon
- Small icon

Save the settings asset after making your changes.

---

## Custom Icons

Discord Prescene supports custom Rich Presence icons.

### 1. Upload an icon to your Discord Application

Open your Discord Application in the Discord Developer Portal.

Go to the **Rich Presence** asset section and upload the image you want to use.

After uploading the image, note its **asset key/name**.

### 2. Enter the asset key

Copy the asset key of the uploaded image.

In Unity, select your Discord Prescene Settings asset and enter the asset key into the corresponding icon field.

For example:

```text
unity
project
editor
```

The asset key must match the asset configured in your Discord Application.

### 3. Restart Unity

After adding or changing Rich Presence assets, **restart the Unity Editor** if the changes are not immediately reflected.

---

## Usage

Once Discord Prescene has been configured, simply open your Unity project while the Discord desktop application is running.

Discord Prescene will automatically update your Discord Rich Presence.

For example:

```text
Editing Unity Project

My Project
Scene: Main
Unity 2022.3.22f1

01:23:45 elapsed
```

The exact information displayed depends on your configuration.

---

## Troubleshooting

### Rich Presence does not appear

Make sure:

- Discord is running.
- Discord Social SDK for Unity is installed.
- Discord Prescene is installed.
- A Discord Prescene Settings asset has been created.
- The correct Discord Application ID has been entered.
- The Discord Application ID belongs to the Discord Application you configured.
- You have restarted the Unity Editor after installation.

### Custom icons do not appear

Make sure:

- The icon has been uploaded to the correct Discord Application.
- The asset key is correct.
- The asset key matches exactly.
- Discord is running.
- You restarted Unity after changing the configuration.

### SDK errors

Make sure you downloaded and imported the **Unity Plugin** rather than the **Unity Sample**.

If you are having problems installing the Discord Social SDK, refer to the official Discord documentation:

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

Remember that Discord Prescene does **not** require the OAuth, authentication, or login steps described later in the official documentation.

---

## License

This project is licensed under the [MIT License](LICENSE).

The Discord Social SDK is a separate third-party dependency and is not included under this project's license.
