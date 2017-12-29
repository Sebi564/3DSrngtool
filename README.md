# 3DS RNG Tool [![Build status](https://ci.appveyor.com/api/projects/status/p58tu8nai3cqexuq/branch/master?svg=true)](https://ci.appveyor.com/project/wwwwwwzx/3dsrngtool/branch/master)

This is an RNG Tool for main 3DS Pokemon games. Some parts should work with [PokeCalcNTR](https://gbatemp.net/threads/pokecalcntr-for-gen-6-the-rng-tool-suite-for-the-3ds.473221/) using NTR-CFW.

This tool is a complete rewrite based off my SMEncounterRNGTool with largely improved performance and the following features:
- Gen6 RNG. including stationary Pokemon, Mystery Gift Pokemon, wild Pokemon(75%), Eggs and ID(90%).
- Transporter RNG for transferred Virtual Console Pokemon.
- Gen7 stationary, Mystery Gift and wild Pokemon RNG from my SMEncounterRNGTool.
- Gen7 egg RNG and ID RNG based on Quandra's [PokemonSunMoonRNGTool](https://github.com/Quandra/PokemonSunMoonRNGTool) 
- More useful tweaks for Gen7 egg RNG.

## User Guide and Useful References

- [Final Screen](#final-screen) you should wait at and make the final key pressing.
- [TinyMT Timeline Setting](https://github.com/wwwwwwzx/3DSRNGTool/wiki/TinyMT-Timeline-Spec-Sheet)
- [Gen7 Timeline Guide](https://github.com/wwwwwwzx/3DSRNGTool/wiki/Gen7-Timeline-Calibration-(PokeCalcNTR-Only))
- [Reddit Gen 6 RNG Megathread](https://www.reddit.com/r/pokemonrng/comments/6fhnb8/gen_6_rng_megathread/)
- [ProjectPokemon Events Gallery](https://github.com/projectpokemon/EventsGallery)
- [NTR Helper and ID Bot Usage](https://github.com/wwwwwwzx/3DSRNGTool/wiki/NTR-Helper-Usage)

## Credit

- Zaksabeast, Zep715, Real96, Admiral Fish and Shiny_Sylveon for great teamworks on gen6 development  
   - Zaksabeast and Admiral Fish for building up the plugin  
   - Real96 for testing and lots of good advice  
   - Zep715 for figuring out tons of infomation from the assembly  
   - Shiny_Sylveon for contributions to Gen6 Egg RNG
  
- Kaphotics for PkHeX and Pk3DS. I borrowed some code from the PKHeX Core Library and extracted ROM info using Pk3DS.
- 44670 for NTRClient.

## Final Screen

Usually it's the last screen before the battle starts, or the special dialogue box.


#### Generation 7

- __In-game gifts/Fossils/Cosmog/Mystery Gift__: _You received xxx!_
- __Tapus__: _Tapu ko-ko-ko-kooo!!! / Ta-pu-leeeh! / Ta-pu-loooo! / Ta-pu-fiiieee!_
- __Solgaleo/Lunala__: No dialogue.
- __Wild UBs, Island Scan & wild Pokemon__: Hover over `Bag` button and press A to enter. The tool will take into account the honey delay for you.
- __Main RNG egg__: _But you want the Egg your Pokemon was holding. right?_
- __Poke Pelago__: Hover over `Poke Pelago` button and press A to enter. Be sure that new Pokemon will be generated when you enter the Poke Pelago.
- __Assembled Zygarde__: _Zygarde has gone into a Poke Ball!_
- __Crabrawler__: _There was a Pokemon feeding on the Berries and it leaped out at you!_
- __Fishing__: 
   - Timer user: Press A when `A` pops up, then pull the fishing rod off water once you hear the sound.
   - PCalc user: Press 1st A when `A` pops up (`fishing`), press 2nd A when the exclamation mark pops up (`frame`).

##### Sun and Moon
- __Pikipek__: No dialogue. Before the fourth step in grass.
- __Exeggutor__: _Ahhh! What is that, xxx?!_
- __Starters__: _Having accepted on another, you'll surely be friends for life._

##### Ultra Sun and Ultra Moon
- __Ultra Wormholes Past-gen Legends/Non-legends__: No dialogue. Save as close as possible, make a step to trigger the battle.
- __Ultra Wormholes UBs__: No dialogue. Press A to trigger the battle.
- __Necrozma__ : _Linooo!_
- __Zygarde at Resolution Cave__: _Zeeehhhd!_
- __Starters__: _You chose xxx!_
- __Grubbin__: No dialogue. Before the fourth step in grass.
- __Totem Pokemon__: _You received xxx!_
- __Gastly__: _The cold thing suddenly attacked you!_
- __Drifloon__: _Flooo!_
- __Hypno__: _The Hypno are upset about being accused!_
- __Bewear__: _Weeeaaarrrr!_
- __Ditto Five__: _Dittoooo!_ / _Di...Ditto-o-o-o-o?!_ / _Dittottotto_ / _Didi!_ / _Ditto!_
- __Sandygast__: _Gaaaaaaaaassstt!!!_
- __Frillish__: _Friiiiilll..._
- __Pinsir__: _Thwak!_ / _Gruh!_ / _Hyah!_
- __Electrode__: No dialogue. Unsable.

#### Transporter (Virtual Console)

- Hover over `Use this game` button. Calibrate the delay beforehand.

#### Generation 6

- __Mystery Gift__: _xxx received xxx!_
- __Pokemon Link__: _Would you like to retrieve data using Pokemon Link? Yes/No_
- __Fossils__: _This is xxx! Please take good care of it._
- __Kalos/Hoenn Starters__: _Choose this Pokemon? Yes/No_
- __Horde__: Honey Selected. USE/GIVE/DISCARD
- __Rock Smash__: _Would you like to use Rock Smash? Yes/No_
- __Fishing__: Register at least two key items to Y menu. Wait at Y shortcut menu. Press arrow key to use the fish rod. TTT calibration required.
- __Eggs__ from Day Care:
   - Accepting => 1st Yes/No Screen: _You do want it. don't you? / You'll be wanting it won't you? / You've gotta want it, right?_
   - Rejecting => the Screen _AFTER_ the 2nd Yes/No Screen: _Well then, I'll hang on to it. Thank you!/ Well then, I'll be having this one! Thanks!/ Really really? Well... I'll keep it, then! Thanks!_
- __ID__ : _xxx... Tres bien! What a fantastic name! / So you're xxx? Yes/No_

##### XY
- __Mewtwo__: _Mew!_
- __Xerneas/Yveltal__: No dialogue.\* Defeat it and rebattle to avoid long delay.
- __Zygarde__: _Zzzz-dddd-aaaaaa!_
- __Kanto Legendary Birds__: No dialogue.\* Press the arrow key to trigger the battle.
- __Pidgey__: No dialogue.\* Wait at the first line of the grass. The encounter will happen at the 2nd row of grass. Press the arrow key to trigger the battle.
- __Kanto Starters__: _You picked xxx. then! I see. That's simply wonderful!_
- __Snorlax__: _Snorlax opened its eyes wide!_
- __Lucario__: _Lucario is staring intently at xxx. Will you take Lucario with you? Yes/No_
- __Lapras__: _Would you mind taking Lapras with you on your journey? Sure!/I coundn't_
- __Berry Tree__: _A Pokemon appeared!_
- __Shaking Trash Can__: No dialogue.\*
- __Cave Drop/Cave Shadow/Dust Clouds/Rustling Bush__: No dialogue.\* Press the arrow key to trigger the battle.

##### Omega Ruby and Alpha Sapphire
- __Portal(Hoopa Ring)__: _Would you like to put your hand deep in the hole? / Would you like to examine it? Yes/No_
- __Soaring Legends__: _Despite that, do you want to fly into the clouds? / Do you want to fly into the gap? Yes/No_
- __Storyline Latios/Latias__: _xxx joined your team!_
- __Eon Ticket Latios/Latias__: _Hyahhn!_
- __Primal Kyogre/Groudon__: No dialogue.\*  (The delay varies from console and save, and should be an odd number)
- __Rayquaza__: _Kiiiryarrrarrrarrrraaaashiiiii!!!_ (Tip: Wait until it finishes its movement)
- __Deoxys__: _The stone tablet before you--!!!_
- __Regirock, Regice and Registeel__: No dialogue.\*
- __Regigigas__: _Zut zutt!_
- __Starters(Gen 2/4/5)__: _Yes, that one from the xxx region._
- __Wurmple__: No dialogue.\* Wait after the second step in grass. The encounter will happen at the 3rd steps in grass. Press the arrow key to trigger the battle.
- __DexNav Poochyena__: _xxx! Over here!_
- __Cosplay Pikachu__: _You'll really, really, really stand out if you two go on stage with matching costumes!_
- __Castform/Sharpedo/Camerupt/Gift eggs(Wynaut/Togepi)__: _xxx recieved xxx._
- __Beldum__: _xxx obtained a Beldum_
- __Spiritomb__: _Shahhh!_
- __Kecleon__: _The startled Pokemon attacked!_
- __Voltorb, Electrode__: No dialogue.\*

##### Tip: 
 \* For consistent delay, use D-pad (arrow keys) to move along grid.  
