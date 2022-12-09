using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonWarrior : MonoBehaviour
{
    [SerializeField] private GameObject player_pos;

    private void Awake()
    {

    }
    void Start()
    {
    }

    void Update()
    {
        transform.LookAt(player_pos.transform);

    }
}
