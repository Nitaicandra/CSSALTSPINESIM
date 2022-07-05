/* Place newest entry at top.
 * 
 * 
 * 7/1/22 DL - after review of Nitai Stephens progress
 * There were a number of problems unrelated to NS work due to SDK bugs and useability.
 * I rotated the US Probe 90 degrees because it was wrong in the SDK. Long term solution requires SDK fix, outside scope of this project. 
 * I unpacked the spine project prefabs completely. Everything here is single instance, prefabs are in the way. We can always create prefabs later.
 * I flipped the 'CSSALTSPINE2' anatomy gameobject 180 degrees. It was placed on wrong side of index plate. 
 * Correct anatomy orientation on index plate not obvious in SDK. Long term solution requires SDK fix, outside scope of this project. 
 * We will give you a new file for ALL anatomy that contains an index plate mesh for alignment; it will also have no walls.
 * I moved the needle to sensor plug #4, thats where it is on our hardware for this particular sim.
 * I created new scene SMMARTS-Test-Scene. No action needed. 
 * I removed the audio listener from the UI Camera. we can have only one in a project or Unity complains.
 * I moved the curvelinear probe gameobject under the normal tracked ultrasound probe gameobject and adjusted the alignment.
 * I added a TUI probe (camera controller) since our sim hardware we are using for this project has one. When adding via CSSALT menu it wiped the index plate and anatomy.
 * I believe opening the CSSALT menu and selecting setup on an existing project introduces errors.
 * (I closed the scene without saving changes so nothing was lost). I pulled in the TUI from SMMARTS-Test-Scene instead. Long term solution requires SDK fix, outside scope of this project. 
 * I tagged the camera 'MainCamera' because the TUI needs a MainCamera.
 * Please remove Vein Collapse console message. this sim will not have veins.
 * Please make the US probe image turn on and off when the probe has contact with the skin. so, the image goes away when the probe is lifted from the skin.
 * the UI camera sometimes shows the anatomy as well as the main camera. I think the UI camera needs a culling mask so it sees only what it needs to see.
 * Create two buttons for Cognitive Aids and Full screen US. The cognitive aids will come later. 
 * Make the full screen US toggle between current small screen US and full screen US using the 'Ultrasound Screen Small and Large Dimensions' gameobjects.
 * make the version # and about look better. colors are a little distracting. you can pick a new background color for the camera too if you like.
 * Make a button for turning the visibility of the skin in the 3D rendering on and off. (Mesh renderer, not the collider if there is one.)
 * Buttons should be on the right side of the screen. We have to reserve room for the Cognitive Aids in the left lower corner.
 * 
 * 
 * 6/29/22 DL
 * create skin without flat sides, replace current skin
 * apply semi-transparent material to skin. pick a color. 
 * use Curvelinear probe. I changed ATC tracked object 2 to the curvelinear probe. 
 * match curvelinear probe's imaging plane to match the dimensions and pic in the email.
 * in ultrasound manager, use curvelinear probe gameobjects under "initialized gameobjects"
 * change width, depth, angle settings to match the shape.
 * click "rebuild" checkbox to update to new settings
 * it helps to make the background color some other color than black temporarily during adjustment.
 * there is a new .fbx in CAD MODELS called "ligamentum flavum". add to the anatomy. it should be automatically aligned because it uses the same coordinate system. if its off and there is no index plate in the model, let us know.
 * add version # to bottom of screen - make a text object and apply BuildDate.cs to it
 * add framerate number to screen - make a text object and apply ShowFPS.cs to it
 * add <about> button with Nitai Stephens at the top. you can make one now or wait for a prefab we use for another project.
 * 
 * 
 * 
 * 
 * 
 * */

