﻿// Decompiled with JetBrains decompiler
// Type: UniLinq.OrderedEnumerable`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UniLinq
{
  internal abstract class OrderedEnumerable<TElement> : 
    IOrderedEnumerable<TElement>,
    IEnumerable<TElement>,
    IEnumerable
  {
    private IEnumerable<TElement> source;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected OrderedEnumerable(IEnumerable<TElement> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IEnumerator<TElement> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract SortContext<TElement> CreateContext(SortContext<TElement> current) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract IEnumerable<TElement> Sort(IEnumerable<TElement> source) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(
      Func<TElement, TKey> selector,
      IComparer<TKey> comparer,
      bool descending)
    {
      throw null;
    }
  }
}
