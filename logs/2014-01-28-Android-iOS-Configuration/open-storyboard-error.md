System.AggregateException: One or more errors occured ---> System.Exception: EnsureSession counter too high. Server may be repeatedly crashing. ---> System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



  --- End of inner exception stack trace ---
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x00128] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1496 
  at System.Threading.Tasks.TaskActionInvoker+FuncInvoke`1[System.Object[]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:241 
  at System.Threading.Tasks.Task.InnerInvoke () [0x00028] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:505 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
 --> (Inner exception 0) System.Exception: EnsureSession counter too high. Server may be repeatedly crashing. ---> System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



  --- End of inner exception stack trace ---
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x00128] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1496 
  at System.Threading.Tasks.TaskActionInvoker+FuncInvoke`1[System.Object[]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:241 
  at System.Threading.Tasks.Task.InnerInvoke () [0x00028] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:505 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


Contents of /Users/moljac/Library/Logs/XamarinStudio-4.0/iOSDesigner.2014-01-28__09-27-59.log:
[2014-01-28 09:28:06.8] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:06.8] INFO: Starting simulator at: '/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk'
[2014-01-28 09:28:07.0] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: LEAVING sandbox com.xamarin.MTHosting.a057c0d1 to parent com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: LEAVING sandbox com.xamarin.MTHosting.a057c0d1 to parent com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: LEAVING sandbox com.xamarin.MTHosting.a057c0d1 to parent com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:07.0] INFO: LEAVING sandbox com.xamarin.MTHosting.a057c0d1 to parent com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:08.4] INFO: LEAVING sandbox: com.xamarin.MTHosting.a057c0d1
[2014-01-28 09:28:08.4] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057d6a2
[2014-01-28 09:28:08.4] INFO: Starting simulator at: '/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk'
com.apple.BTServer: arch(39050,0x10a723310) malloc: stack logs being written into /tmp/stack-logs.39050.109dda000.arch.0ilSZV.index
arch(39050,0x10a723310) malloc: recording malloc and VM allocation stacks to disk using standard recorder
arch(39050,0x10a723310) malloc: enabling scribbling to detect mods to free blocks
arch(39050,0x10a723310) malloc: enabling abort() on bad malloc or free
arch(39050,0x10a723310) malloc: process 38870 no longer exists, stack logs deleted from /tmp/stack-logs.38870.3d87000.BTServer.ztFiIq.index
BTServer(39050,0x14461a8) malloc: stack logs being written into /tmp/stack-logs.39050.3d87000.BTServer.cGz6Iv.index
BTServer(39050,0x14461a8) malloc: recording malloc and VM allocation stacks to disk using standard recorder
BTServer(39050,0x14461a8) malloc: enabling scribbling to detect mods to free blocks
BTServer(39050,0x14461a8) malloc: enabling abort() on bad malloc or free
BTServer(39050,0x14461a8) malloc: stack logs deleted from /tmp/stack-logs.39050.109dda000.arch.0ilSZV.index
BTServer 6.1 () Modified on
com.apple.server.bluetooth: Bluetooth Super Server Robot Destroyer
com.apple.itunescloudd: 2014-01-28 09:28:08.451 itunescloudd[39049:1107] SSSQLiteDatabase: Could not setup database: [14, /tmp/com.xamarin.MTHosting.a057c0d1/Library/com.apple.itunesstored/kvs.sqlitedb]
[2014-01-28 09:28:08.4] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057d6a2
com.apple.BTServer: com.apple.server.bluetooth: Server attached, going into msg loop.
com.apple.SpringBoard: objc[39042]: Class TLTextToneInfo is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLToneManager is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLITunesTone is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLVibrationManager is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLVibrationPattern is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLVibrationManagerServiceClient is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLVibrationManagerServiceUtilities is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLAlert is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
objc[39042]: Class TLAlertController is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibraryNoUI.framework/ToneLibraryNoUI and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk/System/Library/PrivateFrameworks/ToneLibrary.framework/ToneLibrary. One of the two will be used. Which one is undefined.
com.apple.SimulatorBridge: 2014-01-28 09:28:08.530 SimulatorBridge[39043:1107] Falling back to MobileInstallation
com.apple.passd: 2014-01-28 09:28:08.544 passd[39044:1107] Error getting Passes directory file attributes. Removing and recreating directory. (Error = Error Domain=NSCocoaErrorDomain Code=260 "The operation couldn’t be completed. (Cocoa error 260.)" UserInfo=0x2e5e540 {NSFilePath=/tmp/com.xamarin.MTHosting.a057c0d1/Library/Passes, NSUnderlyingError=0x2e5d060 "The operation couldn’t be completed. No such file or directory"})
com.apple.backboardd: Couldn't connect to migrator port (1102).
com.apple.backboardd: 2014-01-28 09:28:08.593 backboardd[39051:1a03] Migration complete. (Elapsed time: 0.00 seconds)
com.apple.backboardd: 2014-01-28 09:28:08.942 backboardd[39051:1a03] Telling the system app that it can start immediately
com.apple.SpringBoard: 2014-01-28 09:28:09.002 SpringBoard[39042:1e0b] +[SBPushStore migratePushStore] Migrating push store: /tmp/com.xamarin.MTHosting.a057c0d1/Library/SpringBoard/PushStore
com.apple.SpringBoard: 2014-01-28 09:28:09.004 SpringBoard[39042:1e0b] +[SBPushStore migratePushStore] Push store does not exist; no migration needed.
com.apple.distnoted.xpc.daemon: 2014-01-28 09:28:09.081 distnoted[39056:1107] # distnote server daemon  absolute time: 168041.886422479   civil time: Tue Jan 28 09:28:09 2014   pid: 39056 uid: 501  root: yes
com.apple.TextInput.kbd: 2014-01-28 09:28:09.116 kbd[39041:1c03] -[TIUserDictionaryServer importSampleShortcuts]  Couldn't read AppleLanguages preference.
com.apple.backboardd: 2014-01-28 09:28:09.161 backboardd[39051:1a03] -[BKSystemAppSentinel lock_notePresenceOfSystemApp:] Now monitoring "com.xamarin.MTHosting.a057c0d1:com.apple.SpringBoard"
com.apple.itunescloudd: 2014-01-28 09:28:09.494 itunescloudd[39049:1107] [HSCloudClientMigration] MIGRATION: isMatchAuthenticated: NO, isMatchCellularDataEnabled: YES, hasAutomaticDownloads: NO, isAutomaticDownloadCellularDataEnabled: NO. New cellular data state: NO
com.apple.itunescloudd: 2014-01-28 09:28:09.503 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.504 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.507 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.507 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunesstored: mach_port_mod_refs() failed
com.apple.itunescloudd: 2014-01-28 09:28:09.508 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunesstored: mach_port_mod_refs() failed
com.apple.itunescloudd: 2014-01-28 09:28:09.508 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.508 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.509 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.509 itunescloudd[39049:1107] Could not prepare SELECT value FROM _MLDatabaseProperties WHERE key = ?: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.509 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.509 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.510 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.510 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.510 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.511 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.511 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.511 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.itunescloudd: 2014-01-28 09:28:09.512 itunescloudd[39049:1107] Could not prepare INSERT OR REPLACE INTO _MLDatabaseProperties (value, key) VALUES (?, ?);: no such table: _MLDatabaseProperties
com.apple.lsd: 2014-01-28 09:28:09.599 lsd[39055:1107] LaunchServices: Seeding database
com.apple.locationd: 2014-01-28 09:28:09.786 locationd[39048:1107] Launch Services: Registering unknown app identifier com.apple.PassKit failed
com.apple.lsd: 2014-01-28 09:28:09.791 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.795 lsd[39055:1107] Attempting to store identifiers file
com.apple.locationd: 2014-01-28 09:28:09.809 locationd[39048:1107] Launch Services: Unable to find app identifier com.apple.PassKit
com.apple.lsd: 2014-01-28 09:28:09.811 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.815 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.817 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.818 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.819 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.820 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.832 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.832 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.842 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.843 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.853 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.853 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.858 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.859 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.860 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.861 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.862 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.863 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.865 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.865 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.866 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.867 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.868 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.869 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.871 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.871 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.873 lsd[39055:1107] updating identifier store
com.apple.passd: 2014-01-28 09:28:09.873 passd[39044:1107] Updating all passes. This should only occur once.
com.apple.lsd: 2014-01-28 09:28:09.874 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:28:09.8] INFO: LEAVING sandbox com.xamarin.MTHosting.a057d6a2 to parent com.xamarin.MTHosting.a057d6a2
[2014-01-28 09:28:09.8] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057d6a2
com.apple.lsd: 2014-01-28 09:28:09.876 lsd[39055:1107] updating identifier store
[2014-01-28 09:28:09.8] INFO: LEAVING sandbox com.xamarin.MTHosting.a057d6a2 to parent com.xamarin.MTHosting.a057d6a2
com.apple.lsd: 2014-01-28 09:28:09.877 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:28:09.8] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057d6a2
com.apple.lsd: 2014-01-28 09:28:09.883 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.883 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.890 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.892 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.948 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.949 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:28:09.9] INFO: LEAVING sandbox com.xamarin.MTHosting.a057d6a2 to parent com.xamarin.MTHosting.a057d6a2
[2014-01-28 09:28:09.9] INFO: ENTERING sandbox: com.xamarin.MTHosting.a057d6a2
[2014-01-28 09:28:09.9] INFO: LEAVING sandbox com.xamarin.MTHosting.a057d6a2 to parent com.xamarin.MTHosting.a057d6a2
com.apple.itunesstored: 2014-01-28 09:28:09.960 itunesstored[39053:1603] iTunes Store environment is: NWK
com.apple.lsd: 2014-01-28 09:28:09.961 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.962 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.965 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.965 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.967 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.967 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.979 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.980 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.981 lsd[39055:1107] updating identifier store
2014-01-28 09:28:09.982 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.983 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.984 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.985 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.985 lsd[39055:1107] Attempting to store identifiers file
com.apple.lsd: 2014-01-28 09:28:09.988 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:28:09.988 lsd[39055:1107] Attempting to store identifiers file
com.apple.itunescloudd: mach_port_mod_refs() failed
com.apple.itunescloudd: mach_port_mod_refs() failed
com.apple.lsd: 2014-01-28 09:28:13.468 lsd[39055:1107] Launch Services: For app identifier com.apple.mobileslideshow, corrected resources URL from file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/MobileSlideShow.app/ to file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/MobileSlideShow.app
com.apple.lsd: 2014-01-28 09:28:13.487 lsd[39055:1107] Launch Services: For app identifier com.apple.MobileAddressBook, corrected resources URL from file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Contacts~ipad.app/ to file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Contacts~ipad.app
com.apple.lsd: 2014-01-28 09:28:13.498 lsd[39055:1107] Launch Services: For app identifier com.apple.Preferences, corrected resources URL from file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Preferences.app/ to file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Preferences.app
com.apple.lsd: 2014-01-28 09:28:13.512 lsd[39055:1107] Launch Services: For app identifier com.apple.gamecenter, corrected resources URL from file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Game%20Center~ipad.app/ to file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/Game%20Center~ipad.app
com.apple.lsd: 2014-01-28 09:28:13.729 lsd[39055:1107] Launch Services: For app identifier com.apple.mobilesafari, corrected resources URL from file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/MobileSafari.app/ to file://localhost/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator6.1.sdk//Applications/MobileSafari.app
[2014-01-28 09:28:13.9] INFO: LEAVING sandbox: com.xamarin.MTHosting.a057d6a2
com.apple.SpringBoard: 2014-01-28 09:28:14.045 SpringBoard[39042:1e0b] SMS Plugin initialized.
com.apple.SpringBoard: 2014-01-28 09:28:14.051 SpringBoard[39042:1e0b] SIMToolkit plugin for SpringBoard initialized.
com.apple.SpringBoard: 2014-01-28 09:28:14.096 SpringBoard[39042:c07] Passbook isn't supported on iPads
system: Jan 21 16:54:30 miljenkos-mbp bootlog[0] <Notice>: BOOT_TIME 1390319670 0
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.assetsd[0]) <Warning>: The HideUntilCheckIn property is an architectural performance issue. Please transition away from it.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.calaccessd[0]) <Warning>: The HideUntilCheckIn property is an architectural performance issue. Please transition away from it.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.backboardd) <Notice>: This service is defined to be constantly running and inherently inefficient.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.backboardd) <Warning>: Unknown key for Boolean: HighPriorityIO
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.cfnetwork.cfnetworkagent) <Error>: The StartInterval key is no longer respected. Use XPC Activity instead.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.configd_sim) <Notice>: This service is defined to be constantly running and inherently inefficient.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.configd_sim) <Error>: The Umask key is not yet implemented. If you rely on this key, please file a bug.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.dataaccess.dataaccessd[0]) <Warning>: The HideUntilCheckIn property is an architectural performance issue. Please transition away from it.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.EscrowSecurityAlert) <Warning>: Unknown key for string: seatbelt-profiles
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.gamed[0]) <Warning>: The HideUntilCheckIn property is an architectural performance issue. Please transition away from it.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.gamed) <Error>: The Umask key is not yet implemented. If you rely on this key, please file a bug.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.geod) <Error>: The StartInterval key is no longer respected. Use XPC Activity instead.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.iCloudKeychainStats) <Error>: The StartInterval key is no longer respected. Use XPC Activity instead.
Jan 28 09:28:09 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.identityservicesd) <Error>: Unknown key for KeepAlive: SuccessfulExit
Jan 28 09:28:12 miljenkos-mbp configd_sim[39060] <Notice>: network changed: v4(en0+:192.168.1.78) DNS+ Proxy+
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 check_stale_maps: Install cache not found; it will be generated.
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 store_binary_dict: Failed to write dictionary to path /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/com.apple.mobile.installation~iPad.plist
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 save_install_map: Could not store /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/com.apple.mobile.installation~iPad.plist
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 preflight_install_map: Could not save install map
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 preflight_install_map: Detected simulator root change from "(null)" to "/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk".
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 load_container_state: Could not lookup application com.apple.iOS6Updater in the install map
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 MobileInstallationUninstall_Server: com.apple.iOS6Updater not found in user apps, ignoring
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.datadetectors.DDActionsService -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/8446F629-CAB6-4D5B-BE1F-BDD211D249AE"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 load_application_info: Info plist for /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk//Applications/iOS Diagnostics.app was missing or empty
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.mobilesafari -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/9A6EF346-B758-41DE-889B-A93AB9C122BA"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Error>: 0x132b1a8 load_application_info: Info plist for /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk//Applications/Photo Booth.app was missing or empty
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.ios.StoreKitUIService -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/790134BC-AA60-4C56-9944-E3D7CC351937"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.webapp -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/906376E1-82D4-4AE4-B124-D0236C74D15E"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.WebContentFilter.remoteUI.WebContentAnalysisUI -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/1B21102E-9E82-4B2B-9658-D390945AEC27"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 tell_sandbox_about_container: Added sandbox mapping com.apple.WebViewService -> "/tmp/com.xamarin.MTHosting.a057d6a2/Applications/608B0783-3C2B-497F-BBA9-50B2DFC888CE"
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 generate_application_map: Deferring user app list rebuild
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 copy_next_sequence_number: Install map was missing sequence number; resetting and re-generating GUID.
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.AdSheetPhone got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.datadetectors.DDActionsService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.mobilecal got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.camera got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.MobileAddressBook got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.AccountAuthenticationDialog got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.Copilot got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.Passbook got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.social.remoteui.SocialUIService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.appleaccount.AACredentialRecoveryDialog got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.DataActivation got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.MailCompositionService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.WebViewService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.WebSheet got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.FacebookAccountMigrationDialog got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.iphoneos.iPodOut got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.gamecenter.GameCenterUIService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.ios.StoreKitUIService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.SiriViewService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.mobilesms.compose got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.Maps got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.Preferences got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.uikit.PrintStatus got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.mobileslideshow got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.mobilesafari got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.PassbookUIService got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.iad.iAdOptOut got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.TrustMe got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.quicklook.quicklookd got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.webapp got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.WebContentFilter.remoteUI.WebContentAnalysisUI got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 __reconcileApps_block_invoke_2: com.apple.gamecenter got added
Jan 28 09:28:12 miljenkos-mbp installd[39065] <Notice>: 0x132b1a8 generate_application_map: Saved updated install map for -|system|internal
Jan 28 09:28:13 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 load_application_type: No applications of type User found in /tmp/com.xamarin.MTHosting.a057d6a2/Applications
Jan 28 09:28:13 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 load_application_type: No applications of type VPNPlugin found in /tmp/com.xamarin.MTHosting.a057d6a2/Applications
Jan 28 09:28:13 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 generate_application_map: Saved updated install map for user|-|-
Jan 28 09:28:13 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) mstreamd: mstreamd starting up.
Jan 28 09:28:13 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) PS: The subscription plugin class does not support push notification refreshing.
Jan 28 09:28:13 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) PS: Media stream daemon starting...
Jan 28 09:28:13 miljenkos-mbp identityservicesd[39061] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: libMobileGestalt SimCapabilities.c:30: can't load simulator capabilities dictionary from (null)
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Notice>: void __IOHIDPlugInLoadBundles(): Loaded 0 HID plugins
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Notice>: Posting 'com.apple.iokit.hid.displayStatus' notifyState=1
Jan 28 09:28:13 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) AS: <MSASDaemonModel: 0x3a3e260>: Migrating database from version -1 to version 2.
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5360e20 pthread_self=0xb0219000
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: ____IOHIDSessionScheduleAsync_block_invoke: thread_id=0xb0219000
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: HID Session async scheduling initiated.
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: HID Session async root queue running at priority 63 and schedule 2.
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: HID Session async scheduling complete.
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: Successfully opened the IOHIDSession
Jan 28 09:28:13 miljenkos-mbp identityservicesd[39061] <Warning>: [Warning] Setting up a new database at path /tmp/com.xamarin.MTHosting.a057d6a2/Library/IdentityServices/ids.db.
Jan 28 09:28:13 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb029b000
Jan 28 09:28:13 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) AS: <MSASDaemonModel: 0x3a3e260>: Set database version to 2.
Jan 28 09:28:13 miljenkos-mbp locationd[39062] <Notice>: Logging binary sensor data to /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/locationdSensors.bin
Jan 28 09:28:13 miljenkos-mbp locationd[39062] <Error>: NBB-Could not get UDID for stable refill timing, falling back on random
Jan 28 09:28:13 miljenkos-mbp locationd[39062] <Notice>: Location icon should now be in state 'Inactive'
Jan 28 09:28:13 miljenkos-mbp locationd[39062] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
Jan 28 09:28:13 miljenkos-mbp passd[39066] <Warning>: Error getting Passes directory file attributes. Removing and recreating directory. (Error = Error Domain=NSCocoaErrorDomain Code=260 "The operation couldn’t be completed. (Cocoa error 260.)" UserInfo=0x59103a0 {NSFilePath=/tmp/com.xamarin.MTHosting.a057d6a2/Library/Passes, NSUnderlyingError=0x590f9b0 "The operation couldn’t be completed. No such file or directory"})
Jan 28 09:28:13 miljenkos-mbp profiled[39063] <Notice>: (Note ) profiled: Service starting...
Jan 28 09:28:13 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:14 miljenkos-mbp securityd[39077] <Error>: unable to access hwaes key
Jan 28 09:28:14 miljenkos-mbp securityd[39077] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:14 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:14 miljenkos-mbp distnoted[39079] <Warning>: # distnote server daemon  absolute time: 168047.491834450   civil time: Tue Jan 28 09:28:14 2014   pid: 39079 uid: 501  root: yes
system: Jan 28 09:28:14 miljenkos-mbp accountsd[39078] <Notice>: 0x3344c70|DataMigrator|Note |DMPerformMigration|DMMessaging.m:216| DMPerformMigration called by process: accountsd[39078], reason: accountsd needs migration to finish
system: Jan 28 09:28:14 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.GSSCred) <Warning>: Unknown key for dictionary: no-EnvironmentVariables
system: Jan 28 09:28:14 miljenkos-mbp accountsd[39078] <Notice>: 0x3045c70|DataMigrator|Error|__DMPerformMigration_block_invoke|DMMessaging.m:229| Data migrator completed with success: NO!
system: Jan 28 09:28:14 miljenkos-mbp accountsd[39078] <Notice>: 0x3344c70|DataMigrator|Error|_DMReportMigrationFailure|DMMessaging.m:35| Data Migration failed!
system: Jan 28 09:28:14 miljenkos-mbp accountsd[39078] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:14 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
system: Jan 28 09:28:14 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: Adding com.xamarin.MTDesignServer to unregister list
system: Jan 28 09:28:14 miljenkos-mbp lsd[39076] <Warning>: LaunchServies: No placeholder bundle to remove for com.xamarin.MTDesignServer.
system: Jan 28 09:28:14 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:14 miljenkos-mbp apsd[39080] <Warning>: [Warning] Setting up a new database at path /tmp/com.xamarin.MTHosting.a057d6a2/Library/ApplePushService/aps.db.
system: Jan 28 09:28:15 miljenkos-mbp SimulatorBridge[39070] <Warning>: LaunchServices: installing app for existing placeholder LSApplicationProxy: com.xamarin.MTDesignServer
system: Jan 28 09:28:15 miljenkos-mbp locationd[39062] <Warning>: Launch Services: Registering unknown app identifier com.apple.PassKit failed
system: Jan 28 09:28:15 miljenkos-mbp SimulatorBridge[39070] <Warning>: LaunchServices: Not creating progress for LSApplicationProxy: com.xamarin.MTDesignServer since it is not a placeholder.
system: Jan 28 09:28:15 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 handle_install_for_ls: Install of "/Applications/Xamarin Studio.app/Contents/MacOS/lib/monodevelop/AddIns/MonoDevelop.IPhone/MonoTouchDesignServer.app" requested by SimulatorBridge
system: Jan 28 09:28:15 miljenkos-mbp mstreamd[39064] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:15 miljenkos-mbp apsd[39080] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:15 miljenkos-mbp locationd[39062] <Warning>: Launch Services: Unable to find app identifier com.apple.PassKit
system: Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Notice>: 0x5262400|DataMigrator|Info |DMPerformMigrationIfNeeded|DMMessaging.m:153| System build version changed from (null) to 13B42. We're going to run migration.
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Notice>: 0x5262400|DataMigrator|Note |DMPerformMigration|DMMessaging.m:216| DMPerformMigration called by process: backboardd[39059], reason: System build version changed from (null) to 13B42
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Notice>: 0x5373170|DataMigrator|Error|__DMPerformMigration_block_invoke|DMMessaging.m:229| Data migrator completed with success: NO!
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Notice>: 0x5262400|DataMigrator|Error|_DMReportMigrationFailure|DMMessaging.m:35| Data Migration failed!
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Notice>: 0x5262400|DataMigrator|Info |DMPerformMigrationIfNeeded|DMMessaging.m:162| Migration FAILED. (Elapsed time: 0.03 seconds)
system: Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Warning>: Migration complete (if performed). (Elapsed time: 0.06 seconds)
system: Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
system: Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
system: Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:15 --- last message repeated 5 times ---
Jan 28 09:28:15 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 MobileInstallationInstall_Server: Installing app com.xamarin.MTDesignServer
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
Jan 28 09:28:15 --- last message repeated 1 time ---
Jan 28 09:28:15 miljenkos-mbp passd[39066] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
Jan 28 09:28:15 miljenkos-mbp installd[39065] <Notice>: 0xb0093000 MobileInstallationInstall_Server: Staging: 0.19s; Waiting: 0.00s; Installation: 0.09s; LS Sync: 0.00s; Overall: 0.28s
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: Adding com.xamarin.MTDesignServer to registration list
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
Jan 28 09:28:15 --- last message repeated 3 times ---
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:15 --- last message repeated 4 times ---
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
system: Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
system: Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:15 --- last message repeated 6 times ---
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:15 --- last message repeated 4 times ---
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Error>: Need to synchronize with MobileInstallation
Jan 28 09:28:15 miljenkos-mbp /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/libexec/lsd[39076] <Notice>: LaunchServices: updating cache GUID and sequence number
Jan 28 09:28:15 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
Jan 28 09:28:15 --- last message repeated 1 time ---
Jan 28 09:28:15 miljenkos-mbp backboardd[39059] <Warning>: -[BKSystemAppSentinel lock_bootstrap]: Telling the system app that it can start
Jan 28 09:28:15 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (com.apple.xpc.launchd.domain.pid.SpringBoard.39067) <Error>: Failed to bootstrap path: /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/System/Library/PrivateFrameworks/CloudServices.framework/XPCServices/com.apple.lakitu.xpc
	error: 107: Malformed bundle
Jan 28 09:28:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:15.7] ERROR: Exception during InstallAndLaunch (attempt 1): System.Exception: Failed to retrieve the PID after launching the app. Pid was -1
  at Bindings.SimulatorBridge.LaunchApplication (System.String bundleId, System.String[] arguments, MonoMac.Foundation.NSDictionary environment, System.String stdOutFile, System.String stdErrFile) [0x0011a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Hosting/Bindings/SimulatorBridge.cs:105 
  at MonoTouch.Hosting.IosSession.LaunchApplication (System.String bundleId, System.String[] arguments) [0x0003a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Hosting/IosSession.cs:300 
  at MonoTouch.Hosting.IosSession.InstallAndLaunch (System.String appBundle, System.String simLang, System.String[] appArgs) [0x0004f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Hosting/IosSession.cs:241 
system: Jan 28 09:28:15 miljenkos-mbp cplogd[39082] <Warning>: Starting.
system: Jan 28 09:28:16 miljenkos-mbp MobileGestaltHelper[39084] <Warning>: waitpid failed: No child processes
system: Jan 28 09:28:16 miljenkos-mbp SpringBoard[39067] <Error>: libMobileGestalt SimCapabilities.c:30: can't load simulator capabilities dictionary from (null)
system: Jan 28 09:28:16 miljenkos-mbp SpringBoard[39067] <Warning>: +[SBPushStore migratePushStore] Migrating push store: /tmp/com.xamarin.MTHosting.a057d6a2/Library/SpringBoard/PushStore
system: Jan 28 09:28:16 miljenkos-mbp SpringBoard[39067] <Warning>: +[SBPushStore migratePushStore] Push store does not exist; no migration needed.
system: Jan 28 09:28:16 miljenkos-mbp SpringBoard[39067] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:16 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:16 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:16 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:16 miljenkos-mbp SimulatorBridge[39070] <Warning>: LaunchServices: installing app for existing placeholder LSApplicationProxy: com.xamarin.MTDesignServer
system: Jan 28 09:28:16 miljenkos-mbp SimulatorBridge[39070] <Warning>: LaunchServices: Not creating progress for LSApplicationProxy: com.xamarin.MTDesignServer since it is not a placeholder.
system: Jan 28 09:28:16 miljenkos-mbp installd[39065] <Notice>: 0xb029b000 handle_install_for_ls: Install of "/Applications/Xamarin Studio.app/Contents/MacOS/lib/monodevelop/AddIns/MonoDevelop.IPhone/MonoTouchDesignServer.app" requested by SimulatorBridge
system: Jan 28 09:28:16 miljenkos-mbp installd[39065] <Notice>: 0xb029b000 MobileInstallationInstall_Server: Installing app com.xamarin.MTDesignServer
system: Jan 28 09:28:16 miljenkos-mbp installd[39065] <Notice>: 0xb029b000 MobileInstallationInstall_Server: Staging: 0.07s; Waiting: 0.00s; Installation: 0.02s; LS Sync: 0.00s; Overall: 0.08s
system: Jan 28 09:28:16 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Updating identifier store
system: Jan 28 09:28:16 miljenkos-mbp SpringBoard[39067] <Error>: objc[39067]: Class AXEmojiUtilities is implemented in both /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/System/Library/PrivateFrameworks/AccessibilityUtilities.framework/AccessibilityUtilities and /Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/usr/lib/libAXSpeechManager.dylib. One of the two will be used. Which one is undefined.
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Warning>: Loaded logger: SBAppInstallationLog
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Warning>: Loaded logger: SBIconLog
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Warning>: Loaded logger: SBWorkspaceLogging
system: Jan 28 09:28:17 miljenkos-mbp backboardd[39059] <Warning>: -[BKSystemAppSentinel lock_notePresenceOfSystemApp:] Now monitoring "com.apple.SpringBoard"
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Warning>: *** error reading settings archive file: <SBRootSettings: /tmp/com.xamarin.MTHosting.a057d6a2/Documents/com.apple.springboard.settings/RootSettings.plist> 
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Warning>: *** error reading settings archive file: <SBRootSettings: /tmp/com.xamarin.MTHosting.a057d6a2/Documents/com.apple.springboard.settings/RootSettings.previous.plist> 
system: Jan 28 09:28:17 miljenkos-mbp ubd[39086] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:17 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Error>: libMobileGestalt MobileGestalt.c:200: string SBNonDefaultSystemAppTag is not a valid gestalt question
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Error>: libMobileGestalt MobileGestalt.c:200: string hidden is not a valid gestalt question
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Error>: libMobileGestalt MobileGestalt.c:835: still-camera is static and will never generate a notification
system: Jan 28 09:28:17 miljenkos-mbp SpringBoard[39067] <Error>: libMobileGestalt MobileGestalt.c:835: stand-alone-contacts is static and will never generate a notification
system: Jan 28 09:28:17 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:18 miljenkos-mbp SpringBoard[39067] <Warning>: BTM: attaching to BTServer
system: Jan 28 09:28:18 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:18 --- last message repeated 3 times ---
Jan 28 09:28:18 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:18 miljenkos-mbp itunesstored[39089] <Error>: libMobileGestalt SimCapabilities.c:30: can't load simulator capabilities dictionary from (null)
Jan 28 09:28:18 miljenkos-mbp itunesstored[39089] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
Jan 28 09:28:18 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:19 --- last message repeated 5 times ---
system: Jan 28 09:28:19 miljenkos-mbp mediaremoted[39092] <Error>: Property list invalid for format: 200 (property lists cannot contain NULL)
system: Jan 28 09:28:19 --- last message repeated 1 time ---
Jan 28 09:28:19 miljenkos-mbp securityd[39077] <Error>: OCSPResponse: now + maxAge > latestNextUpdate, using latestNextUpdate
[2014-01-28 09:28:19.5] INFO: Waiting for server to spin up... 1
[2014-01-28 09:28:19.7] INFO: Waiting for server to spin up... 2
system: Jan 28 09:28:19 --- last message repeated 1 time ---
Jan 28 09:28:19 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:19 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:19 miljenkos-mbp itunesstored[39089] <Warning>: iTunes Store environment is: NWK
[2014-01-28 09:28:19.9] INFO: Waiting for server to spin up... 3
system: Jan 28 09:28:19 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
[2014-01-28 09:28:20.1] INFO: Waiting for server to spin up... 4
[2014-01-28 09:28:20.3] INFO: Waiting for server to spin up... 5
[2014-01-28 09:28:20.5] INFO: Waiting for server to spin up... 6
system: Jan 28 09:28:20 --- last message repeated 59 times ---
Jan 28 09:28:20 miljenkos-mbp SpringBoard[39067] <Warning>: Application windows are expected to have a root view controller at the end of application launch
system: Jan 28 09:28:20 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:20.7] INFO: Waiting for server to spin up... 7
system: Jan 28 09:28:20 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (UIKitApplication:com.xamarin.MTDesignServer[0xbe52]) <Error>: Service tried to set environment variable with reserved name: CFFIXED_USER_HOME
system: Jan 28 09:28:20 miljenkos-mbp com.xamarin.MTHosting.a057d6a2[39054] (UIKitApplication:com.xamarin.MTDesignServer[0xbe52]) <Error>: Service tried to set environment variable with reserved name: HOME
system: Jan 28 09:28:20 miljenkos-mbp securityd[39077] <Error>: OCSPResponse: now + maxAge > latestNextUpdate, using latestNextUpdate
system: Jan 28 09:28:20 miljenkos-mbp SpringBoard[39067] <Warning>: SMS Plugin initialized.
system: Jan 28 09:28:20 miljenkos-mbp securityd[39077] <Error>: OCSPResponse: now + maxAge > latestNextUpdate, using latestNextUpdate
system: Jan 28 09:28:20 --- last message repeated 1 time ---
Jan 28 09:28:20 miljenkos-mbp SpringBoard[39067] <Warning>: Sharing Plugin initialized.
[2014-01-28 09:28:20.9] INFO: Waiting for server to spin up... 8
system: Jan 28 09:28:20 miljenkos-mbp SpringBoard[39067] <Warning>: SIMToolkit plugin for SpringBoard initialized.
[2014-01-28 09:28:21.1] INFO: Waiting for server to spin up... 9
[2014-01-28 09:28:21.3] INFO: Waiting for server to spin up... 10
[2014-01-28 09:28:21.5] INFO: Waiting for server to spin up... 11
system: Jan 28 09:28:21 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:21.7] INFO: Waiting for server to spin up... 12
[2014-01-28 09:28:21.7] INFO: Waiting for server to spin up... 1
system: Jan 28 09:28:21 miljenkos-mbp locationd[39062] <Error>: Client '/Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/System/Library/CoreServices/SpringBoard.app/SpringBoard' is attempting to masquerade as uninstalled app with effective bundle identifier 'com.apple.reminders'
[2014-01-28 09:28:21.9] INFO: Waiting for server to spin up... 13
[2014-01-28 09:28:21.9] INFO: Waiting for server to spin up... 2
system: Jan 28 09:28:22 miljenkos-mbp tccd[39096] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: warning: Could not compile statement CREATE TEMP TRIGGER LocalStoreOverwriteInsert BEFORE INSERT ON ABStore WHEN NEW.ROWID = 0 AND NEW.Type != 0 BEGIN SELECT ab_local_store_overwrite('INSERT'); END;: no such table: ABStore
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: warning: Could not compile statement CREATE TEMP TRIGGER LocalStoreOverwriteUpdate BEFORE UPDATE ON ABStore WHEN NEW.ROWID = 0 AND NEW.Type != 0 BEGIN SELECT ab_local_store_overwrite('UPDATE'); END;: no such table: ABStore
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: warning: Could not compile statement CREATE TEMP TRIGGER LocalStoreOverwriteDelete BEFORE DELETE ON ABStore WHEN OLD.ROWID = 0 BEGIN SELECT ab_local_store_overwrite('DELETE'); END;: no such table: ABStore
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: Using your own bundle identifier as an NSUserDefaults suite name does not make sense and will not work. Break on _NSUserDefaults_Log_Nonsensical_Suites to find this
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: Launch Services: Registering unknown app identifier com.apple.mobilemail failed
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: Launch Services: Unable to find app identifier com.apple.mobilemail
[2014-01-28 09:28:22.1] INFO: Waiting for server to spin up... 14
[2014-01-28 09:28:22.1] INFO: Waiting for server to spin up... 3
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Warning>: No conforming principal class found in NSBundle </Applications/Xcode.app/Contents/Developer/Platforms/iPhoneSimulator.platform/Developer/SDKs/iPhoneSimulator7.0.sdk/System/Library/BulletinBoardPlugins/SMSBBPlugin.bundle> (loaded)
[2014-01-28 09:28:22.3] INFO: Waiting for server to spin up... 15
[2014-01-28 09:28:22.3] INFO: Waiting for server to spin up... 4
[2014-01-28 09:28:22.5] INFO: Waiting for server to spin up... 16
[2014-01-28 09:28:22.6] INFO: Waiting for server to spin up... 5
system: Jan 28 09:28:22 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:22.7] INFO: Waiting for server to spin up... 17
[2014-01-28 09:28:22.8] INFO: Waiting for server to spin up... 6
system: Jan 28 09:28:22 miljenkos-mbp calaccessd[39098] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:22 miljenkos-mbp SpringBoard[39067] <Notice>: 2014-01-28 09:28:22.831|39067|0xe1e9060: Region monitoring not available or enabled. Trigger ignored!
system: Jan 28 09:28:22 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
[2014-01-28 09:28:22.9] INFO: Waiting for server to spin up... 18
[2014-01-28 09:28:23.0] INFO: Waiting for server to spin up... 7
[2014-01-28 09:28:23.1] INFO: Waiting for server to spin up... 19
[2014-01-28 09:28:23.2] INFO: Waiting for server to spin up... 8
[2014-01-28 09:28:23.3] INFO: Waiting for server to spin up... 20
[2014-01-28 09:28:23.4] INFO: Waiting for server to spin up... 9
[2014-01-28 09:28:23.5] INFO: Waiting for server to spin up... 21
[2014-01-28 09:28:23.6] INFO: Waiting for server to spin up... 10
system: Jan 28 09:28:23 --- last message repeated 5 times ---
system: Jan 28 09:28:23 miljenkos-mbp assetsd[39099] <Notice>: PLMigrationLog <t:0xaf51fa0> Failed to fetch path to uuid mappings 21 unable to open database file
system: Jan 28 09:28:23 miljenkos-mbp assetsd[39099] <Notice>: PLMigrationLog <t:0xaf51fa0> No store file to move aside at "/tmp/com.xamarin.MTHosting.a057d6a2/Media/PhotoData/Photos.sqlite"
system: Jan 28 09:28:23 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:28:23 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:23.7] INFO: Waiting for server to spin up... 22
[2014-01-28 09:28:23.8] INFO: Waiting for server to spin up... 11
[2014-01-28 09:28:23.9] INFO: Waiting for server to spin up... 23
[2014-01-28 09:28:24.0] INFO: Waiting for server to spin up... 12
[2014-01-28 09:28:24.1] INFO: Waiting for server to spin up... 24
system: Jan 28 09:28:24 miljenkos-mbp assetsd[39099] <Notice>: PLMigrationLog <t:0xb1470a0> loadFileSystemDataIntoDatabase called from __34+[PLModelMigrator _createDatabase]_block_invoke
[2014-01-28 09:28:24.2] INFO: Waiting for server to spin up... 13
system: Jan 28 09:28:24 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) mstreamd: Not resetting authentication state as we're waiting for a server response.
system: Jan 28 09:28:24 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) AS: <MSIOSAlbumSharingDaemon: 0x3a3dd40>: Forgetting everything.
system: Jan 28 09:28:24 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) AS: <MSIOSAlbumSharingDaemon: 0x3a3dd40>: Forgotten everything.
system: Jan 28 09:28:24 miljenkos-mbp assetsd[39099] <Notice>: PLThumbnailsLog <t:0xaf51fa0> Wrote thumbnail rebuild indicator file /tmp/com.xamarin.MTHosting.a057d6a2/Media/PhotoData/Thumbnails/rebuild
system: Jan 28 09:28:24 miljenkos-mbp assetsd[39099] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:24 miljenkos-mbp assetsd[39099] <Warning>: *** Successfully created ordered relationship index
system: Jan 28 09:28:24 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
[2014-01-28 09:28:24.3] INFO: Waiting for server to spin up... 25
[2014-01-28 09:28:24.4] INFO: Waiting for server to spin up... 14
[2014-01-28 09:28:24.5] INFO: Waiting for server to spin up... 26
[2014-01-28 09:28:24.6] INFO: Waiting for server to spin up... 15
[2014-01-28 09:28:24.7] INFO: Waiting for server to spin up... 27
system: Jan 28 09:28:24 --- last message repeated 11 times ---
Jan 28 09:28:24 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:24.8] INFO: Waiting for server to spin up... 16
[2014-01-28 09:28:24.9] INFO: Waiting for server to spin up... 28
[2014-01-28 09:28:25.0] INFO: Waiting for server to spin up... 17
[2014-01-28 09:28:25.1] INFO: Waiting for server to spin up... 29
[2014-01-28 09:28:25.2] INFO: Waiting for server to spin up... 18
[2014-01-28 09:28:25.3] INFO: Waiting for server to spin up... 30
[2014-01-28 09:28:25.4] INFO: Waiting for server to spin up... 19
[2014-01-28 09:28:25.5] INFO: Waiting for server to spin up... 31
[2014-01-28 09:28:25.6] INFO: Waiting for server to spin up... 20
system: Jan 28 09:28:25 miljenkos-mbp calaccessd[39098] <Notice>: 2014-01-28 09:28:25.771|39098|0x3a60b60: Updating birthday calendar
system: Jan 28 09:28:25 miljenkos-mbp calaccessd[39098] <Notice>: 2014-01-28 09:28:25.772|39098|0x3a60b60: BirthdayCal: Processing 0 people...
system: Jan 28 09:28:25 miljenkos-mbp calaccessd[39098] <Notice>: 2014-01-28 09:28:25.773|39098|0x3a60b60: BirthdayCal: Done. 0 adds, 0 updates, 0 deletes.
[2014-01-28 09:28:25.7] INFO: Waiting for server to spin up... 32
system: Jan 28 09:28:25 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:25.8] INFO: Waiting for server to spin up... 21
com.xamarin.MTDesignServer: [2014-01-28 09:28:25.9] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:28:25.9] INFO: Waiting for server to spin up... 33
com.xamarin.MTDesignServer: [2014-01-28 09:28:25.9] INFO: ASL fetching will start at 153473
com.xamarin.MTDesignServer: [2014-01-28 09:28:25.9] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:28:26.0] INFO: Waiting for server to spin up... 22
[2014-01-28 09:28:26.2] INFO: Waiting for server to spin up... 23
[2014-01-28 09:28:26.4] INFO: Waiting for server to spin up... 24
system: Jan 28 09:28:26 miljenkos-mbp backboardd[39059] <Warning>: CoreAnimation: timed out fence 81af
system: Jan 28 09:28:26 miljenkos-mbp SpringBoard[39067] <Warning>: CoreAnimation: failed to receive fence reply: 10004003
[2014-01-28 09:28:26.6] INFO: Waiting for server to spin up... 25
system: Jan 28 09:28:26 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:26.8] INFO: Waiting for server to spin up... 26
[2014-01-28 09:28:27.0] INFO: Waiting for server to spin up... 27
[2014-01-28 09:28:27.2] INFO: Waiting for server to spin up... 28
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Notice>: PLGenericLog <t:0xb066aa0> [ClientServerTransaction] handling outstanding transactions...
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Notice>: PLChangeHubLog <t:0xb066aa0> Forcing change log reset because of outstanding transactions
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Notice>: PLMomentsLog <t:0xb066aa0> Forcing moment rebuild because of outstanding transactions
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Notice>: PLCloudFeedLog <t:0xb066aa0> Forcing cloud feed rebuild because of outstanding transactions
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Notice>: PLMigrationLog <t:0xb066aa0> Forcing redundant import because of outstanding transactions
[2014-01-28 09:28:27.4] INFO: Waiting for server to spin up... 29
system: Jan 28 09:28:27 miljenkos-mbp assetsd[39099] <Warning>: *** Successfully created ordered relationship index
[2014-01-28 09:28:27.6] INFO: Waiting for server to spin up... 30
system: Jan 28 09:28:27 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
[2014-01-28 09:28:27.8] INFO: Waiting for server to spin up... 31
[2014-01-28 09:28:28.0] INFO: Waiting for server to spin up... 32
system: Jan 28 09:28:28 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb029b000
system: Jan 28 09:28:28 miljenkos-mbp MonoTouchDesignServer[39097] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:28:28 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
[2014-01-28 09:28:28.2] INFO: Waiting for server to spin up... 33
[2014-01-28 09:28:28.4] INFO: Waiting for server to spin up... 34
system: Jan 28 09:28:28 --- last message repeated 1 time ---
system: Jan 28 09:28:28 miljenkos-mbp MonoTouchDesignServer[39097] <Warning>: [2014-01-28 09:28:28.4] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057d6a2/server.run
system: Jan 28 09:28:28 miljenkos-mbp MonoTouchDesignServer[39097] <Warning>: [2014-01-28 09:28:28.5] INFO: ASL fetching will start at 356
system: Jan 28 09:28:28 miljenkos-mbp MonoTouchDesignServer[39097] <Warning>: [2014-01-28 09:28:28.5] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057d6a2/server.run
system: Jan 28 09:28:28 miljenkos-mbp MonoTouchDesignServer[39097] <Warning>: Application windows are expected to have a root view controller at the end of application launch
system: Jan 28 09:28:28 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:28:44 --- last message repeated 15 times ---
Jan 28 09:28:44 miljenkos-mbp lsd[39076] <Warning>: LaunchServices: Currently 0 installed placeholders: (
	)
system: Jan 28 09:28:44 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:29:04 --- last message repeated 19 times ---
Jan 28 09:29:04 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) PS: Media stream daemon stopping.
system: Jan 28 09:29:04 miljenkos-mbp mstreamd[39064] <Notice>: (Note ) AS: <MSIOSAlbumSharingDaemon: 0x3a3dd40>: Shared Streams daemon has shut down.
system: Jan 28 09:29:04 miljenkos-mbp mstreamd[39064] <Notice>: (Warn ) mstreamd: mstreamd shutting down.
system: Jan 28 09:29:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:29:34 --- last message repeated 28 times ---
system: Jan 28 09:29:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:30:04 --- last message repeated 29 times ---
Jan 28 09:30:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:30:15 --- last message repeated 11 times ---
Jan 28 09:30:15 miljenkos-mbp cplogd[39082] <Warning>: Exiting.
system: Jan 28 09:30:16 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:30:46 --- last message repeated 29 times ---
Jan 28 09:30:46 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:31:13 --- last message repeated 26 times ---
Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Error>: Could not open database /var/root/Library/Caches/locationd/consolidated.db, error code = 14
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells-local.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-cells.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-wifis.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/clients-b.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/c-trained.plist if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/wifis.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/wifis.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells-local.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/cells-local.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-locations.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-locations.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-cells.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-cells.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-wifis.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/h-wifis.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/compass.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/compass.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/history.db if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/history.db-journal if present
system: Jan 28 09:31:13 miljenkos-mbp locationd[39062] <Notice>: Deleting /tmp/com.xamarin.MTHosting.a057d6a2/Library/Caches/locationd/glgps_nvs.bin if present
system: Jan 28 09:31:13 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:31:33 --- last message repeated 20 times ---
Jan 28 09:31:33 miljenkos-mbp SpringBoard[39067] <Error>: hidd died. Reestablishing connection.
Jan 28 09:31:33 miljenkos-mbp MonoTouchDesignServer[39097] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:31:33 miljenkos-mbp backboardd[39059] <Error>: hidd died. Reestablishing connection.
Jan 28 09:31:33 miljenkos-mbp SpringBoard[39067] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:31:33 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb0219000
system: Jan 28 09:31:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:31:36 --- last message repeated 1 time ---
Jan 28 09:31:36 miljenkos-mbp calaccessd[39155] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:31:36 miljenkos-mbp SpringBoard[39067] <Notice>: 2014-01-28 09:31:36.103|39067|0xdedadf0: Region monitoring not available or enabled. Trigger ignored!
system: Jan 28 09:31:36 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:31:40 --- last message repeated 3 times ---
system: Jan 28 09:31:40 miljenkos-mbp calaccessd[39155] <Notice>: 2014-01-28 09:31:40.253|39155|0x3b0b040: Updating birthday calendar
system: Jan 28 09:31:40 miljenkos-mbp calaccessd[39155] <Notice>: 2014-01-28 09:31:40.254|39155|0x3b0b040: BirthdayCal: Processing 0 people...
system: Jan 28 09:31:40 miljenkos-mbp calaccessd[39155] <Notice>: 2014-01-28 09:31:40.255|39155|0x3b0b040: BirthdayCal: Done. 0 adds, 0 updates, 0 deletes.
system: Jan 28 09:31:40 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:31:41 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb0219000
system: Jan 28 09:31:41 miljenkos-mbp MobileCal[39164] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:31:41 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:31:41 --- last message repeated 1 time ---
Jan 28 09:31:41 miljenkos-mbp calaccessd[39167] <Notice>: BUG in libdispatch client: kevent[EVFILT_VNODE] add: "Bad file descriptor" - 0x9
system: Jan 28 09:31:41 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:31:41 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:32:11 --- last message repeated 29 times ---
Jan 28 09:32:11 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
com.apple.backboardd: 2014-01-28 09:32:31.041 backboardd[39051:2b37] Error getting job dictionary for label UIKitApplication:com.xamarin.MTDesignServer[0xb089]. Error: No such process
com.apple.backboardd: 2014-01-28 09:32:31.070 backboardd[39051:2b37] Unable to delete job with label UIKitApplication:com.xamarin.MTDesignServer[0xb089]. Error: No such process
system: Jan 28 09:32:33 --- last message repeated 21 times ---
Jan 28 09:32:33 miljenkos-mbp MonoTouchDesignServer[39097] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:32:33 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb0219000
system: Jan 28 09:32:33 miljenkos-mbp SpringBoard[39067] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:32:33 miljenkos-mbp backboardd[39059] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:32:33 miljenkos-mbp SpringBoard[39067] <Notice>: 2014-01-28 09:32:33.632|39067|0xe0e6730: Region monitoring not available or enabled. Trigger ignored!
system: Jan 28 09:32:33 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:33:03 --- last message repeated 29 times ---
Jan 28 09:33:03 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:33:26 --- last message repeated 22 times ---
Jan 28 09:33:26 miljenkos-mbp SpringBoard[39067] <Notice>: 2014-01-28 09:33:26.843|39067|0xdf7f4a0: Region monitoring not available or enabled. Trigger ignored!
system: Jan 28 09:33:26 miljenkos-mbp MonoTouchDesignServer[39097] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:33:26 miljenkos-mbp backboardd[39059] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:33:26 miljenkos-mbp SpringBoard[39067] <Error>: hidd died. Reestablishing connection.
system: Jan 28 09:33:26 miljenkos-mbp backboardd[39059] <Error>: __hid_dispatch_pthread_root_queue_create_block_invoke: specific=0x5361080 pthread_self=0xb0219000
system: Jan 28 09:33:26 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:33:31 --- last message repeated 4 times ---
Jan 28 09:33:31 miljenkos-mbp SpringBoard[39067] <Notice>: (Warn ) EventKitUI: EKEventDescriptionGenerator: failed to get me card.
system: Jan 28 09:33:32 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:33:33 --- last message repeated 1 time ---
system: Jan 28 09:33:33 miljenkos-mbp MobileGestaltHelper[39084] <Error>: libMobileGestalt utility.c:570: IPHONE_SIMULATOR_PITCH not found in environment, returning -1
system: Jan 28 09:33:34 --- last message repeated 4 times ---
Jan 28 09:33:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:34:04 --- last message repeated 29 times ---
Jan 28 09:34:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:34:34 --- last message repeated 29 times ---
Jan 28 09:34:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:35:04 --- last message repeated 29 times ---
Jan 28 09:35:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:35:34 --- last message repeated 29 times ---
Jan 28 09:35:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:36:04 --- last message repeated 29 times ---
system: Jan 28 09:36:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:36:34 --- last message repeated 29 times ---
Jan 28 09:36:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:37:04 --- last message repeated 29 times ---
Jan 28 09:37:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:37:34 --- last message repeated 29 times ---
Jan 28 09:37:34 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:38:04 --- last message repeated 29 times ---
Jan 28 09:38:04 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waiting for DataMigrator...
system: Jan 28 09:38:15 --- last message repeated 10 times ---
Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Managed Configuration migrating...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Beginning manifest migration...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Removing duplicated hidden profile identifiers...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed removing duplicated hidden profile identifiers.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Creating stubs...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Removing orphaned profiles...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Transferring profile signer certificates...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Migrating removal passwords...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed migrating removal passwords.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Migrating defaults to managed preferences area...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed migrating defaults.
Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Migrating OTA profiles...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed migrating OTA profiles.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Transferring installation dates...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed transferring installation dates.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Transferring tags to profiles...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed transferring tags.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Removing old profile copies...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed removing old profile copies.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Applying default user settings...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Error) MC: Applying iPad defaults
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Error>: libMobileGestalt SimCapabilities.c:30: can't load simulator capabilities dictionary from (null)
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed applying default user settings.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Migrating settings...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed migrating settings.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Updating client restrictions...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Done updating. 0 client restrictions processed.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Updating profile restrictions...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Done updating. 0 profile restrictions processed.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Tagging managed accounts...
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Completed tagging 0 accounts as managed.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Waking daemons post migration
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) MC: Managed Configuration completed migration.
system: Jan 28 09:38:15 miljenkos-mbp profiled[39063] <Notice>: (Note ) profiled: Service stopping.
[2014-01-28 09:44:36.8] INFO: Starting full reload...
[2014-01-28 09:44:36.8] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39093
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.SimulatorBridge: 2014-01-28 09:44:36.921 SimulatorBridge[39043:1107] Falling back to MobileInstallation
com.apple.lsd: 2014-01-28 09:44:40.056 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:44:40.059 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:44:40.4] INFO: Waiting for server to spin up... 1
[2014-01-28 09:44:40.6] INFO: Waiting for server to spin up... 2
[2014-01-28 09:44:40.8] INFO: Waiting for server to spin up... 3
[2014-01-28 09:44:41.0] INFO: Waiting for server to spin up... 4
[2014-01-28 09:44:41.2] INFO: Waiting for server to spin up... 5
[2014-01-28 09:44:41.4] INFO: Waiting for server to spin up... 6
[2014-01-28 09:44:41.6] INFO: Waiting for server to spin up... 7
[2014-01-28 09:44:41.8] INFO: Waiting for server to spin up... 8
[2014-01-28 09:44:42.0] INFO: Waiting for server to spin up... 9
[2014-01-28 09:44:42.2] INFO: Waiting for server to spin up... 10
[2014-01-28 09:44:42.4] INFO: Waiting for server to spin up... 11
[2014-01-28 09:44:42.6] INFO: Waiting for server to spin up... 12
[2014-01-28 09:44:42.8] INFO: Waiting for server to spin up... 13
[2014-01-28 09:44:43.0] INFO: Waiting for server to spin up... 14
[2014-01-28 09:44:43.2] INFO: Waiting for server to spin up... 15
[2014-01-28 09:44:43.4] INFO: Waiting for server to spin up... 16
[2014-01-28 09:44:43.6] INFO: Waiting for server to spin up... 17
[2014-01-28 09:44:43.8] INFO: Waiting for server to spin up... 18
[2014-01-28 09:44:44.0] INFO: Waiting for server to spin up... 19
[2014-01-28 09:44:44.2] INFO: Waiting for server to spin up... 20
[2014-01-28 09:44:44.4] INFO: Waiting for server to spin up... 21
[2014-01-28 09:44:44.6] INFO: Waiting for server to spin up... 22
[2014-01-28 09:44:44.8] INFO: Waiting for server to spin up... 23
[2014-01-28 09:44:45.0] INFO: Waiting for server to spin up... 24
[2014-01-28 09:44:45.2] INFO: Waiting for server to spin up... 25
[2014-01-28 09:44:45.4] INFO: Waiting for server to spin up... 26
[2014-01-28 09:44:45.6] INFO: Waiting for server to spin up... 27
[2014-01-28 09:44:45.8] INFO: Waiting for server to spin up... 28
[2014-01-28 09:44:46.0] INFO: Waiting for server to spin up... 29
com.xamarin.MTDesignServer: [2014-01-28 09:44:46.0] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057c0d1/server.run
com.xamarin.MTDesignServer: [2014-01-28 09:44:46.1] INFO: ASL fetching will start at 153575
com.xamarin.MTDesignServer: [2014-01-28 09:44:46.1] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:44:46.9] INFO: Fetched iOS SDK data in /var/folders/8b/l3jkjtld7fj2fp3ps1z865rr0000gn/T/xd-support-files-184d9f7f
[2014-01-28 09:44:47.4] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:47.4] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:47.4] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:47.5] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
com.xamarin.MTDesignServer: [2014-01-28 09:44:48.9] INFO: Loading custom control assembly `FieldServiceiOS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' ...
com.xamarin.MTDesignServer: [2014-01-28 09:44:48.9] INFO:   - Found a candidate to satisfy dependency `MonoTouch.Dialog-1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065'
[2014-01-28 09:44:51.7] WARN: Failure #1 (EndOfStreamException) while sending web request. Retrying..
[2014-01-28 09:44:51.7] INFO: Waiting for server to spin up... 1
com.apple.backboardd: 2014-01-28 09:44:51.770 backboardd[39051:1a4f] Application 'UIKitApplication:com.xamarin.MTDesignServer[0x941]' exited abnormally with signal 6: Abort trap: 6
[2014-01-28 09:44:51.9] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39301
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
[2014-01-28 09:44:51.9] ERROR: EnsureSession (counter 0): System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



[2014-01-28 09:44:51.9] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39301
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.SimulatorBridge: 2014-01-28 09:44:51.992 SimulatorBridge[39043:1107] Falling back to MobileInstallation
com.apple.lsd: 2014-01-28 09:44:52.072 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:44:52.073 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:44:52.3] INFO: Waiting for server to spin up... 1
[2014-01-28 09:44:52.5] INFO: Waiting for server to spin up... 2
[2014-01-28 09:44:52.7] INFO: Waiting for server to spin up... 3
[2014-01-28 09:44:52.9] INFO: Waiting for server to spin up... 4
[2014-01-28 09:44:53.1] INFO: Waiting for server to spin up... 5
[2014-01-28 09:44:53.3] INFO: Waiting for server to spin up... 6
[2014-01-28 09:44:53.5] INFO: Waiting for server to spin up... 7
[2014-01-28 09:44:53.7] INFO: Waiting for server to spin up... 8
[2014-01-28 09:44:53.9] INFO: Waiting for server to spin up... 9
[2014-01-28 09:44:54.2] INFO: Waiting for server to spin up... 10
[2014-01-28 09:44:54.4] INFO: Waiting for server to spin up... 11
[2014-01-28 09:44:54.6] INFO: Waiting for server to spin up... 12
[2014-01-28 09:44:54.8] INFO: Waiting for server to spin up... 13
[2014-01-28 09:44:55.0] INFO: Waiting for server to spin up... 14
[2014-01-28 09:44:55.2] INFO: Waiting for server to spin up... 15
[2014-01-28 09:44:55.4] INFO: Waiting for server to spin up... 16
[2014-01-28 09:44:55.6] INFO: Waiting for server to spin up... 17
[2014-01-28 09:44:55.8] INFO: Waiting for server to spin up... 18
[2014-01-28 09:44:56.0] INFO: Waiting for server to spin up... 19
[2014-01-28 09:44:56.2] INFO: Waiting for server to spin up... 20
[2014-01-28 09:44:56.4] INFO: Waiting for server to spin up... 21
[2014-01-28 09:44:56.6] INFO: Waiting for server to spin up... 22
[2014-01-28 09:44:56.8] INFO: Waiting for server to spin up... 23
[2014-01-28 09:44:57.0] INFO: Waiting for server to spin up... 24
com.xamarin.MTDesignServer: [2014-01-28 09:44:57.0] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057c0d1/server.run
com.xamarin.MTDesignServer: [2014-01-28 09:44:57.1] INFO: ASL fetching will start at 153586
com.xamarin.MTDesignServer: [2014-01-28 09:44:57.1] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:44:57.9] INFO: Fetched iOS SDK data in /var/folders/8b/l3jkjtld7fj2fp3ps1z865rr0000gn/T/xd-support-files-184d9f7f
[2014-01-28 09:44:58.0] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:58.0] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:58.0] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:44:58.0] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
com.xamarin.MTDesignServer: [2014-01-28 09:44:59.0] INFO: Loading custom control assembly `FieldServiceiOS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' ...
com.xamarin.MTDesignServer: [2014-01-28 09:44:59.0] INFO:   - Found a candidate to satisfy dependency `MonoTouch.Dialog-1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065'
[2014-01-28 09:45:00.0] WARN: Failure #1 (EndOfStreamException) while sending web request. Retrying..
[2014-01-28 09:45:00.0] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39305
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.backboardd: 2014-01-28 09:45:00.089 backboardd[39051:2b4f] Application 'UIKitApplication:com.xamarin.MTDesignServer[0xcb86]' exited abnormally with signal 6: Abort trap: 6
[2014-01-28 09:45:00.0] ERROR: EnsureSession (counter 1): System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



[2014-01-28 09:45:00.0] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39305
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.SimulatorBridge: 2014-01-28 09:45:00.108 SimulatorBridge[39043:1107] Falling back to MobileInstallation
com.apple.lsd: 2014-01-28 09:45:00.178 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:45:00.180 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:45:00.4] INFO: Waiting for server to spin up... 1
[2014-01-28 09:45:00.6] INFO: Waiting for server to spin up... 2
[2014-01-28 09:45:00.8] INFO: Waiting for server to spin up... 3
[2014-01-28 09:45:01.1] INFO: Waiting for server to spin up... 4
[2014-01-28 09:45:01.3] INFO: Waiting for server to spin up... 5
[2014-01-28 09:45:01.5] INFO: Waiting for server to spin up... 6
[2014-01-28 09:45:01.7] INFO: Waiting for server to spin up... 7
[2014-01-28 09:45:01.9] INFO: Waiting for server to spin up... 8
[2014-01-28 09:45:02.1] INFO: Waiting for server to spin up... 9
[2014-01-28 09:45:02.3] INFO: Waiting for server to spin up... 10
[2014-01-28 09:45:02.5] INFO: Waiting for server to spin up... 11
[2014-01-28 09:45:02.7] INFO: Waiting for server to spin up... 12
[2014-01-28 09:45:02.9] INFO: Waiting for server to spin up... 13
[2014-01-28 09:45:03.1] INFO: Waiting for server to spin up... 14
[2014-01-28 09:45:03.3] INFO: Waiting for server to spin up... 15
[2014-01-28 09:45:03.5] INFO: Waiting for server to spin up... 16
[2014-01-28 09:45:03.7] INFO: Waiting for server to spin up... 17
[2014-01-28 09:45:03.9] INFO: Waiting for server to spin up... 18
[2014-01-28 09:45:04.1] INFO: Waiting for server to spin up... 19
[2014-01-28 09:45:04.3] INFO: Waiting for server to spin up... 20
[2014-01-28 09:45:04.5] INFO: Waiting for server to spin up... 21
[2014-01-28 09:45:04.7] INFO: Waiting for server to spin up... 22
[2014-01-28 09:45:04.9] INFO: Waiting for server to spin up... 23
com.xamarin.MTDesignServer: [2014-01-28 09:45:05.0] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057c0d1/server.run
com.xamarin.MTDesignServer: [2014-01-28 09:45:05.0] INFO: ASL fetching will start at 153597
com.xamarin.MTDesignServer: [2014-01-28 09:45:05.0] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:45:06.0] INFO: Fetched iOS SDK data in /var/folders/8b/l3jkjtld7fj2fp3ps1z865rr0000gn/T/xd-support-files-184d9f7f
[2014-01-28 09:45:06.6] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:06.6] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:06.6] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:06.6] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
com.xamarin.MTDesignServer: [2014-01-28 09:45:07.5] INFO: Loading custom control assembly `FieldServiceiOS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' ...
com.xamarin.MTDesignServer: [2014-01-28 09:45:07.5] INFO:   - Found a candidate to satisfy dependency `MonoTouch.Dialog-1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065'
[2014-01-28 09:45:08.6] WARN: Failure #1 (EndOfStreamException) while sending web request. Retrying..
[2014-01-28 09:45:08.6] INFO: Waiting for server to spin up... 1
com.apple.backboardd: 2014-01-28 09:45:08.683 backboardd[39051:2b4f] Application 'UIKitApplication:com.xamarin.MTDesignServer[0xe78]' exited abnormally with signal 6: Abort trap: 6
[2014-01-28 09:45:08.8] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39309
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
[2014-01-28 09:45:08.8] ERROR: EnsureSession (counter 2): System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



[2014-01-28 09:45:08.8] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39309
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.SimulatorBridge: 2014-01-28 09:45:08.909 SimulatorBridge[39043:1107] Falling back to MobileInstallation
com.apple.lsd: 2014-01-28 09:45:08.974 lsd[39055:1107] updating identifier store
com.apple.lsd: 2014-01-28 09:45:08.976 lsd[39055:1107] Attempting to store identifiers file
[2014-01-28 09:45:09.2] INFO: Waiting for server to spin up... 1
[2014-01-28 09:45:09.4] INFO: Waiting for server to spin up... 2
[2014-01-28 09:45:09.6] INFO: Waiting for server to spin up... 3
[2014-01-28 09:45:09.8] INFO: Waiting for server to spin up... 4
[2014-01-28 09:45:10.1] INFO: Waiting for server to spin up... 5
[2014-01-28 09:45:10.3] INFO: Waiting for server to spin up... 6
[2014-01-28 09:45:10.5] INFO: Waiting for server to spin up... 7
[2014-01-28 09:45:10.7] INFO: Waiting for server to spin up... 8
[2014-01-28 09:45:10.9] INFO: Waiting for server to spin up... 9
[2014-01-28 09:45:11.1] INFO: Waiting for server to spin up... 10
[2014-01-28 09:45:11.3] INFO: Waiting for server to spin up... 11
[2014-01-28 09:45:11.5] INFO: Waiting for server to spin up... 12
[2014-01-28 09:45:11.7] INFO: Waiting for server to spin up... 13
[2014-01-28 09:45:11.9] INFO: Waiting for server to spin up... 14
[2014-01-28 09:45:12.1] INFO: Waiting for server to spin up... 15
[2014-01-28 09:45:12.3] INFO: Waiting for server to spin up... 16
[2014-01-28 09:45:12.5] INFO: Waiting for server to spin up... 17
[2014-01-28 09:45:12.7] INFO: Waiting for server to spin up... 18
[2014-01-28 09:45:12.9] INFO: Waiting for server to spin up... 19
[2014-01-28 09:45:13.1] INFO: Waiting for server to spin up... 20
[2014-01-28 09:45:13.3] INFO: Waiting for server to spin up... 21
[2014-01-28 09:45:13.5] INFO: Waiting for server to spin up... 22
[2014-01-28 09:45:13.7] INFO: Waiting for server to spin up... 23
com.xamarin.MTDesignServer: [2014-01-28 09:45:13.8] INFO: Listener setup on end point: /tmp/com.xamarin.MTHosting.a057c0d1/server.run
com.xamarin.MTDesignServer: [2014-01-28 09:45:13.8] INFO: ASL fetching will start at 153608
com.xamarin.MTDesignServer: [2014-01-28 09:45:13.9] INFO: Now listening on port /tmp/com.xamarin.MTHosting.a057c0d1/server.run
[2014-01-28 09:45:14.2] INFO: Fetched iOS SDK data in /var/folders/8b/l3jkjtld7fj2fp3ps1z865rr0000gn/T/xd-support-files-184d9f7f
[2014-01-28 09:45:14.5] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:14.5] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:14.5] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
[2014-01-28 09:45:14.5] ERROR: Removing resource from availableResNames due to error:
GLib.GException: Unrecognized image file format
  at Gdk.PixbufLoader.Write (System.Byte[] buf, UInt64 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.Write (System.Byte[] bytes, UInt32 count) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.LoadFromStream (System.IO.Stream input) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader.InitFromStream (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Gdk.PixbufLoader..ctor (System.IO.Stream stream) [0x00000] in <filename unknown>:0 
  at Xwt.GtkBackend.ImageHandler.LoadFromStream (System.IO.Stream stream) [0x00002] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt.Gtk/Xwt.GtkBackend/ImageHandler.cs:45 
  at Xwt.Drawing.Image.FromStream (System.IO.Stream stream) [0x0001a] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/monodevelop/main/external/xwt/Xwt/Xwt.Drawing/Image.cs:271 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<ConvertBundleResources>m__1BA (MonoTouch.Design.Client.BundleResource rsrc) [0x00014] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1551 
com.xamarin.MTDesignServer: [2014-01-28 09:45:15.5] INFO: Loading custom control assembly `FieldServiceiOS, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' ...
com.xamarin.MTDesignServer: [2014-01-28 09:45:15.5] INFO:   - Found a candidate to satisfy dependency `MonoTouch.Dialog-1, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065'
[2014-01-28 09:45:16.6] WARN: Failure #1 (EndOfStreamException) while sending web request. Retrying..
[2014-01-28 09:45:16.6] WARN: Error checking IsRunning (returning false): System.ArgumentException: Can't find process with ID 39312
  at System.Diagnostics.Process.GetProcessById (Int32 processId) [0x00034] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/System/System.Diagnostics/Process.cs:816 
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.get_IsRunning () [0x0001e] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:70 
com.apple.backboardd: 2014-01-28 09:45:16.637 backboardd[39051:2b4f] Application 'UIKitApplication:com.xamarin.MTDesignServer[0x2ee1]' exited abnormally with signal 6: Abort trap: 6
[2014-01-28 09:45:16.6] ERROR: EnsureSession (counter 3): System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



[2014-01-28 09:45:16.6] ERROR: Unexpected exception while reloading XML for MonoTouch.Design.Client.IPhoneDesignerItem[]
System.AggregateException: One or more errors occured ---> System.Exception: EnsureSession counter too high. Server may be repeatedly crashing. ---> System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



  --- End of inner exception stack trace ---
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x00128] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1496 
  at System.Threading.Tasks.TaskActionInvoker+FuncInvoke`1[System.Object[]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:241 
  at System.Threading.Tasks.Task.InnerInvoke () [0x00028] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:505 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
 --> (Inner exception 0) System.Exception: EnsureSession counter too high. Server may be repeatedly crashing. ---> System.AggregateException: One or more errors occured ---> System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 


  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x0006f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1477 
 --> (Inner exception 0) System.AggregateException:  ---> System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

  --- End of inner exception stack trace ---
  at System.Threading.Tasks.Task.Wait (Int32 millisecondsTimeout, CancellationToken cancellationToken) [0x0004a] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:651 
  at System.Threading.Tasks.Task.Wait () [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:619 
  at MonoTouch.Design.Client.IPhoneDesignerSession.<SetupSession>m__1B8 (System.Threading.Tasks.Task t) [0x00001] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1527 
  at System.Threading.Tasks.TaskActionInvoker+ActionTaskInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:112 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) System.AggregateException: One or more errors occured ---> MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
  --- End of inner exception stack trace ---
  at MonoTouch.Design.Tasks+<WhenAll>c__AnonStorey1E.<>m__37 (System.Threading.Tasks.Task[] collection) [0x0006c] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Shared/TaskExtensions.cs:109 
  at System.Threading.Tasks.TaskActionInvoker+ActionTasksInvoke.Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00007] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:136 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 
 --> (Inner exception 0) MonoTouch.Design.Client.InvalidSessionException: Session invalid
  at MonoTouch.Design.Client.Mac.MacServerProcessConnection.EnsureServerRunning (Boolean throwIfNotRunning, Boolean forceRecycle) [0x0003b] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client.Mac/MacServerProcessConnection.cs:115 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest (System.Action`1 send, System.Action`1 recv, Boolean throwIfNotRunning) [0x00008] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:198 
  at MonoTouch.Design.Client.ServerProcessConnection.SendRequest[SerializableDictionary`1] (MonoTouch.Design.CommandRequest req, Boolean throwIfNotRunning) [0x0002f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:181 
  at MonoTouch.Design.Client.ServerProcessConnection.PostAssemblies (MonoTouch.Design.DesignSession session, MonoTouch.Design.AssemblyResource[] assemblyDatas) [0x0003f] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/Connection/ServerProcessConnection.cs:139 
  at MonoTouch.Design.Client.IPhoneDesignerSession+<SendAssemblies>c__AnonStorey76.<>m__199 (System.Threading.Tasks.Task`1 t) [0x00062] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:536 
  at System.Threading.Tasks.TaskActionInvoker+FuncTaskInvoke`2[MonoTouch.Design.AssemblyResource[],System.Collections.Generic.Dictionary`2[System.String,MonoTouch.Design.CustomClassInfo]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:331 
  at System.Threading.Tasks.Task.InnerInvoke () [0x0000b] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:503 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 



  --- End of inner exception stack trace ---
  at MonoTouch.Design.Client.IPhoneDesignerSession+<EnsureSession>c__AnonStorey84`1[System.Object[]].<>m__1B7 () [0x00128] in /Users/builder/data/lanes/monodevelop-lion-monodevelop-4.3.1-branch/c8e0387a/source/md-addins/Xamarin.Designer.iOS/MonoTouch.Design.Client/IPhoneDesignerSession.cs:1496 
  at System.Threading.Tasks.TaskActionInvoker+FuncInvoke`1[System.Object[]].Invoke (System.Threading.Tasks.Task owner, System.Object state, System.Threading.Tasks.Task context) [0x00000] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/TaskActionInvoker.cs:241 
  at System.Threading.Tasks.Task.InnerInvoke () [0x00028] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:505 
  at System.Threading.Tasks.Task.ThreadStart () [0x00097] in /private/tmp/source/bockbuild-mono-3.2.6/profiles/mono-mac-xamarin/build-root/mono-3.2.6/mcs/class/corlib/System.Threading.Tasks/Task.cs:404 

