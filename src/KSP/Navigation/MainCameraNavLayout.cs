﻿// Decompiled with JetBrains decompiler
// Type: KSP.Navigation.MainCameraNavLayout
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Navigation
{
  public class MainCameraNavLayout : 
    ADynamicNavLayout,
    IMainCameraSelectableRegister,
    INavElementRegister
  {
    [SerializeField]
    [HideInInspector]
    private string _layoutTag;

    public override Camera Camera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string LayoutTag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddMainCameraSelectable(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveSelectable(Selectable item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MainCameraNavLayout() => throw null;
  }
}
