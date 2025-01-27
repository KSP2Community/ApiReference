﻿// Decompiled with JetBrains decompiler
// Type: KSP.Game.ActionGroupActionElement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using KSP.Sim;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class ActionGroupActionElement : ApiDataContext
  {
    [DataProperty("DisplayName")]
    public PropertyReadonly<string> DisplayName;
    [DataProperty("MethodName")]
    public PropertyReadonly<string> MethodName;
    [DataProperty("ActionType")]
    public PropertyReadonly<KSPActionType> ActionType;
    [DataProperty("IsMapped")]
    public PropertyExternal<bool> IsMapped;
    [DataProperty("IsMappedToSelected")]
    public PropertyExternal<bool> IsMappedToSelected;
    private ModuleActionGroupAction _action;
    private IProperty<KSPActionGroup> _selectedActionGroup;

    [DataAction("RemoveAction")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveAction() => throw null;

    [DataAction("AddAction")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupActionElement(
      ModuleActionGroupAction action,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateElement(
      ModuleActionGroupAction action,
      PropertyReadonly<KSPActionGroup> selectedActionGroupProperty)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectedChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetIsMappedToSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetIsMappedToSelected(bool addToActionGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateExternalProperties() => throw null;
  }
}
