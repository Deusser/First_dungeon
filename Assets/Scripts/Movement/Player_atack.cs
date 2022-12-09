using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_atack : MonoBehaviour
{
    public bool Take;
    public Animator sword;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            int F = Random.Range(1, 3);
            sword.Play(F.ToString());

        }
    }
}