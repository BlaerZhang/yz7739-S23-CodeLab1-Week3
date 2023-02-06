using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LiftTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator OnTriggerEnter(Collider other) //if player hits the trigger/goes into the lift
    {
        yield return new WaitForSeconds(5); //wait for 5 seconds
        SceneManager.LoadScene(1); //load level 2
    }
}
