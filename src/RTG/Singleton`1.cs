﻿// Decompiled with JetBrains decompiler
// Type: RTG.Singleton`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public abstract class Singleton<T> where T : class, new()
  {
    private static T _instance;

    public static T Get
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Singleton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Singleton() => throw null;
  }
}
