﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_CompoundPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_CompoundPart : PartBehaviourModule
  {
    [SerializeField]
    public Data_CompoundPart DataCompoundPart;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator WaitAndCreateConnector(IObjectAssemblyPart otherPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator WaitAndCreateConnector(PartBehavior otherPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_CompoundPart() => throw null;
  }
}
