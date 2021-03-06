using UnityEngine;
using UnityEngine.AI;

public class Formation : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    public Vector3 pos;
    public Quaternion rot;
    public Vector3 relativeTo;
    public Moves moves;

    void Start()
    {
        transform.rotation = target.transform.rotation;
        transform.position = target.transform.TransformPoint(pos + relativeTo);
    }

    void Update()
    {
        if (!moves.found)
        {
            transform.rotation = target.transform.rotation;
            agent.destination = target.transform.TransformPoint(relativeTo);
        }  
    }
}