﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Platforms.PlatformAutoDetector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Loaders;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Platforms
{
  public static class PlatformAutoDetector
  {
    private static bool? m_IsRunningOnAOT;
    private static bool m_AutoDetectionsDone;

    public static bool IsRunningOnMono
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsRunningOnClr4
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsRunningOnUnity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsPortableFramework
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsUnityNative
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsUnityIL2CPP
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static bool IsRunningOnAOT
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AutoDetectPlatformFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IPlatformAccessor GetDefaultPlatform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static IScriptLoader GetDefaultScriptLoader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PlatformAutoDetector() => throw null;
  }
}
