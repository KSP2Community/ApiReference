﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Fairing
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Fairing : PartComponentModule
  {
    protected Data_Fairing _dataFairing;
    protected AttachNodeData _dynamicAttachNode;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static AttachNodeData CreateDynamicFlightAttachNode(
      PartComponent part,
      Data_Fairing data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SyncDynamicAttachNodeToData(
      AttachNodeData dynamicAttachNode,
      Data_Fairing data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Fairing() => throw null;
  }
}
