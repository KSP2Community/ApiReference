﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.VisibilityChangedFilterManualJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;

namespace AwesomeTechnologies.Utility
{
  [BurstCompile]
  public struct VisibilityChangedFilterManualJob : IJob
  {
    [ReadOnly]
    public NativeList<ItemSelectorInstanceInfo> InstanceList;
    public NativeList<int> VisibilityChangedIndexList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute() => throw null;
  }
}
