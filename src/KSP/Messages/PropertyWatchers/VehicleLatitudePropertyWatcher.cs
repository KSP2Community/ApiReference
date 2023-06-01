﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.VehicleLatitudePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/VehicleLatitude", false, "Active Vessel Latitude Coordinate value in double.", "Checks the Active Sim VesselComponent.Latitude which is it's telemetry TelemetryComponent Latitude value.")]
  public class VehicleLatitudePropertyWatcher : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VehicleLatitudePropertyWatcher() => throw null;
  }
}
