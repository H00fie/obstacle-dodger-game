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
        float xValue = Input.GetAxis("Horizontal");
        float zValue = Input.GetAxis("Vertical");
        transform.Translate(xValue, 0, zValue);
    }
}
