﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : Align
{
    // TODO: override Align's getTargetAngle to face the target instead of matching it's orientation
    public override float getTargetAngle()
    {
        Vector3 direction = (target.transform.position - character.transform.position).normalized;

        // --- replace me ---
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * 180/Mathf.PI;
        // ------------------

        return targetAngle;
    }
}
