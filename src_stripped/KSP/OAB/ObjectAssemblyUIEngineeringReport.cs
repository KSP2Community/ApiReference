﻿// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyUIEngineeringReport
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.UI;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.OAB
{
  [RequireComponent(typeof (KSP2UIWindow))]
  public class ObjectAssemblyUIEngineeringReport : PopUpUIManagerBase
  {
    public GameObject FlawListLineItemPrefab;
    public Transform FlawListRoot;
    private ObjectAssemblyUIEvents _eventsUI;
    private OABSessionInformation _stats;
    private Coroutine _updateFlawsCoroutine;
    private ObjectAssemblyUIEngineeringReportAssemblyStats _assemblyStatsUIHandler;
    private KSP2UIWindow _uiWindow;
    private CanvasGroup _canvasGroup;
    private bool _isInitialized;
    private AssemblyPartsPicker _assemblyPartsPicker;
    private RectTransform _flawListRootRect;
    private OABSideBar _sideBar;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      OABSessionInformation stats,
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI,
      AssemblyPartsPicker assemblyPartsPicker,
      OABSideBar sideBar)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWindowResized(RectTransform rect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDataAndUi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateUi() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateConcernsList(bool updateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator ProcessUpdate(bool updateData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleInteractivity(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetVisibilityOfManager(bool val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyUIEngineeringReport() => throw null;
  }
}
