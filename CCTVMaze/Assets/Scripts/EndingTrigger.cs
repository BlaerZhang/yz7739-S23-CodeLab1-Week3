using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;

public class EndingTrigger : MonoBehaviour
{
    private TextMeshProUGUI endingText;
    private bool hitten = false;
    // Start is called before the first frame update
    void Start()
    {
        // endingText.DOFade(0, 0); //set text alpha to 0
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chair")) //if player hit the chair, fade in ending text in 3 seconds
        {
            if (hitten == false) //if not hitten before
            {
                endingText = GameObject.Find("EndingText").GetComponent<TextMeshProUGUI>(); //find TextMeshProUGUI in the scene
                endingText.text = "The End"; //set text in UI
                endingText.DOFade(0, 0); //set text alpha to 0
                endingText.DOFade(1, 3); //text fade in
                hitten = true; //set status to hitten
            }
        }
    }
}
