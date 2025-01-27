﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPVehicleController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Vehicle Controller", -21)]
  public class VPVehicleController : VehicleBase, ISerializationCallbackReceiver
  {
    public Inertia.Settings inertia;
    public SteeringAids.Settings steeringAids;
    public SpeedControl.Settings speedControl;
    public VPAxle[] axles;
    [FormerlySerializedAs("transmission")]
    public Driveline.Settings driveline;
    public Differential.Settings differential;
    public Differential.Settings centerDifferential;
    public Differential.Settings interAxleDifferential;
    public TorqueSplitter.Settings torqueSplitter;
    public Steering.Settings steering;
    public Brakes.Settings brakes;
    public TireFriction tireFriction;
    public Engine.Settings engine;
    public Engine.ClutchSettings clutch;
    public Gearbox.Settings gearbox;
    public Retarder.Settings retarder;
    public Brakes.AbsSettings antiLock;
    public TractionControl.Settings tractionControl;
    public StabilityControl.Settings stabilityControl;
    [FormerlySerializedAs("antiSlip")]
    public AntiSpin.Settings antiSpin;
    [Range(0.0f, 1f)]
    public float engineReactionFactor;
    [Range(0.0f, 1f)]
    public float parkModeReactionFactor;
    public float maxSubsystemsEnergy;
    [SerializeField]
    private int m_version;
    private Inertia m_inertia;
    private Steering m_steering;
    private Brakes m_brakes;
    private Engine m_engine;
    private Gearbox m_gearbox;
    private Retarder m_retarder;
    private Driveline m_driveline;
    private StabilityControl m_stabilityControl;
    private AntiSpin m_antiSpin;
    private EnergyProvider m_energyProvider;
    private int m_firstSteerableAxle;
    private float m_wheelbase;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private VPVehicleController() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnAfterDeserialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnBeforeSerialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoUpdateBlocks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoUpdateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetInternalObject(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GearboxSwitchingGears() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTractionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySteeringAids(ref float steerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySteeringHelp(ref float steerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySteeringLimit(ref float steerInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyStabilityControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAntiSpin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetOptimalGearShiftRatio() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetWheelFinalRatio(int wheelIndex, int gear = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;
  }
}
