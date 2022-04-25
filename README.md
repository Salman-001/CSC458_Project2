<h1>CSC458_Project2</h1>

<h2>Objectives:</h2>

<p>To test students’ knowledge of the following Unity topics:</p>

<table>

<tr>
    <td>Movement and rotation in 2D or 3D</td>
    <td>Scriptable Objects</td>
</tr>

<tr>
    <td>Collisions and Triggers</td>
    <td>Saving game data to files (persistence)</td>
</tr>

<tr>
    <td>UI in Unity</td>
    <td>Animations, Animation controllers, Animation events</td>
</tr>

<tr>
    <td>Camera follow/Cinemachine/Cutscenes</td>
    <td>Scene management & Levels</td>
</tr>

<tr>
    <td>Serialization of variables & classes</td>
    <td>Coroutines</td>
</tr>

<tr>
    <td>SFX & Music, Singleton and other design patterns</td>
    <td>Raycasting</td>
</tr>

<tr>
    <td>User Input from the Keyboard and the Mouse</td>
    <td>Navigation meshes, NPCs, AI</td>
</tr>

<tr>
    <td>Particle Systems</td>
    <td>Events and delegates</td>
</tr>

<tr>
    <td>Object Pooling</td>
    <td>Post processing, TDD and GDD</td>
</tr>

</table>

<h2>Technical Requirements:</h2>

<ol>

<li><b>Movement/rotation requirement:</b> For moving, rotating, jumping, crouching etc... your main player, you can use a ready-made character controller/movement script(s) or create your own logic using any movement/rotating method (rigidbody, transform, character controller, Navigation Mesh Agent technique etc..).</li>

<li><b>Levels and Level Design requirement:</b> You must have at least 2 levels that are complete and meaningful according to your genre and according to the theme. I need to see scene management functionality from C# code. Your levels do not have to be massive levels. Design them well and keep things simple and beautiful. Simplicity is beauty! Make sure that you always create an MVP game first then expand later if you have time. You can use anything you want to create your game world.</li>

<li><b>Content of each level requirement:</b> your game must contain buildings, monuments, environment features (Rocky Mountains or forests or medieval castles etc...) that are pertinent to your chosen theme. Models and other assets can be acquired from free resources online as long as you mention their sources. Make sure you choose assets that are compatible with the render pipeline you are working with. Each game level should feature several elements depending on the theme and genre chosen such as ammo pickups, powerups, obstacles, collectibles, and others.</li>

<li><b>NavMesh/Enemies/NPCs requirement:</b> You need to create enemies of some sort depending on the theme that you have choosen. Enemies must decrease your health when they attack you. I am giving you the freedom to decide scenarios of what happens when you die or when you win. For enemies or other Non-Player Characters (NPCs) you must use the NavMesh technique. I need to see some clever behavior in enemies and/or NPCs such as intelligent patrolling, intelligent attacks perhaps when in range or something better than this. It is good to see that you can simulate enemies’ behaviors such being suspicious or dwelling in a certain patrol waypoint for a while and then move on or you can add some random behavior to give the impression that the enemies and/or NPCs are acting intelligently.</li>

<li><b>Camera follow/Cinemachine requirement:</b> the camera must follow the player in a smooth and efficient way. You are advised to use the Cinemachine package, but you can use any other method. I will not force a choice here.</li>

<li>UI requirement: you must have full intuitive meaningful UI. Esthetically pleasing UI will get a higher grade on this requirement. This requirement will flex further your UI muscles, so it is a great opportunity for you to learn new techniques. I need to see: A MainUI Menu, A Settings UI Menu, Instructions/Tutorial UI, A Save UI Menu, An in-game UI, A Pause/Resume UI.</li>

<li><b>Background Music and singleton requirement:</b> You must use a convenient background music (not too loud nor should it be annoying) that could last for all your levels or at least it must last more than 1 level and it should not restart on each level. Choose it based on the theme. You can have voice over if you like in certain parts of the game to add some panache! Consider using the singleton pattern and DontDestroyOnLoad technique which you have learned.</li>

<li><b>SFXs requirement:</b> I need to see a good amount of SFX (sound effects) in your game. SFX should be used in a meaningful way, and you should show that you are manipulating these effects from the C# code.</li>

<li><b>Object pooling requirement:</b> Instantiating and destroying game objects are very handy and essential. However, we want to make sure that your game is performant. You must show me at least once that you have use an object pooling system in your game.</li>

<li><b>Saving system requirement:</b> You need to have a complete functional saving system to disk in your game. You need to save the location/rotation of your player, the score, mana or any other important elements ... in your game depending on your genre. The user should have the ability to load a saved game and resume her play from where the game was saved. You can use playerrefs for saving settings of you game such as the volume, resolution and other things which would load automatically when the game restarts but the main gameplay save should be on disk (i.e. via serialization).</li>

<li><b>Raycasting requirement:</b> Raycasting should be used in your project at least once in a meaningful way to get the full grade of this requirement. Bear in mind raycasting is very useful in games. Raycasting could be used for shooting but not only that. It can be use to move to a location clicked on the world map (such as in RPG, strategy or similar games) or to check that there are obstacles between your player and the enemies or for a million other usage. Show me one usage in code and bob is your uncle!</li>

<li><b>Coroutines requirement:</b> I need to see that you have used coroutines at least once in meaningful way to get the full grade of this requirement. You probably will use more than 1 coroutine. Coroutines are extremely useful. Recall from the lecture on Coroutines that they are used to do tasks that spread over time or across different frames such as dimming slowly a light or fading slowly a color or moving an enemy slowly etc...</li>

<li><b>Animations/Animator Controllers/Animation Events requirement:</b> your main character, all the
enemies and/or NPCs must be animated in a meaningful way. I need to see in C# code that you are manipulating and triggering animations in a meaningful way. I need to see that you are using animation events.</li>

<li><b>Particle effects requirement:</b> Your game should contain particle system(s) in a meaningful way. You have used this in project 1 so this should be easy. Please I need to see that you are controlling the particle system via C# code in order to get the full grade of this requirement.</li>

<li><b>Collisions & triggers requirement:</b> your game must contain good amount of collision logic and triggers. Triggers can be used to set hidden game objects which when you pass though trigger something: turn on/off lights or set an explosion or sound an alarm. It is up to your imagination!</li>

<li><b>Scriptable objects requirement:</b> I need to see you using scriptable objects in your game. Scriptable objects are super useful. They are data containers that store large quantities of shared data independent of class instances. They have many usages: they can populate UI such as inventories, or store information...</li>

<li><b>Events and delegates requirement:</b> I need to see you use delegates and events in your project in a meaningful way. Resources to consult: https://gamedevbeginner.com/events-and-delegates-in-unity/ , https://www.youtube.com/watch?v=VgwP1uXNnCw , https://www.youtube.com/watch?v=k4JlFxPcqlg .</li>

<li><b>Post processing:</b> Post processing is a process that adds image effects that can be applied to change the look of the game (final touches if you like). You must apply at least 1 nice image effect you like to take the full grade of post processing requirement. Pay attention to what render pipeline you choose. Resources: https://www.youtube.com/watch?v=9tjYz6Ab0oc</li>

<li><b>Serialization & game tweaking in inspector requirement:</b> I need to see a good number of serialized variables so that your game can be tweaked easily and efficiently from the Unity Editor (via inspectors) by future game designers. You can create ranges of values and several serialized variables of different types.</li>

<li><b>Coding style/code tidiness requirement:</b> good coding style/usage of comments/DRY code/good overall program hygiene/Correct OOP. Kindly add tooltips to the serialized variables in the inspector to explain briefly what these variables mean so that the TA would understand what your serialized fields do in the Inspector. Add other Unity attributes such as Range or [Header("XYZ")] attribute appropriately etc...</li>

</ol>