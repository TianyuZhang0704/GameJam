# Game Jam  1 - Do Androids Dream of Electric Goat?

You play as an android. Your goal is to kick every green trash bin to the ground level (the green ground). You can push orange cubes. There will be moving platforms and transparent platforms.


## Assets used

Starter Asset: [https://assetstore.unity.com/packages/essentials/starter-assets-third-person-character-controller-urp-196526]
Animated Goat and Sheep: [https://assetstore.unity.com/packages/3d/characters/animals/animated-goat-and-sheep-3d-low-poly-free-251910]
Waste Can PBR: [https://assetstore.unity.com/packages/3d/props/waste-can-pbr-224775]

## Configuration
* Unity Editor: Unity 2021.3.20f1
* Universal RP: 12.1.10
* Animation Rigging: 1.1.1
* Animated Goat and Sheep: 1.0.0
* Starter Assets: 1.1.5
* Waste Can PBR: 1.0

## Features I developed
1. Rewrote the player push object script.
2. Added animation rigging to goats' heads so that they are always looking at the player.
3. Showing message when the player died.
4. Respawn player when the player falls to the ground.
5. Counting the number of trash can pushed and display on the user interface.
6. Destroy the trash can objects when they fall to the ground.
7. Created an animated platform for the player to jump onto it.
8. Created an orange cube for the player to push to the corner and jump onto it. Otherwise the player will not be able to jump to the higher platform (also changed the default jumping arguments for the player in the original asset).
9. Created a transparent platform for the player to figure out how to push the last trash can.
10. Modified the platform to create more challenges for the level design.

## Running the game
Clone this repository and open `GameJam/GameJam1/` folder and a project in unity. Directly play the game in unity game mode.