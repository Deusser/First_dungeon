using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take : MonoBehaviour
{
    float distance = 3;
    public Transform pos;
    private Rigidbody rb;
    private Fpc_param fpc_;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        fpc_ = GameObject.Find("Player").GetComponent<Fpc_param>();
    }

    private void OnMouseDown()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, distance) && fpc_.Take!=false)
        {
            rb.isKinematic = true;
            fpc_.Take = true;
            rb.MovePosition(pos.position);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.isKinematic == true)
        {
            this.gameObject.transform.position = pos.position;
            if (Input.GetKeyDown(KeyCode.G))
            {
                fpc_.Take = false;
                rb.useGravity = true;
                rb.isKinematic = false;
                rb.AddForce(Camera.main.transform.forward * 500);
            }

        }
        
    }
}
