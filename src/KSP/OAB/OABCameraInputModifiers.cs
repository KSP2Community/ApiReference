﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.OABCameraInputModifiers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ModularCamera;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  public static class OABCameraInputModifiers
  {
    private static readonly float TAN_1;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputModifier Constant(float constant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputModifier Constant(Func<float> getConstant) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputModifier DistRatio(Func<float> getBaseDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputModifier AtanDistRatio(Func<float> getBaseDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CameraInputModifier DistToTarget(Transform target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float CalculateDistRatio(ICameraDriverReadOnly driver, float baseDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float CalculateDistRatio(ICameraDriverReadOnly driver, Func<float> getBaseDist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static OABCameraInputModifiers() => throw null;
  }
}
