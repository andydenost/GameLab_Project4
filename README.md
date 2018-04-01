**Game Technologies Lab**

**Haoyun Li**

**Fourth Project – How to realize multi-player game**

**Why I want to do this project?**

Recently, when I do research on Three.js library, I found an example of a first
person shooting game. It’s like Counter Strike, but easier and more fun. It’s a
multiplayer game, anybody could join in the game. There is no team, everybody
fights for himself. The rank of players was ordered by killing number. The best
killer ranks the first. You don’t know when and where a new player joins in. I
think I can realize this type of game by Unity. However, the first step is how
could I run this game in the mode of multi-player. That why I want to do this
project.

**The process of exploration**

I never made multi-player game before. So I google it on the Internet. Most of
the answers mention UNet. It a model develop these years by Unity. With UNet, we
could create multi-player game easier than before.

**The process of doing project.**

-   Objective: making a game about finding your friend in the maze. If you touch
    your friend, the screen will show the text “You find your friend”.

-   Create the maze by using planes and cubes, plane for floor, cubes for walls.

-   Create a new empty object, add Network Manager to it.

-   For more convenient for testing, I also add NetworkManagerHUD to it.

-   Create a cylinder, it is the player, set it local player authority.

-   Create a script, Change the inherit parent from MonoBehaviour to
    NetworkBehaviour. Write moving function and OnCollisionEnter function into
    it, attach it to the player. Make it becomes prefabs, delete it in the
    Hierarchy.

-   Add player transform to the player, and I add a line of codes in the start
    function. It is using to put player at random position in the maze at the
    beginning of game.

-   Attach the player to Network Manger at player prefabs in Spawn info.

-   Add UI text in the canvas.

-   Test the game by build and run, and also run the Unity testing window. One
    press Host button, the other press Client button.

**The result**

The two players were born at different places. When they “met”, the screen
showed “you find your friend”. UNet work fine.

**Citation:**

<https://forum.unity.com/threads/unity-5-unet-multiplayer-tutorials-making-a-basic-survival-co-op.325692/>

<https://docs.unity3d.com/560/Documentation/Manual/UNet.html>
