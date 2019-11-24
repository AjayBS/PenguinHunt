using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class PenguinAgent : Agent
{
    public GameObject heartPrefab;
    public GameObject regurgitatedFishPrefab;

    private PenguinArea penguinArea;
    private Animator animator;
    private RayPerception3D rayPerception;
    private GameObject baby;

    private bool isFull; // If true, penguin has full stomach

    public override void AgentAction(float[] vectorAction, string textAction)
    {
        // Convert actions to axis values.
       
    }
}
