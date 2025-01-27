﻿// Decompiled with JetBrains decompiler
// Type: KSP.UI.KSCLineRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using Shapes;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class KSCLineRenderer : KerbalMonoBehaviour
  {
    private const float VIEWPORT_CENTER = 0.5f;
    private const float VIEWPORT_LEFT_SIDE = 0.0f;
    private const float VIEWPORT_RIGHT_SIDE = 1f;
    private const float VIEWPORT_TOP_SIDE = 0.0f;
    private const float VIEWPORT_BOTTOM_SIDE = 1f;
    private const float VIEWPORT_BEHIND = 0.0f;
    private const int LINE_RENDERER_STARTING_INDEX = 0;
    private const int LINE_RENDERER_MIDDLE_INDEX = 1;
    private const int LINE_RENDERER_END_INDEX = 2;
    [SerializeField]
    [Header("Off-Screen Indicator")]
    private GameObject _offscreenIndicator;
    [SerializeField]
    private Vector3 _offscreenIndicatorInitialPosition;
    private Polyline _line;
    private Transform _offscreenIndicatorTransform;
    private CanvasGroup _offscreenIndicatorCanvasGroup;

    public Polyline Line
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CanvasGroup OffscreenIndicatorCanvasGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator DrawTargetablebuildingLine(GameObject obj, Image ui) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSCLineRenderer() => throw null;
  }
}
