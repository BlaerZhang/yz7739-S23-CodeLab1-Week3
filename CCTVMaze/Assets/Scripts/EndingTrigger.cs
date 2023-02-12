using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;
using System.IO;

public class EndingTrigger : MonoBehaviour
{
    private TextMeshProUGUI endingText;
    
    private bool hitten = false;

    private string systemLog =
        System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Denied" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Ipconfig Smart Plug B09HPW" + "     Permitted" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Ping 192.168.122.235/24" + "            Permitted" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      Request WebCam Permission" + "      Permitted" + "\n"
        +System.DateTime.Now.ToString() + "     CCTVMaze.exe" + "       anonymous" + "      "+Environment.UserName+", isn't it?" + "\n"
        +System.DateTime.Now.ToString() + "     👁👁👁👁👁" + "       👁👁👁👁" + "      👁👁👁👁👁👁👁👁👁👁👁" + "     👁👁👁👁"; //content of the txt file
    
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
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"/System Log.txt", systemLog); //create a txt file on desktop
                hitten = true; //set status to hitten
            }
        }
    }
}
