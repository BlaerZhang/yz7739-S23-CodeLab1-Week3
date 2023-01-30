using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;

public class EndingTigger : MonoBehaviour
{
    public TextMeshProUGUI endingText; //get UI text
    // Start is called before the first frame update
    void Start()
    {
        endingText.DOFade(0, 0); //set text alpha to 0
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chair")) //if player hit the chair, fade in ending text in 3 seconds
        {
            endingText.DOFade(1, 3);
        }
    }
}
