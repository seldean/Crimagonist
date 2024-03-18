# Features

Crimagonist is a Grand Strategy and Simulation game where you and others are doing criminal activities to achieve your own end game focus.
Steal, kill, enlarge, purchase businesses and depots,
manufacture in production lots and send them to depots,
send goods from depots to another place with trucks,
plan heists that will increase national alarm levels,
black mail people or organizations,
extort businesses,
build your group/family/gang/mafia with your own perspective to it,
be a lawyer and get a job in an organization or be a connector who connects "hiring" with "searching" to make them able to start their projects,
be a planner and get a job in an organization to plan their all transportations and big projects like heists,
be an independent hitman to work for organizations or individuals anonimously,
be a lone wolf and work for one time projects until you want otherwise. 

There is many concepts and ideas in Crimagonist:
for example the heist planning needs to be very flexible for players to achieve what they want, and Nodes are the decided solution for this.
What are nodes? Nodes are middle segments in heist planning screen. There is start node and end node, between those you are gonna attach the nodes you think fits. If you want your personnel to swap vehicles before finishing there is a "Swap Vehicle" node with it's own parameters like "from car", "Which personnels numbers" and "To this car" where you can select your purchased vehicles.

## /Assets/Codebase
GameController.cs controls the storages, executes the object's creation methods and more.
[/src/Assets/Codebase/GameController.cs](/src/Assets/Codebase/GameController.cs)

dll directory has usefull classes to use, example:
The OutputController.cs is needed to take the WANTED output from the class and reduce code replaying.
[/src/Assets/Codebase/dlls/OutputController.cs](/src/Assets/Codebase/dlls/OutputController.cs)

The Main directory is mostly unrelated to Unity. Has most of the C# code.
[/src/Assets/Codebase/Main](/src/Assets/Codebase/Main)

IMPORTANT Main Objects from the game like characters and organizations, also their storages to use in runtime:
[/src/Assets/Codebase/Main/Objects](/src/Assets/Codebase/Main/Objects)

DateNTime is in-game time controller.
[/src/Assets/Codebase/Main/DateNTime](/src/Assets/Codebase/Main/DateNTime)

Notifications directory has the Messages.cs controlling mails, job invites, pop-up notifications.
[/src/Assets/Codebase/Main/Notifications/Messages.cs](/src/Assets/Codebase/Main/Notifications/Messages.cs)

The Menu directory is only for menu scene codes.
[/src/Assets/Codebase/Menu](/src/Assets/Codebase/Menu)
