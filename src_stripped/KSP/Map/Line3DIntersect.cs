﻿// Decompiled with JetBrains decompiler
// Type: KSP.Map.Line3DIntersect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using Shapes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class Line3DIntersect : KerbalMonoBehaviour
  {
    [Header("Settings")]
    [SerializeField]
    private float _thickness;
    [SerializeField]
    private float _rayLength;
    [SerializeField]
    private float _closeBeginTrigger;
    [SerializeField]
    private float _farLeaveTrigger;
    [Header("Links")]
    [SerializeField]
    private Camera _castCamera;
    [SerializeField]
    private Image _flag;
    [SerializeField]
    private Image _close;
    [SerializeField]
    private Image _far;
    [SerializeField]
    private Image _cur;
    [SerializeField]
    private TextMeshProUGUI _tValueText;
    [SerializeField]
    private TextMeshProUGUI _isVisibleText;
    [SerializeField]
    private GameObject _indicatorTemplate;
    [SerializeField]
    [Header("Stress test")]
    private bool _stressTest;
    [SerializeField]
    private int _sressPoints;
    [SerializeField]
    private float _stressBoundLower;
    [SerializeField]
    private float _stressBoundUpper;
    private Ray _ray;
    private Utils.SegmentInfo _closestSegment;
    private List<Vector3> _points;
    private bool _isShowingLineItem;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraPreRender(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawPoints(PolylinePath polyPath, Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Line3DIntersect() => throw null;
  }
}
