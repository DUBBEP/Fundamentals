using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Separator : Kinematic
{
    Separation myMoveType;
    Align myRotateType;

    // Start is called before the first frame update
    void Start()
    {
        myMoveType = new Separation();
        myMoveType.character = this;
        myMoveType.targets = FindObjectsOfType<Kinematic>();

        myRotateType = new Align();
        myRotateType.character = this;
        myRotateType.target = myMoveType.targets[0].gameObject;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = myRotateType.getSteering().angular;
        
        Debug.Log(steeringUpdate.linear);
        
        base.Update();
    }
}
