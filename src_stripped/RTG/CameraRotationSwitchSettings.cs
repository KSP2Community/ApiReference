﻿// Decompiled with JetBrains decompiler
// Type: RTG.CameraRotationSwitchSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class CameraRotationSwitchSettings : Settings
  {
    private static readonly float _minConstantDuration;
    [SerializeField]
    private CameraRotationSwitchMode _switchMode;
    [SerializeField]
    private CameraRotationSwitchType _switchType;
    [SerializeField]
    private float _constantSwitchDurationInSeconds;
    [SerializeField]
    private float _smoothValue;

    public CameraRotationSwitchMode SwitchMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CameraRotationSwitchType SwitchType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ConstantSwitchDurationInSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float SmoothValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraRotationSwitchSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CameraRotationSwitchSettings() => throw null;
  }
}
