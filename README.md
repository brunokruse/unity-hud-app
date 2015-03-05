# unity-hud-app
App for controlling Unity3D via socket connection


##Web Setup
####001 Download Nodejs
http://nodejs.org

####002 Run the INSTALLER app
This only needs to be done once to configure your machine.

####003 Run the START app
Every time you want to talk to Unity via your web app, run this first.

##Unity Setup
####001 Copy the files from the 'Unity_Files' folder to your Unity project
- If you already have 'Plugins', 'Prefabs' or 'Scripts' folders just copy the files inside there.

####002 Copy the OSCReceiver prefab to your project
- This needs to be added to your project heirarchy to work
- Inspecting the 'OSCReceiver' prefab revails some additional options for configuration
- Leave the 'Port' option to 3334 for this demo - our web client is already configured for this
