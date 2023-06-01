﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleVesselDeltaV
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.DeltaV;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/DeltaV", false, "Returns the current main assembly or active vessel total DeltaV, -1 for no active vessel or Assembly", "")]
  public class VehicleVesselDeltaV : VehiclePropertyWatcher
  {
    protected VesselDeltaVComponent deltaVComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleVesselDeltaV() => throw null;
  }
}
