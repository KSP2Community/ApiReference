﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.ValueBinding01_Intro
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.UI
{
  public class ValueBinding01_Intro : MonoBehaviour
  {
    [SerializeField]
    private UIValueBinder changeIndicator;
    [SerializeField]
    private UIValueBinder text;
    [SerializeField]
    private UIValueBinder field;
    [SerializeField]
    [Header("Mock Data")]
    private string stringValue;
    private PropertyExternal<string> stringProp;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueBinding01_Intro() => throw null;
  }
}
