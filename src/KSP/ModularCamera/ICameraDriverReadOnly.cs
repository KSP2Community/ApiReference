﻿// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.ICameraDriverReadOnly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using UnityEngine;

namespace KSP.ModularCamera
{
  public interface ICameraDriverReadOnly
  {
    Matrix4x4 WorldToPivot { get; }

    Matrix4x4 PivotToWorld { get; }

    Matrix4x4 WorldToGimbal { get; }

    Matrix4x4 GimbalToWorld { get; }

    Quaternion PivotLocalRotation { get; }

    Quaternion PivotToWorldRotation { get; }

    Quaternion GimbalLocalRotation { get; }

    Quaternion GimbalWorldRotation { get; }

    Vector3 GimbalWorldForward { get; }

    Vector3 GimbalWorldUp { get; }

    Vector3 GimbalWorldRight { get; }

    float Pitch { get; }

    float Yaw { get; }

    float Roll { get; }

    float TargetDistance { get; }

    float CameraDistance { get; }

    Vector3 TargetOffset { get; }

    Vector3 CameraOffset { get; }

    Vector3 PivotPosition { get; }

    Vector3 TargetPosition { get; }

    Vector3 CameraPosition { get; }

    bool IsInputInterpreted(CameraInputBinding binding);

    bool IsInputModified(CameraInputBinding binding);

    CameraInputValueList GetModifiedInputs(
      CameraInputBinding binding,
      CameraInputValueList rawInputs);
  }
}
