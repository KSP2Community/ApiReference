﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.StagingUIDriverBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Sim.DeltaV;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System;
using System.Runtime.CompilerServices;

namespace KSP.UI
{
  public class StagingUIDriverBase
  {
    protected ContextBindRoot _stagingUI;
    protected StagingDataProvider _stagingDataProvider;
    protected VesselDeltaVComponent _deltaVDataProvider;
    protected Action _updateNotifier;
    protected bool _isInitialized;

    public VesselDeltaVComponent DeltaVDataProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataContext GetStagingDataContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(ContextBindRoot stagingUI, bool isOAB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnStageChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool HasInAllParts(IGGuid unique) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StagingUIDriverBase() => throw null;
  }
}
