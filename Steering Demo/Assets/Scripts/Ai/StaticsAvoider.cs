using UnityEngine;
public class StaticsAvoider : Kinematic
{
    Face mySeekRotateType;
    ObstacleAvoidance myMoveType;

    public float lookDistance;
    public float avoidDistance;



    // Start is called before the first frame update
    void Start()
    {
        mySeekRotateType = new Face();
        mySeekRotateType.character = this;
        mySeekRotateType.target = myTarget;

        myMoveType = new ObstacleAvoidance();
        myMoveType.character = this;
        myMoveType.target = myTarget;
        myMoveType.lookahead = lookDistance;
        myMoveType.avoidDistance = this.avoidDistance;
    }

    // Update is called once per frame
    protected override void Update()
    {
        steeringUpdate = new SteeringOutput();
        steeringUpdate.linear = myMoveType.getSteering().linear;
        steeringUpdate.angular = mySeekRotateType.getSteering().angular;
        base.Update();
    }
}
