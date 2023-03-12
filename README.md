# 2D-Destructible_Platform
## A simple way to add destructible platforms that respawn after a set amount of time to your 2D game.



## How to use it in your own project:

- Step 1: -Create an empty game object named "DestructiblePlatform"  
- Step 2: -Create an empty game object named "Platform" and make it a child of "DestructiblePlatform"  
          -Add a box collider 2D and set it as Trigger  
          -Add the DestructiblePlatform script to it  
- Step 3: -Create an empty game object named "Group" and make it a child of "Platform"  
          -Create an empty game object and add a sprite renderer to it (this will hold your platform sprite) and a Box Collider 2D, after make it a child of "Group"  
- Step 4: -Set the timers in the inspector on the DestructiblePlatform script  
          -The variable timeUntilDestruction will determine how long it will take after the player collided with the platform for it to destruct  
          -The variable timeUntilRespawn will determine how long it will take for the platform to respawn after it was destroyed   

