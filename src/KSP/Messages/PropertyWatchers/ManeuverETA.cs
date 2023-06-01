﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.ManeuverETA
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Maneuver/NormalizedManeuverTime", true, "Time to maneuver in seconds. Negative going to maneuver. Positive if past Maneuver. 9999 ", "")]
  public class ManeuverETA : ManeuverPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverETA() => throw null;
  }
}
