# DND5eCombatSim
 App That will simulate combat in the DnD 5e game system. It will also display over all records for characters. 
 
 >Hello, world!


Hello, Zane!
Ill put this in the ReadMe for you to, but just in case Imma write a quick description of what the fuck this app is suppossed to do

Ok so this is going to simulate combat in 5e. There will be a list of characters displayed on the home page. The page will show each character basic stats and their win loss rate. You should be able to create a new character from this page as well<

Each character is clickable and editable, obviously not yet. But eventually :/ When you click on the character it will take you to a page that displays all their stats and you can edit them all. As well as links to their equiped weapon and armor

The characters/weapons/armor are all going to be stored in a LOCAL SQL server. Obviously right now i dont even have sample data, still just figuring blazor out. 

The main event will be the combat page. There you will be able to select 2 characters for your list and thorugh the stats and generating random numbers, will simulate mele combat.

The winner is determined when the other is reduced to zero hit points, obviously not taking into account multi attack, reactions, bonus actions, spells etc at first..... but eventually.
also, when a character is made unconcious, we will increment their total number of games and their win loss rate

eventually it will operate like a pokemon battle, but for now it will just run from start to the point when someone is dropped to zero. Display a "this one Won" message and then a button to go back to the list of characters
maybe let you select characters and go again, but not sure on that yet. And eventually we will have round by round and health bars just like a pokemon battle and a run the entire thing option

