﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnlyDatabaseExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IResourceContainerReadOnlyDatabaseExtensions
  {
    private const LogFilter LOG_FILTER = (LogFilter) 8388608;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string LOG_PREFIX([CallerMemberName] string memberName = "") => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ComputeResourcesTotalMass(
      this IResourceContainerReadOnly container,
      ResourceDefinitionDatabase definitionDatabase)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double ComputeResourceStoredMass(
      this IResourceContainerReadOnly container,
      ResourceDefinitionID resourceID,
      ResourceDefinitionDatabase definitionDatabase)
    {
      throw null;
    }
  }
}
