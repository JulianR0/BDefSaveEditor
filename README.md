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

The numbers of the file name are actually the player's steamID64 number. Depending on how many files are inside the folder, it might or might not be a hazzle to find players with those numbers.

At the end of the filename you will see an underscore and a number. For example: XXXXXXXXXXXXXXX_0.sav or XXXXXXXXXXXXXXX_1.sav. These are the character slots. As you can see, they start from zero, so _0 means the first character slot.

Having finished the boring explanation of stuff that you probably already know: **TLDR: You just open a save file and start editing stuff.** The usage of the program should be self-explanatory, just change values and click "Save File" once you are done.

As a good practice, always keep a copy of the original save file before making changes to it.

## F.A.Q.

### I can't start the editor.

The editor requires .NET Framework 4.5. Install it on your computer in order to run this tool.

### What is this "Underworld" mode?

The underworld mode is an unreleased game mode containing only zombies. To access this game mode: Start your server, enter *mp_mode 2* into the console, then restart the map.

You are now in underworld.

### Upgrades are not how I remember them...

The old "Weapon Upgrades" has been temporalily disabled. This new update introduced tier upgrades, which are accessible from the "Weapons" menu.

### Disabled, does that mean it can still be accessed via save tinkering?

It could be posible that the code that handles the old weapon upgrades is still present into the game, but any data referencing them has been removed from the save file. Meaning it is not possible to re-enable the old weapon upgrades with this tool.

### Why do I lose the money I added from here?

The amount of money you can hold on your character is now tied to your level. For your first 10 levels, you can hold a maximum of $5000. As your level increases, this limit will go up to fit later waves.

### You can cheat the "Hero" achievement with this. &@#? you!

On older days, I would say: ~~You cannot reach level 90 legally anyway so who cares.~~ Times have changed. Base Defense got an update that now made this possible to achieve.

So yes, I agree with you. You can just edit your level to 89 then climb your way to the final ladder, and call it a day. But in the end, complaining that you can do this with this tool is the same as complaining that S.A.M. exists. Yeah, you know what program I'm talking about.

Look, I get it. Reaching level 90, even if now humanly possible, is still a tedious and time-consuming task. Perhaps it was intended to be that way, it's not meant to be an achievement you can get easily. But I did not create this tool for that purpose.

Tools by itself are neither good or bad, it's the person wielding it that decides how said tool should be used.

### Why free software?

Simply put, information is meant to be free. Also, I believe that the game needs to allow extensive modifications in order to bring it back to life. Because, let's admit it: This game is fun and all, but it gets stale very quickly.

### The interface sucks!

I don't blame you for it. I built this program to learn the very basics of .NET and C#. I might focus on a better interface in the future, but can't make any promises.

### The coding sucks!

Again, I don't blame you. Being a novice programmer myself I'm bound to write horrendous code. Might fix it one day, but keep your expectations low.

### Can i haz Atheist achievement with dis? :3

Yes, but I'm not telling you how.

It's supposed to be a hidden achievement, after all.
