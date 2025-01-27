﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.PropertyTableAssigner`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class PropertyTableAssigner<T> : IPropertyTableAssigner
  {
    private PropertyTableAssigner m_InternalAssigner;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyTableAssigner(params string[] expectedMissingProperties) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddExpectedMissingProperty(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AssignObject(T obj, Table data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyTableAssigner GetTypeUnsafeAssigner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubassignerForType(Type propertyType, IPropertyTableAssigner assigner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSubassigner<SubassignerType>(PropertyTableAssigner<SubassignerType> assigner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IPropertyTableAssigner.AssignObjectUnchecked(object o, Table data) => throw null;
  }
}
