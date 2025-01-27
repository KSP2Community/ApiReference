﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.DataStructs.FastStackDynamic`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.DataStructs
{
  internal class FastStackDynamic<T> : List<T>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FastStackDynamic(int startingCapacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(int idxofs, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Push(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Expand(int size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Zero(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Peek(int idxofs = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CropAtCount(int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLast(int cnt = 1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T Pop() => throw null;
  }
}
