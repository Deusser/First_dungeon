using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player_pos;
    public GameObject SkeletonWarrior;
    [SerializeField] private GameObject _enemyContainer;
    [SerializeField] private List<Transform> _enemyPoints;
    private void Awake()
    {

        foreach (Transform point in _enemyPoints)
        {
            Instantiate(SkeletonWarrior, point.position, Quaternion.identity);

        }
    }
    // Start is called before the first frame update
    void Start()
    {

        string tag = SkeletonWarrior.tag;
        GameObject[] Enemy = GameObject.FindGameObjectsWithTag(tag);



    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey("escape")) 
        {
            Application.Quit();    
        }
    }
}
