﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.ToggleDropdown
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ToggleDropdown : KerbalMonoBehaviour
  {
    [SerializeField]
    private Toggle _toggle;
    [SerializeField]
    private GameObject _target;
    [SerializeField]
    private GameObject _dropdownBlocker;
    [SerializeField]
    private DOTweenAnimation _defaultRotationAnimation;
    private GameObject _currentDropdownBlocker;
    private CanvasGroup _currentDropdownBlockerCanvasGroup;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleValueChanged(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncTargetWithToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void deactivateToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleDropdown() => throw null;
  }
}
