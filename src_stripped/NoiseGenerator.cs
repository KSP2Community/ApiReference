﻿// Decompiled with JetBrains decompiler
// Type: NoiseGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class NoiseGenerator
{
  private readonly int[] A;
  private int[] T;
  private int i;
  private int j;
  private int k;
  private float onesixth;
  private float onethird;
  private float s;
  private float u;
  private float v;
  private float w;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public NoiseGenerator() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSeed(int[] seed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public string GetSeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float coherentNoise(
    float x,
    float y,
    float z,
    int octaves = 1,
    int multiplier = 25,
    float amplitude = 0.5f,
    float lacunarity = 2f,
    float persistence = 0.9f)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int getDensity(Vector3 loc) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float noise(float x, float y, float z) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float kay(int a) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int shuffle(int i, int j, int k) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int b(int i, int j, int k, int B) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int b(int N, int B) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int fastfloor(float n) => throw null;
}
