// GENERATED AUTOMATICALLY FROM 'Assets/EditorPrefabs/InputSystems/MainInputActions.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class MainInputActions : InputActionAssetReference
{
    public MainInputActions()
    {
    }
    public MainInputActions(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // MovementBase
        m_MovementBase = asset.GetActionMap("MovementBase");
        m_MovementBase_HorizontalMovement = m_MovementBase.GetAction("HorizontalMovement");
        m_MovementBase_Jump = m_MovementBase.GetAction("Jump");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_MovementBase = null;
        m_MovementBase_HorizontalMovement = null;
        m_MovementBase_Jump = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // MovementBase
    private InputActionMap m_MovementBase;
    private InputAction m_MovementBase_HorizontalMovement;
    private InputAction m_MovementBase_Jump;
    public struct MovementBaseActions
    {
        private MainInputActions m_Wrapper;
        public MovementBaseActions(MainInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMovement { get { return m_Wrapper.m_MovementBase_HorizontalMovement; } }
        public InputAction @Jump { get { return m_Wrapper.m_MovementBase_Jump; } }
        public InputActionMap Get() { return m_Wrapper.m_MovementBase; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MovementBaseActions set) { return set.Get(); }
    }
    public MovementBaseActions @MovementBase
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new MovementBaseActions(this);
        }
    }
}
