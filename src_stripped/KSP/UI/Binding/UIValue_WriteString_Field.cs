﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.Binding.UIValue_WriteString_Field
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UI.Binding.Core;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI.Binding
{
  public class UIValue_WriteString_Field : UIValueBinder<string>
  {
    [SerializeField]
    private TMP_InputField field;
    [Header("Configurations")]
    [SerializeField]
    private bool submitEachKeyPress;
    [SerializeField]
    private bool valueChangeDeselects;
    [SerializeField]
    private bool autoRefreshOnSubmit;

    private string TextValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFieldEditEnd(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFieldValueChanged(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RedrawValue(bool instant = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleValueSubmit(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIValue_WriteString_Field() => throw null;
  }
}
