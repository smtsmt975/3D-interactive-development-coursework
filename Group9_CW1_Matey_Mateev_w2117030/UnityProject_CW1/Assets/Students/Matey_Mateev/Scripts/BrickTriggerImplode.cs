using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// w2117030 Matey Mateev
public class BrickTriggerImplode : MonoBehaviour
{
    private GameObject brickArrayT;
    void Start()
    {
        brickArrayT = GameObject.FindGameObjectWithTag("BrickArrayTag"); //finds specific game object with the BrickArrayTag Tag
    }
    void Update()
    {
    }

    public void OnMouseDown()
    {
        brickArrayT.GetComponent<Animator>().Play("Implode"); //When the mouse is clicked on the trigger, plays Implode animation
    }
}