﻿// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtShadowRingFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  [ExecuteInEditMode]
  [HelpURL("https://bitbucket.org/Darkcoder/space-graphics-toolkit/wiki/SgtShadowRingFilter")]
  [AddComponentMenu("Space Graphics Toolkit/SGT Shadow Ring Filter")]
  [RequireComponent(typeof (SgtShadowRing))]
  public class SgtShadowRingFilter : MonoBehaviour
  {
    public Texture2D Source;
    public TextureFormat Format;
    public int Iterations;
    [NonSerialized]
    private Texture2D generatedTexture;
    [NonSerialized]
    private SgtShadowRing cachedShadowRing;
    [NonSerialized]
    private bool cachedShadowRingSet;
    [NonSerialized]
    private static Color[] bufferA;
    [NonSerialized]
    private static Color[] bufferB;

    public Texture2D GeneratedTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SgtShadowRing CachedShadowRing
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Update Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTexture() => throw null;

    [ContextMenu("Apply Texture")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void WritePixel(int x) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SwapBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SgtShadowRingFilter() => throw null;
  }
}
