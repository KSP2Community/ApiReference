﻿// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Culling.JobCullingGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies.Utility.Culling
{
  public class JobCullingGroup
  {
    public NativeList<float> DistanceBandList;
    public NativeList<BoundingSphereInfo> BundingSphereInfoList;
    public NativeList<int> VisibleCellIndexList;
    public CameraCullingMode CameraCullingMode;
    public JobCullingType JobCullingType;
    public bool AddShadowCells;
    public NativeArray<Plane> FrustumPlanes;
    private NativeList<int> _eventList;
    private NativeList<int> _distanceBandEventList;
    private static readonly Plane[] FrustumPlaneArray;
    private Vector3 _floatingOriginOffset;

    public Camera TargetCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform TargetTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public JobCullingGroup.StateChanged OnStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public JobCullingGroup.StateChanged OnDistanceBandStateChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobCullingGroup(JobCullingType jobCullingType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFloatingOriginOffset(Vector3 floatingOriginOffset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetTargetCameraPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JobHandle Cull(JobHandle dependsOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessDistanceBandEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static JobCullingGroup() => throw null;

    public delegate void StateChanged(JobCullingGroupEvent sphere);
  }
}
