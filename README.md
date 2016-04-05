Combat Update 1.9

Hang tight, version 1.9 of Minecraft has finally released. The awaited [combat update](http://minecraft.gamepedia.com/Combat_Update) is now ready to download. Experience tons of new features, bug fixes, improvements and all new combat mechanic. This major update has been released on February 29, 2016.
We will guide you through all the changes in this update, in the following section. 

Let's begin with additions. In general there are a lot of new stuff, like attributes, more language support, loot tables, new options in the game, new particle effects and more.

The complete list follows:

#Attributes

* `generic.armor`
	* Measures the amount of protection of armor that is capped at 0 and 30.
* `generic.attackSpeed`
	* Measures attacks per second.
	* Attack speed value is shown as tooltip.
	* Base value is 4.0
		* This value depends on different modifiers that increase or decrease the attack speed attribute. For instance `Swords` have a modifire of -2.4 meaning that the attack speed will be reduced and vice versa. It really depends on what weapon you currently have equipped.
* `generic.luck` Value between -1024 to 1024.
	* It is used when processing [loot tables](http://minecraft.gamepedia.com/Loot_table) with the `quality` or `bonus_rolls` tags. When combined, all these attributes

##Dominant hand option

* A new option with the help of what you can change the dominant hand of the player.
	* It also changes the orientation of the offhand slot in the hotbar.

##Adittional language support

* Added support for Chinese, Japanese and Korean.
* Term [Air](http://minecraft.gamepedia.com/Air) is now translatable to other languages.

##[Loot tables](http://minecraft.gamepedia.com/Loot_tables)

* All loot besides block drops, is now based on loot tables.
	* It can be changed easily by mapmakers by adding a json file in the `WORLD/data/loot_tables` folder.
	* For more information about loot tables see [this](http://minecraft.gamepedia.com/Loot_tables) article.

##[Options](http://minecraft.gamepedia.com/Options)

* Added new volume slider with `Voice/Speech` label under `Music & Sounds`
	* Mapmakers can use this option for voice acting in custom maps.

##[Particles](http://minecraft.gamepedia.com/Particle)

* `sweepAttack`
	* Visible on defensive `swipe` [sword](http://minecraft.gamepedia.com/Sword) attack.
* `dragonBreath
	* Visible on the new attack of the [ender dragon.](http://minecraft.gamepedia.com/Ender_dragon)
* `endRod`
	* Visible on [end rod](http://minecraft.gamepedia.com/End_rod) blocks.
* `damageIndicator`
	* Visible on [mobs](http://minecraft.gamepedia.com/Mobs) when are being hurt.

##[Sound events](http://minecraft.gamepedia.com/Sounds.json#Sound_events)
* New sound event added, as it name says it is supposed to be breath of the player, nontheless it is unused in actual game.
	* `entity.player.breath`

##[Splash text](http://minecraft.gamepedia.com/Splash)

* New splash texts added:
	* "More Digital!"
	* "doot doot"
	* "Falling with style"
	* "There's no stopping the Trollmaso"
	* "Throw yourself at the ground and miss"

##[Statistics](http://minecraft.gamepedia.com/Statistics)

* `sleepInBed` Tracks number of times the player has slept in a bed.
* `sneakTime` Tracks number of [ticks](http://minecraft.gamepedia.com/Ticks) the player has held the sneak key.
* `pickup` Tracks number of [items](http://minecraft.gamepedia.com/Items) that were picked up into the inventory.
* `drop` Tracks number of items that were dropped from the [inventory](http://minecraft.gamepedia.com/Inventory) to the ground.
* `aviateOneCm` Tracks distance glided using [elytra.](http://minecraft.gamepedia.com/Elytra)

##Keyboard shortcuts
* `F3`+`N` toggles between creative and spectator mode.
	* Player needs to have the ability to use `/gamemode`

##[Subtitles](http://minecraft.gamepedia.com/Subtitles)

* More subtitles added even for creepers, for example `Creeper hissing`
	* Two arrows `<` or `>` point to the direction in which the sounds is coming from.

##[World selection screen](http://minecraft.gamepedia.com/World)

* Worlds now display in the version they were last played.
	* Version number will be displayed in red if it has been played in a newer version
* Thumbnails are now displayed per world, showing a glimpse of the world.
* The player can now click on the play arrow displayed on the thumbnail to open the world.
* When the current world is clicked, two new options will be available:
	1. Reset icon: Resets the thumbnail of this world.
	2. Open folder: Opens the folder of this world located in `.minecraft`

#Gameplay

##Combat

* New `attack strength` combat mechanic.
	* A meter shows after switching items or attacking.
		* Damage done depends on the quantity of the meter value.
		* Meter fills at diferent rates depending on the new attack speed attribute.
			* The [haste](http://minecraft.gamepedia.com/Haste) effect will cause the meter to fill faster.
		* Can be displayed next to the hotbar (left or right).
			* Looks like the icon for [strength](http://minecraft.gamepedia.com/Strength)
			* This is controlled in video [settings.](http://minecraft.gamepedia.com/Settings)
	* A cooldown animation is displayed of the [tool](http://minecraft.gamepedia.com/Tool) being lifted up
* Pla sounds when attacked strongly, weakly and parried.

##[Dual wielding](http://minecraft.gamepedia.com/Tutorials/Dual_wielding)
* Players can now use both hands to perform different actions using the left and right mouse buttons.
	* For instance, if a player has a [pickaxe](http://minecraft.gamepedia.com/Pickaxe) in the main hand and a torch in the other hand, right clicking will place the torch.
		* This happens because a pickaxe lacks a right click use.
		* The player cannot click two buttons at the same time.
	* New item switching sound added. 
* Only the main hand can be used for physical attacks.
* [Bows](http://minecraft.gamepedia.com/Bow) choose their arrow type based on the offhand.
	* [Arrows](http://minecraft.gamepedia.com/Arrows) take priority in the offhand than in other hand.
* The offhand model is invisible in first person view.

##[Enchanting](http://minecraft.gamepedia.com/Enchanting)

* Treasure enchantmens
	*  They can only be obtained from chest loot, fishing or trading.
* New treasure enchantment: Frost Walker
	* Turns water into meltable ice.
* New treasure enchantment: Mending
	* Experience collected while holding an item, repairs it instead.

##[Status effects](http://minecraft.gamepedia.com/Status_effect)
* [Glowing:](http://minecraft.gamepedia.com/Glowing)
	* Received when players or mobs are hit by spectral arrows.
	* Player outline now glows.
* [Levitation:](http://minecraft.gamepedia.com/Levitation)
	* Received when player or mobs are hit by [shulker](http://minecraft.gamepedia.com/Shulker) projectiles.
	* Makes player float into the air.
* [Luck](http://minecraft.gamepedia.com/Luck) and [Bad Luck](http://minecraft.gamepedia.com/Bad_Luck)
	* Increases or decreases luck attribute by 1 unit per level.

##[Transportation](http://minecraft.gamepedia.com/Transportation)
* Players can now glide using [elytra.](http://minecraft.gamepedia.com/Elytra)
* Player has now the new `Elytra Control` option.

##[Command format](http://minecraft.gamepedia.com/Command)
Here is a list of new available commands>

* `./time`
	* `/time query` now accepts `day` value, which returns day number.
* `/gamerule`
	* `disableElytraMovementCheck
		* `true` value will cause the server to skip checking whether the player is cheating if moving too fast.
		* `false` is the default value and will force the server to do the checks.
	* `spectatorGenerateChunks`
		* Determins if the player in spectator mode should/should not generate chunks.
		* Default value is `true`.
	* `spawnRadius`
		* Controls how far from the world spawn point players can [spawn.](http://minecraft.gamepedia.com/Spawn/Multiplayer_details)
		* `10` is the default value.

##[World generation](http://minecraft.gamepedia.com/World)

####[Chorus trees.](http://minecraft.gamepedia.com/Generated_structures#Chorus_Tree)

* Generate on the outer islands of the End.
* Tree-like arrangements of the new chorus plant and chorus flower blocks.
* The whole structure is destroyed when the bottom-most block is destroyed, like cacti.
* Can be farmed by planting the chorus fruit flowers that come from the top of the plants, on top of endstone.
	* Unlike cacti, chorus plants do not require the supporting block to be below it, but rather adjacent.
		* This allows the structure to grow around obstacles, like other chorus trees.

These are general additions to the game with this new update. Besides these there are lots of improvements and bug fixes that significantly boosted up the game performance. Grab the update and experience new things to explore in a more advanced combat mechanics. Challenge yourself with new, amazing possibilities. Happy Crafting! :)
