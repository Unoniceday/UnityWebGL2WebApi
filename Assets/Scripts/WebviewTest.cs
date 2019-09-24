using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WebviewTest : MonoBehaviour {
    
    [DllImport("__Internal")]
    private static extern void HelloString(string str);

    [DllImport("__Internal")]
    private static extern void Hello();


    public string SendString = "HelloString - yo";
    public void HelloStringBtnClicked()
    {
        Debug.Log("call-js-HelloString(" + SendString + ")");
        HelloString(SendString);
    }

    public void HelloBtnClicked()
    {
        Debug.Log("call-js-Hello()");
        Hello();
    }
    
}
