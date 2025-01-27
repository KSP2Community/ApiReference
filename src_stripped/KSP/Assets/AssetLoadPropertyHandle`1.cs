﻿// Decompiled with JetBrains decompiler
// Type: KSP.Assets.AssetLoadPropertyHandle`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Assets
{
  public struct AssetLoadPropertyHandle<TAsset> : IDisposable where TAsset : UnityEngine.Object
  {
    private Action<TAsset> _changeCallback;
    private bool _isAlive;

    public readonly AssetLoadProperty<TAsset> LoadProperty
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssetLoadPropertyHandle(AssetLoadProperty<TAsset> loadProperty) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AssetLoadPropertyHandle(AssetLoadPropertyHandle<TAsset> other) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChangeCallback(Action<TAsset> changeCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
