﻿// Decompiled with JetBrains decompiler
// Type: AnimatorStateWrapper`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;

public class AnimatorStateWrapper<TMonoBehaviour> : SealedSMB where TMonoBehaviour : MonoBehaviour
{
  protected TMonoBehaviour m_MonoBehaviour;
  private bool m_FirstFrameHappened;
  private bool m_LastFrameHappened;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Initialise(Animator animator, TMonoBehaviour monoBehaviour) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void InternalInitialise(Animator animator, TMonoBehaviour monoBehaviour) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override sealed void OnStateEnter(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override sealed void OnStateUpdate(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override sealed void OnStateExit(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnStart(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStateEnter(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLTransitionToStateUpdate(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStatePostEnter(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStatePreExit(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStateEnter(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStatePostEnter(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStatePreExit(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public virtual void OnSLStateExit(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimatorStateWrapper() => throw null;
}
