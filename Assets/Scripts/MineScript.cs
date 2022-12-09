using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MineScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("Boom!");
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
