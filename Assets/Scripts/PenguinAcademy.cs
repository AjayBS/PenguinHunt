﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MLAgents;

public class PenguinAcademy : Academy
{
    private PenguinArea[] penguinAreas;

    public override void AcademyReset()
    {
        // Get the prenguin areas
        if(penguinAreas == null)
        {
            penguinAreas = FindObjectsOfType<PenguinArea>();
        }

        // Setup areas
        foreach(PenguinArea penguinArea in penguinAreas)
        {
            penguinArea.fishSpeed = resetParameters["fish_speed"];
            penguinArea.feedRadius = resetParameters["feed_radius"];
            penguinArea.ResetArea();
        }
    }
}
