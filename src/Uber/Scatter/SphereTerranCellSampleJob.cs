﻿// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.SphereTerranCellSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace Uber.Scatter
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SphereTerranCellSampleJob : IJobParallelFor
  {
    public NativeArray<Bounds> VegetationCellBoundsList;
    public float TerrainMinHeight;
    public float TerrainMaxHeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
