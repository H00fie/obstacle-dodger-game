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
        Debug.Log("Bumped into a wall!");
   }
}
