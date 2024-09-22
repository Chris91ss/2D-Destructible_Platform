# 2D Destructible Platform for Unity

## Overview
This Unity asset provides a simple and efficient way to add destructible platforms that disappear and respawn after a set amount of time. Ideal for creating dynamic, interactive 2D platformer games where certain platforms only exist for a short period after being activated by the player.

## Features
- Customizable destruction and respawn timers
- Easy to implement in existing projects
- Flexible design that works with any platform sprite

## Table of Contents
1. [Getting Started](#getting-started)
2. [Installation](#installation)
3. [How to Use](#how-to-use)
4. [Script Overview](#script-overview)
5. [Customization](#customization)
6. [Demo](#demo)
7. [License](#license)

---

## Getting Started
### Prerequisites
- **Unity Version**: Ensure you are using Unity 2019.4 or later.
- **Packages**: No additional packages required.

---

## Installation

1. Clone or download the repository into your Unity project's `Assets` folder.
   ```bash
   git clone https://github.com/Chris91ss/2D-Destructible_Platform.git
   ```
2. Open Unity and refresh your assets to import the script.

---

## How to Use

### Step-by-Step Implementation:

1. **Create a Destructible Platform Object:**
   - Create an empty GameObject named `DestructiblePlatform`.

2. **Set Up the Platform:**
   - Inside `DestructiblePlatform`, create another empty GameObject named `Platform`.
   - Add a **Box Collider 2D** component to `Platform` and set it to **Trigger**.
   - Attach the `DestructiblePlatform.cs` script to the `Platform` object.

3. **Add a Sprite for the Platform:**
   - Create another empty GameObject under `Platform` and call it `Group`.
   - Inside `Group`, add a GameObject with a **Sprite Renderer** to represent your platform and add a **Box Collider 2D** for collision detection.

4. **Adjust the Destruction Timers:**
   - In the Unity Inspector, set values for `timeUntilDestruction` and `timeUntilRespawn` on the `DestructiblePlatform` script:
     - **timeUntilDestruction**: Time (in seconds) before the platform is destroyed after being triggered.
     - **timeUntilRespawn**: Time (in seconds) before the platform respawns after destruction.

---

## Script Overview

Here’s the code for the `DestructiblePlatform.cs` script:

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructiblePlatform : MonoBehaviour
{
    public float timeUntilDestruction;
    public float timeUntilRespawn;

    private GameObject platform;

    private void Awake()
    {
        platform = GameObject.Find("DestructiblePlatform/Platform/Group");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerMovement>())
        {
            StartCoroutine(DisablePlatform());
        }
    }

    private IEnumerator DisablePlatform()
    {
        yield return new WaitForSeconds(timeUntilDestruction);

        platform.SetActive(false);
        StartCoroutine(EnablePlatform());
    }

    private IEnumerator EnablePlatform()
    {
        yield return new WaitForSeconds(timeUntilRespawn);

        platform.SetActive(true);
    }
}
```

### Key Variables:
- **timeUntilDestruction**: Controls how long the platform will remain active after being touched by the player.
- **timeUntilRespawn**: Controls how long it will take for the platform to reappear.

---

## Customization

You can easily adjust the timing values in the **Inspector** to fit your game’s requirements:
- Set a short destruction timer for fast-paced gameplay.
- Increase respawn time for more challenging platforming sections.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request with your improvements.
