﻿// Decompiled with JetBrains decompiler
// Type: LibNoise.Modifiers.DisplaceInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace LibNoise.Modifiers
{
  public class DisplaceInput : IModule
  {
    public IModule SourceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IModule XDisplaceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IModule YDisplaceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IModule ZDisplaceModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DisplaceInput(
      IModule sourceModule,
      IModule xDisplaceModule,
      IModule yDisplaceModule,
      IModule zDisplaceModule)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3d coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(Vector3 coordinate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetValue(double x, double y, double z) => throw null;
  }
}