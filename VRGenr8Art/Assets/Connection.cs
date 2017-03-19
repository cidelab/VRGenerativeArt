using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Net;
using System.Threading;
using System.Text;

public class Connection : MonoBehaviour
{
    static HttpListener _httpListener = new HttpListener();
    static String[] sendStrs = null;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Starting server...");
        _httpListener.Prefixes.Add("http://localhost:4000/"); // add prefix "http://localhost:4000/"
        _httpListener.Start(); // start server (Run application as Administrator!)
        Debug.Log("Server started.");
        Thread _responseThread = new Thread(ResponseThread);

        _responseThread.Start(); // start the response thread
    }

    public static void sendOutput(String[] items)
    {
        sendStrs = items;
    }
    // Update is called once per frame
    void Update()
    {
        if(sendStrs != null)
        {
            foreach (String item in sendStrs)
            {
                foreach (makeCube obj in GameObject.FindObjectsOfType<makeCube>())
                {
                    obj.setString(item);
                }
            }
            sendStrs = null;
        }
    }
    private static void ResponseThread()
    {
        while (true)
        {
            HttpListenerContext context = _httpListener.GetContext(); // get a context
            String query = context.Request.Url.Query;
            if (query.Length > 0) query = query.Substring(1);
            else continue;
            // Now, you'll find the request URL in context.Request.Url
            byte[] _responseArray = Encoding.UTF8.GetBytes("<html><head><title>Localhost server -- port 4000</title></head>" +
            "<body>Welcome to the <strong>Localhost server</strong> -- <em>port 4000!</em></body></html>"); // get the bytes to response
            context.Response.OutputStream.Write(_responseArray, 0, _responseArray.Length); // write bytes to the output stream
            //context.Response.KeepAlive = false; // set the KeepAlive bool to false
            context.Response.Close(); // close the connection
            Debug.Log("Respone given to a request.");
            
            String[] items = query.Split('&');
            sendOutput(items);
        }
    }
}