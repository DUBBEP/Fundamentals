using UnityEngine;

public class ObstacleAvoidance : Seek
{
    public float avoidDistance = 30f;

    public float lookahead = 10f;

    protected override Vector3 getTargetPosition()
    {
        RaycastHit hit;
        if (Physics.Raycast(character.transform.position, character.transform.TransformDirection(Vector3.forward), out hit, lookahead))
        {
            return hit.point + (hit.normal * avoidDistance);
        }
        else
        {
            Debug.Log(" Clearly nothing is there");
            return base.getTargetPosition();
        }
    }
}
