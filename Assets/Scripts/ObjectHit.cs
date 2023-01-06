using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    //I don't need Start() nor Update() in this script as I do not want the walls within the game to perform any actions either at the start
    //of the game or along with the passage of frames.
    //The below is another 'callback' so Unity will know that whenever an object this script is attached to (walls) has a collision event
    //taking place (one object's box collider touches their box collider) - the below 'callback' needs to happen.
    //The parameter refers to the object that collided with the walls.
    //As long as the collision box of the player is inside the collision box of the wall, the message will not be repeated. If I move away
    //and drive into the wall again (if the collision boxes were separated), then the message will be dispalyed again.
   private void OnCollisionEnter(Collision other) {
        //I want a wall to change the colour when the player bumps into it. In order to do it, I need to reach for the MeshRenderer. It makes
        //the object look like the Material that was added to it.
        //This is a method of type MeshRenderer. I want to access the material section and then the colour property. Since the property 'other'
        //holds the information of what the object this script is assigned to has collided with, I can refer to that property and make sure
        //the obstacles change their colour only when they've collided with the player (e.g. bombs falling down might collide with the ground
        //object too).
        //Unity allows me to 'tag' objects. It is a property I can refer to here to recognize the object.
        if(other.gameObject.tag == "Player"){
          GetComponent<MeshRenderer>().material.color = Color.cyan;
          //Once the player has bumped into an obstacle, I want it tagged as 'Bonked' so that bumping into it a second time won't increase the
          //score. Every obstacle is to be counted only once.
          //If I refer to a 'gameObject' without adding my parameter ('other') in front of it, Unity will refer to whichever object the entire
          //script is assigned to. In this case it will be all obstacles - all object that are bonkable.
          gameObject.tag = "Bonked";
        }
   }
}
