# unity-hud-app

This is an app for controlling your Unity3D via a web page. The web page can be accessed via your computer or mobile phone for prototyping your app experiences.


##Web Setup
#####Download the following to get started
- [Nodejs](http://nodejs.org)
- Click download zip on the right column of the page. This file contains everything you need to get started.

#####Setting up your web server
- Unzip the unity-hud-app 
- Open the 'Web_Files' folder and run the INSTALL app. This will configure your machine for this project and will only need to be run once.
- Run the START app. Every time you want to talk to Unity via your web app, run this first.
- In the 'web-side' folder there is an HTML file in which you can use to configure what you need

##Unity Setup
#####Copy the files from the 'Unity_Files' folder to your Unity project
- If you already have 'Plugins', 'Prefabs' or 'Scripts' folders just copy the files inside the pre-existing folders.

####Copy the OSCReceiver prefab to your project
- This needs to be added to your project heirarchy to work
- Inspecting the 'OSCReceiver' prefab revails some additional options for configuration
- Leave the 'Port' option to 3334 for this demo - our web client is already configured for this
