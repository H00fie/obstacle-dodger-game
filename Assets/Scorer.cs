using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    private void OnCollisionEnter(Collision other) {
        hits++;
        Debug.Log("You have bumped into an obstacle " + hits + " times.");
    }
}
