﻿// Decompiled with JetBrains decompiler
// Type: RTG.PrismMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class PrismMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> CalcTriangPrismCornerPoints(
      Vector3 baseCenter,
      float baseWidth,
      float baseDepth,
      float topWidth,
      float topDepth,
      float height,
      Quaternion prismRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastTriangular(
      Ray ray,
      out float t,
      Vector3 baseCenter,
      float baseWidth,
      float baseDepth,
      float topWidth,
      float topDepth,
      float height,
      Quaternion prismRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ContainsPoint(
      Vector3 point,
      Vector3 baseCenter,
      float baseWidth,
      float baseDepth,
      float topWidth,
      float topDepth,
      float height,
      Quaternion prismRotation,
      PrismEpsilon epsilon = default (PrismEpsilon))
    {
      throw null;
    }
  }
}
