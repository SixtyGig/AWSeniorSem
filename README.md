# VR Training Simulation - Module Based
> What started off as a general Epi-Pen & AED simulation, turned into a more generic baseline for a skill simulation hub. There is a start to an Epi-Pen based module, which involves Educating and Training the student. The future goal is still to complete the Epi-Pen based module with more modules planned prior to release.

## Status
Project is: _in progress_. While the original goal of my senior seminar project was to finish a multi-skill simulation in 300 hours, I've come to the realization that this was an unrealistic goal. Instead, I've turned this into a, "How much can I get done in 300 hours towards this goal." 

## Table of contents
* [Status](#status)
* [Inspiration](#inspiration)
* [Technologies](#technologies)
* [Setup](#setup)
* [Scenes](#Scenes)
* [Code](#Code)
* [FutureFeatureList](#futurefeaturelist)
* [Contact](#contact)

## Inspiration
My project was started two years ago at in my hometown school district. During a break my Freshman year of college, I met with Dr. Christopher Hibner and we started talking about virtual reality and its advantages in education. He had some expressed interests with integrating advanced technologies into the district...and VR would be one way to achieve that. I proposed that they could move some of their training programs onto the platform, to promote learning (visual, muscle-memory) and technology-based skills with the teachers and students. Chris liked the idea, and then immediately mentioned how he didn’t like their current AED and Epi-Pen training programs, because no physical interaction with those devices were required. This project was derived off of that.

## Technologies
Software
* Unity3D - Version [LTS Release 2018.4.27f1](https://unity3d.com/unity/qa/lts-releases?version=2018.4)
* [SteamVR's Unity Plugin](https://assetstore.unity.com/packages/tools/integration/steamvr-plugin-32647) - Version 2.6.1 (SDK 1.13.10)
* Blender - Version 2.91.0

VR Hardware (Intended)
* HTC Vive Headset
* Valve Index Controllers (though the HTC Vive Wands should work as well)

My Computer Specificatons
* CPU: Ryzen 9 3900X
* GPU: RTX 3070
* RAM: 32GB DDR4-3600

## Setup
To set this project up:
1. Download the latest version of this [repository](https://github.com/SixtyGig/EpiAED_SeniorSem).
2. Make sure you have a VR system attached prior to *opening* the project. 
3. Open the project in Unity3D with version [LTS Release 2018.4.27f1](https://unity3d.com/unity/qa/lts-releases?version=2018.4).
4. Press the play button at the middle-top of the window.

Notes:
* Green book - Demonstrates how items with the "ImportantObject" tag will be teleported back to their original location upon contact with the floor (on either side of the countertop)
* Blue Book - Teleports you to the Education Scene
* Red Book - Teleports you to the Training Scene

## Scenes 
This is a listing of all current scenes in the simulation.

### Main Menu
Status: _Work In Progress_
Located: .\EpiAED_SeniorSem\Assets\Scenes\MainMenu
Screenshot: [Main Menu](https://gyazo.com/4738699e68ade3c2f943b7a1969c9b71)

The student spawns here, can teleport around the behind-the-desk area and can interact with the books. There is a 3D spacial audio point outside the doorway that allows the student to hear the traffic outside (can also visibly see it moving). There also is a computer to the right that contains total completion data and the current system time. 

Known Bugs
* Floor lighting sometimes makes textures appear black
* Player height cannot be automatically/manually set, so the experience is currently custom based on my own personal height (6' 5")

### Education
Status: _Work In Progress_
Located: .\EpiAED_SeniorSem\Assets\Scenes\Education

Screenshot: [Education](https://gyazo.com/d18d5c91c1006aa4748819ca6dc89697)

[Hologram](https://gyazo.com/120d3832d9f8f01f274f0bb4bdd6f1d7)

The Education Scene is where the student learns the textbook knowledge about a particular skill. There is a hologram projection that appears and tells you the knowledge needed to be retained. After the lecture, it prompts you to take the quiz. Upon completing the quiz with a 70% or higher, you will be marked as having passed the educational portion and will be allowed to proceed on to the Training section of the simulation. _The goal is to eventually 'block' the student from having access to the training until the education portion has been sufficiently passed. Currently the Training is made available from the Main Menu at the start_

### Training
Status: _Work In Progress_
Located: .\EpiAED_SeniorSem\Assets\Scenes\Training
Screenshot: [Training Area](https://gyazo.com/80a9878f9720bc3c663bc56c68affa1a)

The student is now given an opportunity to physically practice the skill. Currently as it stands, the activity itself does not do much, but I've done considerable setup towards a working prototype (the hitboxes are setup, it just needs detection).

Current plan:
1. The student spawns in the room. 
2. On the table infront of the person, there is an EpiPen. The student is to grab it and inject the individual with the epi-pen correctly. 

Next steps for the project:
Located on each of the models (Male and Female) is a set of EpiPen hitboxes (found on the 'pelvis' of each model). Basically if the Epipen's tip collides with these hitboxes and stays there in the person for 3 seconds, this will mark a successful delivery of medication. The next step to the project is to set up this feature. It would be nice if there are other hitboxes that determine if an incorrect injection has been applied (marking a failed training simulation).

## Code

### Global Scripts
The player/student's data is being saved to a file via Unity's Serialization method. 

Located: .\EpiAED_SeniorSem\Assets\Scenes\Global\Scripts

PlayerData.cs - The save data control file

[PlayerDataSet.cs](https://gyazo.com/9152fa6c6452bfc44e99c3b1083251da) - The Actual Save File

DoNotDestroyOnLoad.cs - GameObjects with this script attached, will move from scene to scene, instead of being destroyed

## FutureFeatureList
General:
* Continued Module Work (I would like to polish everything down & receive some 3rd party feedback before moving through the modules)
* Find additional help for the graphics/animations/modeling for the project
* Either automate student height on start or add a menu to custom-set a student's height

Main Menu:
* In-Game give the student the ability to change other settings such as **Volume**, **PlayerHeight** and more. The goal is still to keep as much of these "UI elements" as possible in the 3D space (aka, avoiding 2D panel-like options when possible)

Education Scene:
* Flesh out the Epi-Pen training simulation scene with better visuals, hitboxes and quality of life changes (such as access to _some_ settings while not at the main menu)

Training Scene:
* Flesh out the Epi-Pen training simulation scene with better visuals, hitboxes and quality of life changes (such as access to _some_ settings while not at the main menu)

Eventual Goals: 
* Create a listing on Steam

## Contact
Created by [@sixtygig](https://github.com/SixtyGig) - Feel free to reach out! 
Here's my [LinkedIn](https://www.linkedin.com/in/austinwinkler/) as well. I'm always looking to work on Unity3D based projects. I also love teaching beginners about Unity or development as a whole, so feel free to reach out if you'd like some help!
