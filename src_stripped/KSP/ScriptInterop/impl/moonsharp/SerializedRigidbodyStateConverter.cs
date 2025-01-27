﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.SerializedRigidbodyStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (SerializedRigidbodyState), "SerializedRigidbodyState", new string[] {"KSP.Sim.SerializedRigidbodyState"})]
  public class SerializedRigidbodyStateConverter : 
    IStructConverter<SerializedRigidbodyState>,
    IValueConverter<SerializedRigidbodyState>,
    IValueConverter<SerializedRigidbodyState?>
  {
    private TypeInterop typeInterop;
    private SerializedRigidbodyState defaults;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedRigidbodyStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    SerializedRigidbodyState IValueConverter<SerializedRigidbodyState>.ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedRigidbodyState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedRigidbodyState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(SerializedRigidbodyState clrValue, Script script) => throw null;
  }
}
