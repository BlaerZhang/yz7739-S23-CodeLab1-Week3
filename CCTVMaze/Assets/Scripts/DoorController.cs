using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") 
        {
            transform.DOLocalMoveX(2, 1.5f, false).SetRelative(); //if player is near door, it opens
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.DOLocalMoveX(-2, 1.5f, false).SetRelative(); //if player goes away, door closes
        }       
    }
}
