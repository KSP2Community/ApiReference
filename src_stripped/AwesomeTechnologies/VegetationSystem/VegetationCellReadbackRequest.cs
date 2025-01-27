﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCellReadbackRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationCellReadbackRequest
  {
    public VegetationCellReadbackRequestType VegetationCellReadbackRequestType;
    public AsyncGPUReadbackRequest ReadbackRequest;
    public VegetationCell VegetationCell;
    public int VegetationPackageIndex;
    public int VegetationItemIndex;
    public NativeArray<int> ItemCountNativeArray;
    public NativeArray<ScatterInstance> ScatterInstanceNativeArray;
    public ComputeBuffer InstanceArgs;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCellReadbackRequest() => throw null;
  }
}
