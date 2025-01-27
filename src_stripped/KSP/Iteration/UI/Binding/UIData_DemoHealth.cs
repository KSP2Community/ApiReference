﻿// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.UI.Binding.UIData_DemoHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Iteration.Data;
using KSP.UI.Binding;
using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Iteration.UI.Binding
{
  public class UIData_DemoHealth : UIDataBinder<IDemoHealth>
  {
    [Header("Bound Elements")]
    [SerializeField]
    private UIValue_ReadIsDead_Icon deadIndicator;
    [SerializeField]
    private UIValue_ReadNumber_Text healthText;
    [SerializeField]
    private string healthNumberFormat;
    [SerializeField]
    private UIValue_ReadNumber_Bar healthBar;
    [Header("Other Elements")]
    [SerializeField]
    private Button reviveButton;
    [SerializeField]
    private Button killButton;
    [SerializeField]
    private Button hurtButton;
    [SerializeField]
    private Button healButton;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReviveClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKillClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHurtClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHealClicked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void ClearDataCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MaxLives_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CurLives_ValueChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHealthMaxUI(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawOnBoundValueChanged(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RedrawButtonStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIData_DemoHealth() => throw null;
  }
}
