using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    //Adding the [SerializeField] before a field makes it available in the Inspector in Unity. I can select the game object to which the script is assigned
    //and the script's section within the Inspector should present the field.
    // [SerializeField] float xValue = 0;
    // [SerializeField] float yValue = 0.01f;
    // [SerializeField] float zValue = 0;

    [SerializeField] float moveSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //'transform' means I am accessing the transform section of the game object. I have moved this script onto the object within Unity - that's how a particular
        //script connects to the particular object.
        //'Translate' needs me to tell it where I want it to go on the x, y and z. But 'Translate' needs to see a number. It won't change the values into the ones
        //I provide here, it will add the provided values to the existing ones. When this is put within Update(), it is performed every single frame. If I want to
        //utilize floating point numbers, I need to put an 'f' behind it.
        //Of course, if I want my game object to move, I need to take a player's input instead of hardcoding values.
        // transform.Translate(xValue, yValue, zValue);

        //'Input' allows me to access the Input Manager within Unity (Edit -> Project Settings -> Input Manager). .GetAxis() allows me to specify which axis I am
        //referring to.
        //'Input.GetAxis("Horizontal")' means that pressing left and right arrow keys (or 'a' and 'd') will set the value of X Axis to either -1 or 1.
        // transform.Translate(Input.GetAxis("Horizontal"), 0, 0);

        //I can store the input in variables. They can't be declared as class' fields because they need to respond to the actions of the player - they need to be
        //updated dynamically. The Y Axis is hardcoded to 0 because I don't want the player to be able to dig or fly.
        // float xValue = Input.GetAxis("Horizontal");
        // float zValue = Input.GetAxis("Vertical");
        // transform.Translate(xValue, 0, zValue);

        //The player's movement should be framerate-independent. In the game screen, in the stats tab, I can see the graphics section with the count of frames per
        //second. The code above means the movement should happen upon the Update which depends on one's computer's speed. It might be 20 FPS on a slow computer and
        //100 FPS on a fast computer which means the player's movement will be different depending on the machine.
        //The solution is using 'Time.deltaTime'. If I use it, Unity can tell me how long each frame took to execute. If I want to move one unity to the left on Update,
        //a slow machine that has 10 FPS, a duration of the frame will take 0.1s. On a fast machine with 100 FPS the duration of the frame is 0.01s.
        //To calculate the distance per second that is going to be the same regardless of the speed of the machine, I take the number of units of movement, multiple it
        //by the FPS AND THEN multiple it by the duration of the frame, so it's 1 x 10 x 0.1 = 1 for the slow machine and 1 x 100 x 0.01 = 1 for the fast one. Both
        //machines get the same result.
        //'moveSpeed' is my custom variable to just speed the movement up a bit.
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue); 
    }
}
