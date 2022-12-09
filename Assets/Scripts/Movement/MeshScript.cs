using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MeshScript : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _meshAgent;
    [SerializeField] private Transform [] patrolpos;
    [SerializeField] private int index;

    // Start is called before the first frame update
    void Start()
    {
        _meshAgent.destination = patrolpos[index].position;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(gameObject.transform.position, _meshAgent.destination);
        if (distance < 1f)
        {
            index += 1;
            if (index > patrolpos.Length-1)
            {
                index = 0;
            }
            _meshAgent.destination = patrolpos[index].position;
        }
    }
}
