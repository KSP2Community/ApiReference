﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.PhysicsOwnerStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (PhysicsOwnerState), "PhysicsOwnerState", new string[] {"KSP.Sim.State.PhysicsOwnerState"})]
  public class PhysicsOwnerStateConverter : 
    IStructConverter<PhysicsOwnerState>,
    IValueConverter<PhysicsOwnerState>,
    IValueConverter<PhysicsOwnerState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<PhysicsOwnerState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicsOwnerStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    PhysicsOwnerState IValueConverter<PhysicsOwnerState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PhysicsOwnerState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicsOwnerState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(PhysicsOwnerState clrValue, Script script) => throw null;
  }
}
