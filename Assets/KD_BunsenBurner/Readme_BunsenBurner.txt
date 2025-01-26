Thank you for purchasing the "Science Lab - Bunsen Burner" pack from KittandaDesign

This is a simple asset pack that contains 6 prefabs from a mesh created by me. 
I have created 2 versions of the mesh, one being 60 percent of the fidelity of the original if you need a lower poly model. 

I have set up the prefabs in the Prefab Folder for you to drag and drop into your scenes. 

Model:
------
Each model is about 160 mm tall, which is the average height of a common Bunsen Burner.

Each model is set up with a parent GameObject and 2 child GameObjects that contain the 2 meshes of the burner. 
The first model is the Bunsen Burner Body.
The second model is the Bunsen Burner Collar and can be rotated to emulate how you would add or remove air from the
burner to make the flame larger or smaller. 
The pivots are baked so that the Main Parent has a pivot at the bottom of the burner (so use that to move the model)
and the collar has a pivot that is centered to it. 

Textures:
---------
3 texture sets were made, a "New", "Old", and "Rusted" one and works with both models.
You can find these sets in the Materials Folder under each of the three names. 
There is also a ForExperience folder that just has some plain materials for the table and floor.

Scripts:
--------

I wrote some very basic scripts to make the example scene work. 

"BurnerTurner"
Attaching this to an object with a collider and setting the tag of the object to "Burner" will 
rotate it when the user hovers the mouse over it. 
You can set the speed of the turning rate in the editor. 
The bool "Hovered" allows the turning to stop when not hovered over.

"Pointer" 
This script is attached to the Controller empty GameObject. 
It fires a ray from the mouse pointer towards the scene to see if it is hovering over something. 
The array "Burners" need to be populated by all objects in the scene with the tag "Burner" if you want
them to be able to stop turning when not hovered over. 

If you have any questions do not hesitate to contact me as I am always happy to create more materials for my 
models or work on commissions!

Hope you have a great day further!
Gerrit

 