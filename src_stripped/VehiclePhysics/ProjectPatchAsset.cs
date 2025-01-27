﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.ProjectPatchAsset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [CreateAssetMenu(fileName = "New Project Patch Asset", menuName = "Vehicle Physics/Project Patch Asset", order = 520)]
  public class ProjectPatchAsset : ScriptableObject
  {
    [TextArea(4, 10)]
    public string description;
    [Tooltip("The patch will be applied to the files within this path including subfolders")]
    public string path;
    [Tooltip("Extensions to apply the patch to separated by semicolons. An empty value (trailing or duplicate semicolon) includes files without extension.")]
    public string extensions;
    public List<ProjectPatchAsset.Change> changes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProjectPatchAsset() => throw null;

    [Serializable]
    public class Change
    {
      public string name;
      public string fromGuid;
      public string toGuid;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Change() => throw null;
    }
  }
}
