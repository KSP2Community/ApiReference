﻿// Decompiled with JetBrains decompiler
// Type: KSCBuildingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSCBuildingAudio : MonoBehaviour
{
  [NonReorderable]
  public AK.Wwise.Event[] onBuildingHighlightedStart;
  [NonReorderable]
  public AK.Wwise.Event[] onBuildingHighlightedStop;
  private bool _hasAudioObject;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PlayHover() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StopHover() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSCBuildingAudio() => throw null;
}
