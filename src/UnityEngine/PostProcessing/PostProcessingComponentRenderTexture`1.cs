﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.PostProcessingComponentRenderTexture`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public abstract class PostProcessingComponentRenderTexture<T> : PostProcessingComponent<T> where T : PostProcessingModel
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Prepare(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PostProcessingComponentRenderTexture() => throw null;
  }
}
