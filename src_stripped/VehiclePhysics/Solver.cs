﻿// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Solver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class Solver
  {
    private Block[] m_blocks;
    private int m_wheelCount;
    private Solver.StateVector[] m_states;
    private Solver.DerivativeVector[] m_derivatives;
    private bool m_RK4enabled;
    public const float minInertia = 0.01f;
    public const float minWheelRadius = 0.01f;
    public const float minWheelMass = 0.01f;
    public static float viscousCouplingRate;
    public static float viscousLockedRatio;

    public static float time
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static float deltaTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetDebugTime(float t, float dt) => throw null;

    public string resultMessage
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Initialize(Wheel[] wheels, bool enableRK4) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Integrate(float t, float dt, int steps, bool useRK4) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetViscousLockingDt(float lockRatio) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void EulerStep(
      ref Block.State In,
      ref Block.Derivative Der,
      ref Block.State Out)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void EulerStepL(
      ref Block.State In,
      ref Block.Derivative Der,
      ref Block.State Out)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EulerStep(Block.State[] In, Block.Derivative[] Der, Block.State[] Out) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntegrateEuler(
      Block.State[] S,
      Block.Derivative[] D,
      float t,
      float dt,
      int subSteps)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EvaluateRK4(
      Block.State[] S,
      Block.State[] Stemp,
      Block.Derivative[] DIn,
      float t,
      float dt,
      Block.Derivative[] DOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeRK4Derivative(
      ref Block.Derivative A,
      ref Block.Derivative B,
      ref Block.Derivative C,
      ref Block.Derivative D,
      ref Block.Derivative DOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeRK4DerivativeT(
      ref Block.Derivative A,
      ref Block.Derivative B,
      ref Block.Derivative C,
      ref Block.Derivative D,
      ref Block.Derivative DOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeRK4Derivative(
      Block.Derivative[] A,
      Block.Derivative[] B,
      Block.Derivative[] C,
      Block.Derivative[] D,
      Block.Derivative[] DOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void IntegrateRK4(
      Block.State[] S,
      Block.State[] Stemp,
      Block.Derivative[] D,
      Block.Derivative[] Da,
      Block.Derivative[] Db,
      Block.Derivative[] Dc,
      Block.Derivative[] Dd,
      float t,
      float dt)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeDerivative(Block.State[] S, Block.Derivative[] Out) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Block[] GetBlockArray() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Solver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Solver() => throw null;

    private class StateVector
    {
      private Block.State[] m_states;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StateVector(int length) => throw null;

      public Block.State[] states
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }

    private class DerivativeVector
    {
      private Block.Derivative[] m_derivatives;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DerivativeVector(int length) => throw null;

      public Block.Derivative[] derivatives
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }
    }
  }
}
