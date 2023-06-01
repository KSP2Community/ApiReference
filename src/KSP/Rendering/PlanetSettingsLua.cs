﻿// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetSettingsLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  public class PlanetSettingsLua
  {
    public const string PLANET_SCATTER_ENABLED_NAME = "PlanetScatterEnabled";
    public const string RENDER_PLANET_COLLIDERS_ENABLED_NAME = "RenderPlanetCollidersEnabled";
    public const string PLANET_LOW_QUALITY_ENABLED_NAME = "PlanetLowQualityEnabled";
    private IScriptEnvironment scriptEnvironment;
    private GraphicsSettings graphicsSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetSettingsLua(GraphicsSettings settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetPlanetScatterEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPlanetScatterEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetRenderPlanetCollidersEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetRenderPlanetCollidersEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetPlanetLowQualityEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPlanetLowQualityEnabled() => throw null;
  }
}
