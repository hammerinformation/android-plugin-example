using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Plugin : MonoBehaviour
{

    public static Plugin Instance;

    AndroidJavaClass unityClass = null;
    AndroidJavaObject unityActivity = null;
    AndroidJavaObject pluginInstance = null;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        Init("com.example.mylibrary.MyPlugin");
    }

    private void Init(string pluginName)
    {

        unityClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        unityActivity = unityClass.GetStatic<AndroidJavaObject>("currentActivity");
        pluginInstance = new AndroidJavaObject(pluginName);

        if (pluginInstance != null)
        {
            pluginInstance.CallStatic("setActivity", unityActivity);
        }
    }

    public void Toast(string text)
    {
        if (pluginInstance != null)
        {
            pluginInstance.Call("toast", text);
        }
    }

    public void AlertDialog(string title, string message)
    {
        if (pluginInstance != null)
        {
            pluginInstance.Call("alertDialog", title, message);
        }
    }

}

