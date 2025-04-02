# TIX
Custom variation of space empire board game Twilight Imperium
Organization of classes:
Menu contains the objects normally used in the lobbies and game creation/navigation:
List of ongoing games
Ability to enter an active/ongoing game (if player is playing in it)
Ability to create a game
Ability to Observe active games?
Stats
Achievements
Friends - Add Friends
About - Version

Each Game contains the following:
Board
1-6 Players

Each Player contains the following:
Public, Private, Shareable game pieces including:
Race
Counters: Trade goods
Units: Ships, Structures, Ground Forces, (Fuel, Sustenance, Finances)
Cards: Planet cards, Action cards, secret objective cards,technology cards

Race contains:
Special tech
Unique ID for identification during game steps and resolutions
Unique counters, units, etc.

=====Architecture organization:=====
Code laid out in MVVM pattern:
View: XAML (MainWindow.xaml)
ViewModel: C# code behind (MainWindow.xaml.cs))
Model: C# classes (Game.cs, Player.cs, etc. Game.cs holds object data for game instances (which auth-token is which race), Player.cs hols object data for player instances (who is which auth-token)

=====Program flow:=====
Login:
//Associate remote connection to specific player auth-token (should be secured in some fashion TBD)
//If no auth-token, create new player auth-token and receive player ID and password (player ID is unique, password is not)
Start MainMenu():
//TODO
////Display main menu options:
////Create/Find new game
//    //Rules/Packages to use
//    //Points to play to
//    //Race selection
//    //Map preset, drafting placement, random, generation rules, etc.
//    //Secret objective selection
//    //Public objective reveal
//    //Race starts setup (units for home system planets, starting tech choices, etc.)
//    //Select random speaker
//        //Action Phase:
//            //Iterate non-passed players
//            //Perform 1 action or pass if all strat cards for player are used
//            //End of round
//        //Agenda Phase:
//            //Draw 2 agendas
//            //Vote on agendas
//            //Agenda resolution
//            //End of round
//        //Status Phase:
//            //Score objectives
//            //Draw action cards
//            //Refresh planets
//            //Draw and redistribute command tokens
//            //Pass speaker token
//            //Check for game end
//            //End of round
////Active Games (Turn Ready!)
//    //Display list of current participating games
//    //Sort by games waiting for your turn first (Indicate active player turn for each)
//    //Game settings
////Settings
//    //Shortcuts/hotkeys
//    //Theme style
//    //Username
//    //Race Tylesets

=====Card Types:=====
Card base class:
Contains Front, Back, an Owner (Or none if public card on board), ShareWith List (players who can view front of card), and operations to show/share with players

Strategy Card:
Sets front and back based on which strategy card is constructed
Assigns the method operation called/used when the card is played 
	(Secondary ability is played for each player in game as part of this action when played)
Contains name
Contains primary ability description
Contains secondary ability description

Tech Card:
Sets front and back based on which tech card is constructed
Assigns the method operation called/used when the card is played
Contains a requirement list of tech colors needed to purchase (Red,Green,Yellow,Blue)
Contains color type (Red,Green,Yellow,Blue)
Contains name
Contains description

Unit Card:
Sets frong and back based on which unit card is constructed
Assigns the method operation called/used when the card is played
Contains a requirement list of tech colors needed to purchase (Red,Green,Yellow,Blue)
Contains Unit Type
Contains Unit stats (Cost, Combat, Movement, Capacity, etc.)
Contains name 
Contains description

Planet Card:
Sets front and back based on which planet card is constructed
Contains specialty type if present (Red,Yellow,Green,Blue)
Contains Resource Value
Contains Influence Value
Contains Planet Type (Hazardous, Industrial, Cultural, etc.)
Contains Name
Contains Flavor Text (optional)

Action Card:
Sets front and back based on which action card is constructed
Assigns the method operation called/used when the card is played
Contains name
Contains description

