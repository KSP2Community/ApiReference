﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Drag
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Drag : ModuleData
  {
    [KSPDefinition]
    public bool BodyLiftEnabled;
    [KSPDefinition]
    public bool DragEnabled;
    [KSPDefinition]
    public float bodyLiftMultiplier;
    [KSPDefinition]
    public List<DragCube> cubes;
    [KSPDefinition]
    [HideInInspector]
    public float[] weightedArea;
    [KSPDefinition]
    [HideInInspector]
    public float[] weightedExposedArea;
    [KSPDefinition]
    [HideInInspector]
    public float[] weightedDrag;
    [KSPDefinition]
    [HideInInspector]
    public float[] weightedDragMultiplier;
    [KSPDefinition]
    [HideInInspector]
    public float[] weightedDepth;
    [HideInInspector]
    [KSPDefinition]
    public Vector3 weightedCenter;
    [KSPDefinition]
    [HideInInspector]
    public Vector3 weightedSize;
    [KSPDefinition]
    [HideInInspector]
    public bool isDragCubeRotated;
    [KSPDefinition]
    [HideInInspector]
    public Quaternion dragCubeRotation;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = false)]
    public bool UpdateExposedArea;
    [KSPState]
    [LocalizedField("PartModules/Drag/DragDirection")]
    [PAMDisplayControl(SortIndex = 0)]
    public ModuleProperty<Vector3> DragForceDirection;
    [LocalizedField("PartModules/Drag/DragMagnitude")]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    public ModuleProperty<float> DragForceMagnitude;
    [LocalizedField("PartModules/Drag/LiftDirection")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState]
    public ModuleProperty<Vector3> LiftForceDirection;
    [LocalizedField("PartModules/Drag/LiftMagnitude")]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState]
    public ModuleProperty<float> LiftForceMagnitude;
    [LocalizedField("PartModules/Drag/ReferenceArea")]
    [PAMDisplayControl(SortIndex = 4)]
    [KSPState]
    public ModuleProperty<float> ReferenceArea;
    [LocalizedField("PartModules/Drag/ExposedArea")]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState]
    public ModuleProperty<float> ExposedArea;
    [PAMDisplayControl(SortIndex = 6)]
    [LocalizedField("PartModules/Drag/TotalArea")]
    [KSPState]
    public ModuleProperty<float> TotalArea;
    [JsonIgnore]
    public Data_Drag.CubeData cubeData;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAeroDataForDirection(
      Vector3 direction,
      float machNumber,
      ref Data_Drag.CubeData retData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragWeightsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCubeWeight(string name, float weight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOcclusionMultiplier(float multiplier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragCubeRotation(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragCubeRotation(bool isRotated) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ResetCubeArray(float[] arr) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetCubeArray(float[] outputArray, float[] inputArray, float multiply = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddCubeArray(float[] outputArray, float[] inputArray, float multiply = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void MultiplyCubeArray(float[] arr, float multiply) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetMagnitudeString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetAreaString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetExposedAreaString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetTotalAreaString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetNormalizedVectorString(object dragVectorObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetParachuteDragStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetEstimatedChuteDragForCube(
      string cubeName,
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float ComputeAreaDragSimple(DragCube targetCube, Vector3 direction, double machNumber) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Drag() => throw null;

    public struct CubeData
    {
      public Vector3 PartVelocityDirection;
      public Vector3 LiftForce;
      public float Area;
      public float AreaDrag;
      public float Depth;
      public float CrossSectionalArea;
      public float DragCoeff;
      public float TaperDot;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CubeData(Data_Drag.CubeData oldCube) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Reset() => throw null;
    }

    [Serializable]
    public class DragForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_Drag.DragForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragForce() => throw null;
    }

    [Serializable]
    public class BodyLiftForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_Drag.BodyLiftForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BodyLiftForce() => throw null;
    }
  }
}
