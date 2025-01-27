﻿// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.impl.moonsharp.ResourceContainerStateConverter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.State;
using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace KSP.ScriptInterop.impl.moonsharp
{
  [TypeInterop(typeof (ResourceContainerComponentState), "ResourceContainerState", new string[] {"KSP.Sim.State.ResourceContainerState"})]
  public class ResourceContainerStateConverter : 
    IStructConverter<ResourceContainerComponentState>,
    IValueConverter<ResourceContainerComponentState>,
    IValueConverter<ResourceContainerComponentState?>
  {
    private TypeInterop typeInterop;
    private MoonSharpBinding.Struct<ResourceContainerComponentState> moonsharpBinding;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerStateConverter(TypeInterop typeInterop) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ResourceContainerComponentState IValueConverter<ResourceContainerComponentState>.ToValue(
      DynValue scriptValue)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ResourceContainerComponentState? clrValue, Script script) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerComponentState? ToValue(DynValue scriptValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynValue FromValue(ResourceContainerComponentState clrValue, Script script) => throw null;
  }
}
