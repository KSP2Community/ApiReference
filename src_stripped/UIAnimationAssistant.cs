﻿// Decompiled with JetBrains decompiler
// Type: UIAnimationAssistant
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UIAnimationAssistant : MonoBehaviour
{
  [HideInInspector]
  public static string mspOpen;
  [HideInInspector]
  public static string mspClose;
  [HideInInspector]
  public static string fadeOpen;
  [HideInInspector]
  public static string fadeClose;
  public Button toggleButton;
  public Button resetButton;
  public bool resetStateOnButtonPress;
  public UIAnimationAssistantInfo[] animationInfo;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UseNormalSprite() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UseHighlightedSprite() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UsePressedSprite() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UseDisabledSprite() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public UIAnimationAssistant() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static UIAnimationAssistant() => throw null;
}
