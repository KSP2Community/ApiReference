﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyRingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class CelestialBodyRingData
  {
    public double innerRadius;
    public double outerRadius;
    public FloatCurve density;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyRingData() => throw null;
  }
}