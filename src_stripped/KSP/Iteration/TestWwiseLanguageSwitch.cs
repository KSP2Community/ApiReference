﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.TestWwiseLanguageSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.Logging;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration
{
  public class TestWwiseLanguageSwitch : MonoBehaviour
  {
    private const LogFilter LOGTAG = (LogFilter) 8;
    public Event sound;
    private uint _playingID;
    private float _secondsUntilRestart;
    [Header("click to set to 'English'")]
    public bool setEnglish;
    [Header("click to set to 'Spanish'")]
    public bool setSpanish;
    private const string ENGLISH_LANGUAGE = "English";
    private const string SPANISH_LANGUAGE = "Spanish";
    [Header("enter language, then hit update")]
    [Space]
    public string language;
    public bool updateLanguage;
    private bool _haveSound;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestartSound() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleEventCallbacks(
      object in_cookie,
      AkCallbackType in_type,
      AkCallbackInfo in_info)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestWwiseLanguageSwitch() => throw null;
  }
}
