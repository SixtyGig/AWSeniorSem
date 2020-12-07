# VR Training Simulation - Module Based
> What started off as a general Epi-Pen & AED simulation, turned into a more generic baseline for a skill simulation hub. There is a start to an Epi-Pen based module, which involves Educating and Training the student. The future goal is still to complete the Epi-Pen based module with more modules planned prior to release.

## Status
Project is: _in progress_. While the original goal of my senior seminar project was to finish a multi-skill simulation in 300 hours, I've come to the realization that this was an unrealistic goal. Instead, I've turned this into a, "How much can I get done in 300 hours towards this goal." 

## Table of contents
* [Inspiration](#inspiration)
* [Screenshots](#screenshots)
* [Technologies](#technologies)
* [Setup](#setup)
* [Scenes](#Scenes)
* [Features](#features)
* [Status](#status)
* [Contact](#contact)

## Inspiration
My project was started two years ago at in my hometown school district. During a break my Freshman year of college, I met with Dr. Christopher Hibner and we started talking about virtual reality and its advantages in education. He had some expressed interests with integrating advanced technologies into the district...and VR would be one way to achieve that. I proposed that they could move some of their training programs onto the platform, to promote learning (visual, muscle-memory) and technology-based skills with the teachers and students. Chris liked the idea, and then immediately mentioned how he didn’t like their current AED and Epi-Pen training programs, because no physical interaction with those devices were required. This project was derived off of that.

## Screenshots

## Technologies
Software
* Unity3D - Version 2018.4.27f1
* SteamVR's Unity Plugin - Version 2.6.1 (SDK 1.13.10)
* Blender - Version 2.91.0

(Intended) VR Hardware
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

[Main Menu](https://gyazo.com/4738699e68ade3c2f943b7a1969c9b71)

Known Bugs
* Floor lighting sometimes makes textures appear black
* Player height cannot be automatically/manually set, so the experience is currently custom based on my own personal height (6' 5")

### Education
Status: _Work In Progress_
Located: .\EpiAED_SeniorSem\Assets\Scenes\Education

[Education]()

This portion 

### Training
Status: _Work In Progress_
Located: .\EpiAED_SeniorSem\Assets\Scenes\Training

[Training Area](https://gyazo.com/80a9878f9720bc3c663bc56c68affa1a)

Current plan:
1. The student spawns in the room. 
2. On the table infront of the person, there is an EpiPen. The student is to grab it and inject the individual with the epi-pen correctly. 

Next steps for the project:
Located on each of the models (Male and Female) is a set of EpiPen hitboxes (found on the 'pelvis' of each model). Basically if the Epipen's tip collides with these hitboxes and stays there in the person for 3 seconds, this will mark a successful delivery of medication. The next step to the project is to set up this feature. It would be nice if there are other hitboxes that determine if an incorrect injection has been applied (marking a failed training simulation).

## Code Examples

### Global Scripts
Located: .\Epi
`put-your-code-here`

## Features
List of Features
* Awesome feature 1
* Awesome feature 2
* Awesome feature 3

To-do List:
* Continued Module Work (I would like to polish everything down & receive some 3rd party feedback before moving through the modules)
* Either automate student height on start or add a menu to custom-set a student's height
* Find additional help for the graphics/animations/modeling for the project

Eventual Goal: Create a listing on Steam

## Contact
Created by [@sixtygig](https://github.com/SixtyGig) - Feel free to reach out! 
Here's my [LinkedIn](https://www.linkedin.com/in/austinwinkler/) as well. I'm always looking to work on Unity3D based projects. I also love teaching beginners about Unity or development as a whole, so feel free to reach out if you'd like some help!
