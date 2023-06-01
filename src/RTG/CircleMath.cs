﻿// Decompiled with JetBrains decompiler
// Type: RTG.CircleMath
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public static class CircleMath
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector3> Calc3DExtentPoints(
      Vector3 circleCenter,
      float circleRadius,
      Quaternion circleRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<Vector2> Calc2DExtentPoints(
      Vector2 circleCenter,
      float circleRadius,
      float degreeCircleRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Raycast(
      Ray ray,
      out float t,
      Vector3 circleCenter,
      float circleRadius,
      Vector3 circleNormal,
      CircleEpsilon epsilon = default (CircleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RaycastWire(
      Ray ray,
      out float t,
      Vector3 circleCenter,
      float circleRadius,
      Vector3 circleNormal,
      CircleEpsilon epsilon = default (CircleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains3DPoint(
      Vector3 point,
      bool checkOnPlane,
      Vector3 circleCenter,
      float circleRadius,
      Vector3 circleNormal,
      CircleEpsilon epsilon = default (CircleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Contains2DPoint(
      Vector2 point,
      Vector2 circleCenter,
      float circleRadius,
      CircleEpsilon epsilon = default (CircleEpsilon))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool Is2DPointOnBorder(
      Vector2 point,
      Vector2 circleCenter,
      float circleRadius,
      CircleEpsilon epsilon = default (CircleEpsilon))
    {
      throw null;
    }
  }
}
