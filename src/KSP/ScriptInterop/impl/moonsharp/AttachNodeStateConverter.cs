﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.AttachNodeStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (AttachNodeState), "AttachNodeState", new string[] {"KSP.Sim.State.AttachNodeState"})]
  public class AttachNodeStateConverter : 
    IStructConverter<AttachNodeState>,
    IValueConverter<AttachNodeState>,
    IValueConverter<AttachNodeState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<AttachNodeState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    AttachNodeState IValueConverter<AttachNodeState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachNodeState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AttachNodeState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(AttachNodeState clrValue, Script script) => throw null;
  }
}
