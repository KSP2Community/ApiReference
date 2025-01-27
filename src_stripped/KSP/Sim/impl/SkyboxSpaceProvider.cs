﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SkyboxSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class SkyboxSpaceProvider : MonoBehaviour, ISkyboxSpaceProvider, ISkyboxSpaceFrame
  {
    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation SkyboxToRotation(QuaternionD sceneRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD SkyboxToRotation(QuaternionD sceneRotation, ICoordinateSystem outputFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToSkybox(Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToSkybox(ICoordinateSystem referenceFrame, QuaternionD localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SkyboxSpaceProvider() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform ISkyboxSpaceProvider.get_transform() => throw null;
  }
}
