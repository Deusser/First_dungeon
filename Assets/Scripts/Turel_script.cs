using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turel_script : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform Bullet_l;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            GameObject bullet_ins =  Instantiate(bullet, Bullet_l.position, Quaternion.identity);
            Bullet_script b = bullet_ins.GetComponent<Bullet_script>();
            b.SetEnemy(other.gameObject);


        }
    }
    private void OnTriggerStay(Collider other)
    {
        transform.LookAt(other.transform);

    }

}
