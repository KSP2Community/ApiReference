﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Testing.IntegrationTests.IntegrationTestHud
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Sim.Testing.IntegrationTests
{
  public class IntegrationTestHud : MonoBehaviour
  {
    public Text LogText;
    public GameObject CommandBar;
    public InputField CommandInput;
    private ITestManager testManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLogAppended(string textToAppend) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCommandEntered(string command) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegrationTestHud() => throw null;
  }
}
