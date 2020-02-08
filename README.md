# Base Defense Save Editor

A save editor for Base Defense, a Half-Life 1 mod.

This tool allows server operators to view and/or modify a player's data. You can change the player's class, level, starting wave, money and so on. You can also modify the weapons, tasks, upgrades, inventory, etc.

The purpose of this tool is to add replay value by letting players experiment with the game's numbers. You are free to set ridiculous values just to see how would it look like in-game, or build yourself a challenge by starting at high waves on lower levels. Entertainment! Use your imagination.

The second purpose is research, you can use the very numbers to help you analyze how the game works, and (hopefully) futher modify the mod.

## How to use

Base Defense keeps all save files on **\steamapps\common\Base Defense\bdef\save**

When you open the program and click on "Open File", it will try to automatically redirect you to said location, but only if Steam is installed on the C drive, and you do not install your games on an external folder. If these criteria are not met, you will have to provide the directory containing the save files every time you want to modify them.

Inside that folder you will see even more folders that are named after the maps the players play. For example, playing on pve_tomb will generate a folder named pve_tomb.

Now you'll see a bunch of apparently nonsensical numbers with a .sav extension. These are the save files.

The numbers of the file name are actually the player's steamID64 number. Because of this, unless you are not hosting a very crowded server, it's nigh-impossible to easily idenfity which player is who.

At the end of the filename you will see an underscore and a number. For example: XXXXXXXXXXXXXXX_0.sav or XXXXXXXXXXXXXXX_1.sav. These are the character slots. As you can see, they start from zero, so _0 means the first character slot.

Having finished the boring explanation of stuff that you probably already know: **TLDR: You just open a save file and start editing stuff.** The usage of the program should be self-explanatory, just change values and click "Save File" once you are done.

As a good practice, always keep a copy of the original save file before making changes to it.

## F.A.Q.

### What is this "Underworld" mode?

The underworld mode is an unreleased game mode containing only zombies. To access this game mode: Start your server, enter *mp_mode 2* into the console, then restart the map.

You are now in underworld.

### Why I can't edit the upgrades of X weapon?

You cannot edit the upgrades of a weapon that the player does not have. Add them first by using "Edit Weapons".

### The Flamethrower seems to be missing from the upgrades list.

Although there is data in the save file that stores this weapon upgrades, editing them has no effect whatsoever in-game. That's why is omitted, so you don't see a dialog box with "No effect" written all over it.

### A weapon upgrade has a maximum of 0, yet it can be modified. I'm confused!

A maximum of 0 means: That specific upgrade cannot be done through normal means, yet changing it with the editor has it's effect in-game. For example, the python weapon has a max ammo upgrade of 0, yet, if you increase the number you will see in-game that the maximum clip ammo capacity has increased. This also applies true to weapons that do not appear in the in-game upgrades menu, such as the Meele weapon or Shock Rifle.

### You can cheat the "Hero" achievement with this. &@#? you!

~~You cannot reach level 90 legally anyway so who cares.~~ Actually, it is possible to legally reach the maximum level in the underworld mode with ease, but this mode is not oficially released so it doesn't count. Trying in other gamemodes however requires you to be lucky with the RNG to have a flamethrower (or have Igniting bolts, althrough that's much slower), and you must be Rushing class with the 100% damage reduction upgrade. It's the ONLY LEGAL WAY to get the achievement.

YOU CAN'T OTHERWISE. Impossible to get that far enough normally to reach that level. One word: Houndeyes. Even with a 99% damage reduction on softcore, they still instakill.

That's bullshit.

As a bonus point, even you SOMEHOW where to reach level 90, the game does NOT know what to do afterwards! The total XP on your character will immediately jump to 541,996,392 XP, which is theorically **Level 91**. The game does not know how to handle such data, and so, the next time you want to continue from your glorious max level character, the game will be permanently stuck once it tries to read the save file contents. The only way to fix it (if you don't have this editor) is to delete the save file. Yay bugs!

### Why open source?

Simply put, information is meant to be free. Also, I believe that the game needs to allow extensive modifications in order to bring it back to life. Because, let's admit it: This game is fun and all, but it gets stale very quickly.

### The interface sucks!

I don't blame you for it. I built this program to learn the very basics of .NET and C#. Once I finish the proyect (Edit ammo and skill upgrades) I will start focusing on the UX/UI so it's more appealing.

### The coding sucks!

Again, I don't blame you. Being a novice programmer myself I'm bound to write horrendous code. One day I will clean up the code and remake it.

### Can i haz Atheist achievement with dis? :3

No.

Even I don't know how to get that achievement.
