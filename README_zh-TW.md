# Discord Rich Prescene for Unity

一個輕量的 Unity Editor Discord Rich Presence 插件。

Discord Prescene 會自動將目前 Unity 專案與 Editor 狀態顯示為 Discord 狀態，也就是 Discord 個人資料上「正在遊玩」的那一欄。

## 功能

- 自動顯示目前 Unity 專案
- 顯示目前開啟的場景
- 顯示 Unity 版本
- 顯示目前 Editor 狀態
- 顯示打開時間
- 支援自訂 Rich Presence 圖標
- 在使用 Unity 時自動更新 Rich Presence

## 系統需求

- Unity 2022.3 或更高版本
- Discord Social SDK for Unity
- Discord APP

**測試用的版本：Unity `2022.3.22f1`**

其他 Unity 版本理論上應該能用，反正我沒試過。

---

## 安裝

### 1. 下載 Discord Prescene

前往 [Releases](../../releases) 頁面下載最新版本的 `.unitypackage`。

在 Unity 中選擇：

**Assets → Import Package → Custom Package...**

選擇下載的 `.unitypackage`，並匯入所有檔案。

### 2. 安裝 Discord Social SDK

Discord Prescene 需要 **Discord Social SDK for Unity**。

SDK **不包含在 Discord Prescene 中**，需要另外從 Discord 官方下載。

請參考 Discord 官方 Unity 教學：

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

下載 **Unity Plugin** 並匯入你的 Unity 專案。

> **注意：** 要下載的是 **Unity Plugin**，不是 Unity Sample。

### ⚠️ 不用完成 Discord 官方教學的全部步驟

Discord 官方文件後續還包含 OAuth、驗證、登入以及其他 Social SDK 功能。

**多做多心酸的，這個腳本根本用不到，所以不要照著官方文檔的後續步驟操作。**

你只需要：

**建立 Discord Application → 取得 Application ID** 就這樣

Discord Prescene 會自行處理所需的 SDK 初始化。

**這些全都不要碰！！**：

- OAuth
- Discord 登入
- 使用者驗證
- 授權流程
- 其他 Social SDK 功能

### 3. 重新啟動 Unity

匯入 Discord Social SDK 和 Discord Prescene 後，**重新啟動 Unity Editor**。


---

## 設定

### 1. 建立設定檔

在 Unity Editor 中開啟：

**Tools → Discord Prescene → Create Settings**

這會在你的專案中建立 Discord Prescene 設定檔。

在 Project 視窗中選擇建立好的設定檔（會自己選擇，但可能有bug）。

### 2. 填入 Discord Application ID

首先建立一個 Discord Application。

建立 Application 的官方教學：

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

建立完成後，複製你的 **Application ID**。

Application ID 是短的那串，長這樣：

```text
123456789012345678
```
不要看錯把公開金鑰給填上去了，那對這個腳本來說沒用

將 Application ID 貼到 Discord Prescene Settings Inspector 中的 **Application ID** 。

### 3. 設定 Icon ID

Discord Prescene 支援自訂的 Rich Presence 圖示。

在 Discord Developer Portal 打開 Discord Application後臺，在 Rich Presence 的Rich Prescene素材那上傳圖片。

上傳後自訂該圖片的 **Asset Key/Name**。

把**Asset Key**填入 Discord Prescene Settings Inspector 的 **Icon ID** 欄位。
不要把Name填進去，SDK不認

例如：

```text
my_icon
```

Icon ID 必須與 Discord Application 中的素材名稱完全一致。

> Discord Prescene 可以設定的項目只有 **Application ID** 和 **Icon ID**。其他 Rich Presence 資訊會由插件根據目前的 Unity Editor 狀態自動產生。

---

## 使用方式

完成設定後，只要在 Discord APP正在執行的情況下開啟 Unity 專案即可。

Discord Prescene 會自動更新你的 Discord Rich Presence。

顯示的資訊會根據目前 Unity Editor 的狀態自動產生，像這樣：

```text
Unity Editor

(專案名稱)
Scene: (場景名稱)
Unity (版本號)

01:23:45
```

---

## 疑難排解

### Discord 沒有顯示 Rich Presence

請確認：

- Discord APP正在執行。
- Discord Social SDK for Unity 已正確安裝。
- Discord Prescene 已正確匯入。
- 已使用 **Tools → Discord Prescene → Create Settings** 建立設定檔。
- Application ID 有填對。
- Application ID 對應到你設定的 Discord Application。
- 安裝完成後已重新啟動 Unity Editor。
- Discord最多只會同時顯示兩個 Rich Presence，你是不是開太多東西了

### 自訂圖標沒有顯示

請確認：

- 圖片已上傳到正確的 Discord Application。
- Icon ID 填寫正確。
- Icon ID 與 Discord 中的 Asset ID / Key 完全一致。
- Discord 桌面版正在執行。
- 修改設定後已重新啟動 Unity Editor。

### SDK 發生錯誤

請確認你下載並匯入的是 **Unity Plugin**，而不是 **Unity Sample**。

如果遇到 Discord Social SDK 安裝相關問題，請參考 Discord 官方文件：

[Discord Social SDK — Getting Started with Unity](https://docs.discord.com/developers/discord-social-sdk/getting-started/using-unity)

請注意，Discord Prescene **不需要**官方文件後續的 OAuth、驗證或登入流程。

---

## 授權

本專案採用 [Apache License 2.0](LICENSE)。

Discord Social SDK 為獨立的第三方依賴，其授權不包含在本專案的 [Apache License 2.0](LICENSE) 中。

Discord Social SDK 版權屬於 Discord Inc.
