using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// w2117030 Matey Mateev
public class BrickTriggerExplode : MonoBehaviour //class constructor
{
    public GameObject brickArray; 
    void Start()
    {

    }

    void Update()
    {

    }
    public void OnMouseDown() //calls this on player click
    {
        brickArray.GetComponent<Animator>().Play("Explode"); //plays the "explode" animation when trigger is clicked
    }
}