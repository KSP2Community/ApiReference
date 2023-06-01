﻿// Decompiled with JetBrains decompiler
// Type: Uber.Scatter.SphereTerrainSampleJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;

namespace Uber.Scatter
{
  [BurstCompile(CompileSynchronously = true)]
  public struct SphereTerrainSampleJob : IJobParallelFor
  {
    [ReadOnly]
    public NativeArray<VegetationSpawnLocationInstance> SpawnLocationList;
    public NativeArray<float3> Position;
    public NativeArray<quaternion> Rotation;
    public NativeArray<float3> Scales;
    public NativeArray<float3> TerrainNormal;
    public NativeArray<float> BiomeDistance;
    public NativeArray<byte> TerrainTextureData;
    public NativeArray<int> RandomNumberIndex;
    public NativeArray<float> DistanceFalloff;
    public NativeArray<float> VegetationMaskDensity;
    public NativeArray<float> VegetationMaskScale;
    public NativeArray<byte> TerrainSourceIDs;
    public NativeArray<byte> TextureMaskData;
    public NativeArray<byte> Excluded;
    public NativeArray<byte> HeightmapSampled;
    public byte TerrainSourceID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float3 PolarToCartesian(float2 polar, float radius) => throw null;
  }
}
