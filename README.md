# Dedicated_server
 There is an error

 [TOC]

## Steps

 1. Build DEDICATED SERVER
 2. Run server
 3. Start project in Editor
 4. Error will pop-up on client side
   
## SERVER CONSOLE LOG

   ```
   [UnityMemory] Configuration Parameters - Can be set up in boot.config
    "memorysetup-bucket-allocator-granularity=16"
    "memorysetup-bucket-allocator-bucket-count=8"
    "memorysetup-bucket-allocator-block-size=4194304"
    "memorysetup-bucket-allocator-block-count=1"
    "memorysetup-main-allocator-block-size=16777216"
    "memorysetup-thread-allocator-block-size=16777216"
    "memorysetup-gfx-main-allocator-block-size=16777216"
    "memorysetup-gfx-thread-allocator-block-size=16777216"
    "memorysetup-cache-allocator-block-size=4194304"
    "memorysetup-typetree-allocator-block-size=2097152"
    "memorysetup-profiler-bucket-allocator-granularity=16"
    "memorysetup-profiler-bucket-allocator-bucket-count=8"
    "memorysetup-profiler-bucket-allocator-block-size=4194304"
    "memorysetup-profiler-bucket-allocator-block-count=1"
    "memorysetup-profiler-allocator-block-size=16777216"
    "memorysetup-profiler-editor-allocator-block-size=1048576"
    "memorysetup-temp-allocator-size-main=4194304"
    "memorysetup-job-temp-allocator-block-size=2097152"
    "memorysetup-job-temp-allocator-block-size-background=1048576"
    "memorysetup-job-temp-allocator-reduction-small-platforms=262144"
    "memorysetup-allocator-temp-initial-block-size-main=262144"
    "memorysetup-allocator-temp-initial-block-size-worker=262144"
    "memorysetup-temp-allocator-size-background-worker=32768"
    "memorysetup-temp-allocator-size-job-worker=262144"
    "memorysetup-temp-allocator-size-preload-manager=262144"
    "memorysetup-temp-allocator-size-nav-mesh-worker=65536"
    "memorysetup-temp-allocator-size-audio-worker=65536"
    "memorysetup-temp-allocator-size-cloud-worker=32768"
    "memorysetup-temp-allocator-size-gfx=262144"
Mono path[0] = 'X:/Apps/Unity/Project/GitHub_Repository/Dedicated_server/Build_Server/Dedicated_server_Data/Managed'
Mono config path = 'X:/Apps/Unity/Project/GitHub_Repository/Dedicated_server/Build_Server/MonoBleedingEdge/etc'
Found 2 interfaces on host : 0) 192.168.0.106 1) 10.5.0.2
Player connection [33632]  Target information:

Player connection [33632]  * "[IP] 192.168.0.106 [Port] 55000 [Flags] 2 [Guid] 1429861489 [EditorId] 3439638573 [Version] 1048832 [Id] WindowsServer(44,MAIN_PC) [Debug] 0 [PackageName] WindowsServer [ProjectName] Dedicated_server"

Player connection [33632]  * "[IP] 10.5.0.2 [Port] 55000 [Flags] 2 [Guid] 1429861489 [EditorId] 3439638573 [Version] 1048832 [Id] WindowsServer(44,MAIN_PC) [Debug] 0 [PackageName] WindowsServer [ProjectName] Dedicated_server"

Player connection [33632] Started UDP target info broadcast (1) on [225.0.0.222:54997].

[PhysX] Initialized MultithreadedTaskDispatcher with 12 workers.
Initialize engine version: 2022.3.44f1 (c3ae09b9f03c)
[Subsystems] Discovering subsystems at path X:/Apps/Unity/Project/GitHub_Repository/Dedicated_server/Build_Server/Dedicated_server_Data/UnitySubsystems
Forcing GfxDevice: Null
GfxDevice: creating device client; threaded=0; jobified=0
NullGfxDevice:
    Version:  NULL 1.0 [1.0]
    Renderer: Null Device
    Vendor:   Unity Technologies
Begin MonoManager ReloadAssembly
- Loaded All Assemblies, in  0.125 seconds
- Finished resetting the current domain, in  0.002 seconds
ERROR: Shader Sprites/Default shader is not supported on this GPU (none of subshaders/fallbacks are suitable)
Microsoft Media Foundation video decoding to texture disabled: graphics device is Null, only Direct3D 11 and Direct3D 12 (only on desktop) are supported for hardware-accelerated video decoding.
ERROR: Shader Sprites/Mask shader is not supported on this GPU (none of subshaders/fallbacks are suitable)
[PhysX] Initialized MultithreadedTaskDispatcher with 12 workers.
UnloadTime: 0.800700 ms
START SERVER
Listening for clients ...
[Netcode] Client Connected
UnityEngine.StackTraceUtility:ExtractStackTrace () (at C:/build/output/unity/unity/Runtime/Export/Scripting/StackTrace.cs:37)
UnityEngine.DebugLogHandler:LogFormat (UnityEngine.LogType,UnityEngine.Object,string,object[])
UnityEngine.Logger:Log (UnityEngine.LogType,object)
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkConnectionManager:ConnectEventHandler (ulong) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:435)
Unity.Netcode.NetworkConnectionManager:HandleNetworkEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:390)
Unity.Netcode.NetworkTransport:InvokeOnTransportEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/NetworkTransport.cs:49)
Unity.Netcode.Transports.UTP.UnityTransport:AcceptConnection () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:818)
Unity.Netcode.Transports.UTP.UnityTransport:Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:934)

(Filename: ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs Line: 22)

[Netcode] Server detected a transport connection from Client-1, but timed out waiting for the connection request message.
UnityEngine.StackTraceUtility:ExtractStackTrace () (at C:/build/output/unity/unity/Runtime/Export/Scripting/StackTrace.cs:37)
UnityEngine.DebugLogHandler:LogFormat (UnityEngine.LogType,UnityEngine.Object,string,object[])
UnityEngine.Logger:Log (UnityEngine.LogType,object)
UnityEngine.Debug:LogWarning (object)
Unity.Netcode.NetworkLog:LogWarning (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:28)
Unity.Netcode.NetworkConnectionManager/<ApprovalTimeout>d__60:MoveNext () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:641)
UnityEngine.SetupCoroutine:InvokeMoveNext (System.Collections.IEnumerator,intptr) (at C:/build/output/unity/unity/Runtime/Export/Scripting/Coroutines.cs:17)

(Filename: ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs Line: 28)

OnClientDisconnect

   ```

## CLIENT CONSOLE LOG

```
START CLIENT
UnityEngine.Debug:Log (object)
Init:Awake () (at Assets/Scripts/Init.cs:24)

[Netcode] Connected
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkConnectionManager:ConnectEventHandler (ulong) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:444)
Unity.Netcode.NetworkConnectionManager:HandleNetworkEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:390)
Unity.Netcode.NetworkTransport:InvokeOnTransportEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/NetworkTransport.cs:49)
Unity.Netcode.Transports.UTP.UnityTransport:ProcessEvent () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:869)
Unity.Netcode.Transports.UTP.UnityTransport:Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:939)

KeyNotFoundException: The given key 'Unity.Netcode.ConnectionRequestMessage' was not present in the dictionary.
System.Collections.Generic.Dictionary`2[TKey,TValue].get_Item (TKey key) (at <8ce0bd04a7a04b4b9395538239d3fdd8>:0)
Unity.Netcode.NetworkMessageManager.SendPreSerializedMessage[TMessageType] (Unity.Netcode.FastBufferWriter& tmpSerializer, System.Int32 maxSize, TMessageType& message, Unity.Netcode.NetworkDelivery delivery, System.Collections.Generic.IReadOnlyList`1[System.UInt64]& clientIds, System.Int32 messageVersionFilter) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Messaging/NetworkMessageManager.cs:657)
Unity.Netcode.NetworkMessageManager.SendMessage[TMessageType,TClientIdListType] (TMessageType& message, Unity.Netcode.NetworkDelivery delivery, TClientIdListType& clientIds) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Messaging/NetworkMessageManager.cs:643)
Unity.Netcode.NetworkMessageManager.SendMessage[T] (T& message, Unity.Netcode.NetworkDelivery delivery, System.UInt64 clientId) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Messaging/NetworkMessageManager.cs:814)
Unity.Netcode.NetworkConnectionManager.SendMessage[T] (T& message, Unity.Netcode.NetworkDelivery delivery, System.UInt64 clientId) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:1297)
Unity.Netcode.NetworkConnectionManager.SendConnectionRequest () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:588)
Unity.Netcode.NetworkConnectionManager.ConnectEventHandler (System.UInt64 transportClientId) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:447)
Unity.Netcode.NetworkConnectionManager.HandleNetworkEvent (Unity.Netcode.NetworkEvent networkEvent, System.UInt64 transportClientId, System.ArraySegment`1[T] payload, System.Single receiveTime) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:390)
Unity.Netcode.NetworkTransport.InvokeOnTransportEvent (Unity.Netcode.NetworkEvent eventType, System.UInt64 clientId, System.ArraySegment`1[T] payload, System.Single receiveTime) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/NetworkTransport.cs:49)
Unity.Netcode.Transports.UTP.UnityTransport.ProcessEvent () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:869)
Unity.Netcode.Transports.UTP.UnityTransport.Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:939)

Failed to connect to server.
UnityEngine.Debug:LogError (object)
Unity.Netcode.Transports.UTP.UnityTransport:ProcessEvent () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:890)
Unity.Netcode.Transports.UTP.UnityTransport:Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:939)

[Netcode] Disconnect Event From 0
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkConnectionManager:DisconnectEventHandler (ulong) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:483)
Unity.Netcode.NetworkConnectionManager:HandleNetworkEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:396)
Unity.Netcode.NetworkTransport:InvokeOnTransportEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/NetworkTransport.cs:49)
Unity.Netcode.Transports.UTP.UnityTransport:ProcessEvent () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:897)
Unity.Netcode.Transports.UTP.UnityTransport:Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:939)

[Netcode] Shutdown
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkManager:Shutdown (bool) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkManager.cs:1156)
Unity.Netcode.NetworkConnectionManager:DisconnectEventHandler (ulong) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:520)
Unity.Netcode.NetworkConnectionManager:HandleNetworkEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:396)
Unity.Netcode.NetworkTransport:InvokeOnTransportEvent (Unity.Netcode.NetworkEvent,ulong,System.ArraySegment`1<byte>,single) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/NetworkTransport.cs:49)
Unity.Netcode.Transports.UTP.UnityTransport:ProcessEvent () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:897)
Unity.Netcode.Transports.UTP.UnityTransport:Update () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Transports/UTP/UnityTransport.cs:939)

[Netcode] ShutdownInternal
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkManager:ShutdownInternal () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkManager.cs:1184)
Unity.Netcode.NetworkManager:NetworkUpdate (Unity.Netcode.NetworkUpdateStage) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkManager.cs:94)
Unity.Netcode.NetworkUpdateLoop:RunNetworkUpdateStage (Unity.Netcode.NetworkUpdateStage) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkUpdateLoop.cs:192)
Unity.Netcode.NetworkUpdateLoop/NetworkPostLateUpdate/<>c:<CreateLoopSystem>b__0_0 () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkUpdateLoop.cs:287)

[Netcode] NetworkConnectionManager.Shutdown() -> IsListening && NetworkTransport != null -> NetworkTransport.Shutdown()
UnityEngine.Debug:Log (object)
Unity.Netcode.NetworkLog:LogInfo (string) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Logging/NetworkLog.cs:22)
Unity.Netcode.NetworkConnectionManager:Shutdown () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Connection/NetworkConnectionManager.cs:1200)
Unity.Netcode.NetworkManager:ShutdownInternal () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkManager.cs:1199)
Unity.Netcode.NetworkManager:NetworkUpdate (Unity.Netcode.NetworkUpdateStage) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkManager.cs:94)
Unity.Netcode.NetworkUpdateLoop:RunNetworkUpdateStage (Unity.Netcode.NetworkUpdateStage) (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkUpdateLoop.cs:192)
Unity.Netcode.NetworkUpdateLoop/NetworkPostLateUpdate/<>c:<CreateLoopSystem>b__0_0 () (at ./Library/PackageCache/com.unity.netcode.gameobjects@1.10.0/Runtime/Core/NetworkUpdateLoop.cs:287)

```