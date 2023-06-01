﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.BVHBBox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.MeshTerrains;
using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.Utility.BVHTree
{
  [Serializable]
  public class BVHBBox
  {
    public Vector3 Center;
    public Vector3 Min;
    public Vector3 Max;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IntersectRay(BVHRay r, float3 min, float3 max, out float hitDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHBBox() => throw null;
  }
}
