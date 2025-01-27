﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SpeedControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class SpeedControl
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetThrottle(
      SpeedControl.Settings settings,
      int[] inputData,
      int[] vehicleData,
      Gearbox.Type gearboxType = Gearbox.Type.Manual)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpeedControl() => throw null;

    [Serializable]
    public class Settings : ISerializationCallbackReceiver
    {
      public bool cruiseControl;
      public float cruiseSpeed;
      public float minSpeedForCC;
      [Space(5f)]
      public bool speedLimiter;
      public float speedLimit;
      public bool limitReverseSpeed;
      [Space(5f)]
      [Range(0.0f, 3f)]
      public float throttleSlope;
      [NonSerialized]
      private const float minControlledSpeed = 1.388889f;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void OnAfterDeserialize() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void OnBeforeSerialize() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
