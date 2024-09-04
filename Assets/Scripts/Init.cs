using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Rendering;

public class Init : NetworkManager
{
    public void Awake()
    {
        if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Null)
        {
            // SERVER BUILD
            Console.WriteLine("START SERVER");

            OnServerStarted += OnServerStartedCallback;
            OnClientConnectedCallback += OnClientConnected;
            OnClientDisconnectCallback += OnClientDisconnect;

            StartServer();
        }
        else
        {
            // CLIENT BUILD
            Debug.Log("START CLIENT");

            StartClient();
        }
    }

    public void OnDestroy()
    {
        Shutdown();
    }

    private void OnClientDisconnect(ulong obj)
    {
        Console.WriteLine("OnClientDisconnect");
    }

    private void OnClientConnected(ulong obj)
    {
        Console.WriteLine("OnClientConnected");
    }

    private void OnServerStartedCallback()
    {
        Console.WriteLine("Listening for clients ... ");
    }
}
