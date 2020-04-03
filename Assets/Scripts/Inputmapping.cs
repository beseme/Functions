// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Inputmapping.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Inputmapping : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Inputmapping()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputmapping"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""7fea6b36-cf5b-4846-83ec-4a12f9ccacd7"",
            ""actions"": [
                {
                    ""name"": ""Cross"",
                    ""type"": ""Button"",
                    ""id"": ""e164cb6a-26f0-4ce1-a380-8608b3601ec2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Square"",
                    ""type"": ""Button"",
                    ""id"": ""59c5c5fb-7179-4374-8f46-7e92eb066a0e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Triangle"",
                    ""type"": ""Button"",
                    ""id"": ""ac2ed014-3772-4d9b-9073-904402dcbaaf"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Circle"",
                    ""type"": ""Button"",
                    ""id"": ""442b2ee1-cadb-4b17-ac02-3f7a482aa699"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D UP"",
                    ""type"": ""Button"",
                    ""id"": ""ec3ba3b0-a568-46cc-a4ed-60b1df6fcc3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D R"",
                    ""type"": ""Button"",
                    ""id"": ""92e18ce8-a0a6-4631-ace5-5ad34f222dab"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D L"",
                    ""type"": ""Button"",
                    ""id"": ""90b12dba-e02e-47ba-82d7-01a4580e5639"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""D Down"",
                    ""type"": ""Button"",
                    ""id"": ""b1031dc6-34cc-402e-ac0b-a536c2e2db76"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stick L"",
                    ""type"": ""Button"",
                    ""id"": ""70a7247f-304f-4e12-97bb-5e3cb0e2b490"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Stick R"",
                    ""type"": ""Button"",
                    ""id"": ""282c0270-0e1c-4fee-a057-d4a01e904b26"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""34bd41b1-a96f-48be-aca4-c9633b23e20d"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cross"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d186d8eb-61c9-4073-9e1b-3a687267e61e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Square"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc72b75f-878d-4d96-b3b0-a6ef3d3fe9ed"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Triangle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f0c81ad-559c-465b-8b74-cebceaa1c515"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Circle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04ba1d37-48b4-475d-ac2b-cdced18a8687"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D UP"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4a9a277-3181-467b-8ce1-83e0f427faba"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec9ac490-149f-4a32-ae0b-040f1c45c6fb"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f61423b-96ee-4ac0-a58a-c8c6e8cb160e"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""D Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f816d83a-174d-4d11-89e3-7ab1664aa735"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stick L"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""deb0c529-576d-4868-9445-df07571b6d4d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Stick R"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Cross = m_Gamepad.FindAction("Cross", throwIfNotFound: true);
        m_Gamepad_Square = m_Gamepad.FindAction("Square", throwIfNotFound: true);
        m_Gamepad_Triangle = m_Gamepad.FindAction("Triangle", throwIfNotFound: true);
        m_Gamepad_Circle = m_Gamepad.FindAction("Circle", throwIfNotFound: true);
        m_Gamepad_DUP = m_Gamepad.FindAction("D UP", throwIfNotFound: true);
        m_Gamepad_DR = m_Gamepad.FindAction("D R", throwIfNotFound: true);
        m_Gamepad_DL = m_Gamepad.FindAction("D L", throwIfNotFound: true);
        m_Gamepad_DDown = m_Gamepad.FindAction("D Down", throwIfNotFound: true);
        m_Gamepad_StickL = m_Gamepad.FindAction("Stick L", throwIfNotFound: true);
        m_Gamepad_StickR = m_Gamepad.FindAction("Stick R", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Cross;
    private readonly InputAction m_Gamepad_Square;
    private readonly InputAction m_Gamepad_Triangle;
    private readonly InputAction m_Gamepad_Circle;
    private readonly InputAction m_Gamepad_DUP;
    private readonly InputAction m_Gamepad_DR;
    private readonly InputAction m_Gamepad_DL;
    private readonly InputAction m_Gamepad_DDown;
    private readonly InputAction m_Gamepad_StickL;
    private readonly InputAction m_Gamepad_StickR;
    public struct GamepadActions
    {
        private @Inputmapping m_Wrapper;
        public GamepadActions(@Inputmapping wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cross => m_Wrapper.m_Gamepad_Cross;
        public InputAction @Square => m_Wrapper.m_Gamepad_Square;
        public InputAction @Triangle => m_Wrapper.m_Gamepad_Triangle;
        public InputAction @Circle => m_Wrapper.m_Gamepad_Circle;
        public InputAction @DUP => m_Wrapper.m_Gamepad_DUP;
        public InputAction @DR => m_Wrapper.m_Gamepad_DR;
        public InputAction @DL => m_Wrapper.m_Gamepad_DL;
        public InputAction @DDown => m_Wrapper.m_Gamepad_DDown;
        public InputAction @StickL => m_Wrapper.m_Gamepad_StickL;
        public InputAction @StickR => m_Wrapper.m_Gamepad_StickR;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Cross.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCross;
                @Cross.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCross;
                @Cross.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCross;
                @Square.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSquare;
                @Square.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSquare;
                @Square.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnSquare;
                @Triangle.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnTriangle;
                @Triangle.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnTriangle;
                @Triangle.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnTriangle;
                @Circle.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCircle;
                @Circle.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCircle;
                @Circle.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnCircle;
                @DUP.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDUP;
                @DUP.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDUP;
                @DUP.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDUP;
                @DR.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDR;
                @DR.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDR;
                @DR.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDR;
                @DL.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDL;
                @DL.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDL;
                @DL.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDL;
                @DDown.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDDown;
                @DDown.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDDown;
                @DDown.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDDown;
                @StickL.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickL;
                @StickL.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickL;
                @StickL.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickL;
                @StickR.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickR;
                @StickR.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickR;
                @StickR.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnStickR;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cross.started += instance.OnCross;
                @Cross.performed += instance.OnCross;
                @Cross.canceled += instance.OnCross;
                @Square.started += instance.OnSquare;
                @Square.performed += instance.OnSquare;
                @Square.canceled += instance.OnSquare;
                @Triangle.started += instance.OnTriangle;
                @Triangle.performed += instance.OnTriangle;
                @Triangle.canceled += instance.OnTriangle;
                @Circle.started += instance.OnCircle;
                @Circle.performed += instance.OnCircle;
                @Circle.canceled += instance.OnCircle;
                @DUP.started += instance.OnDUP;
                @DUP.performed += instance.OnDUP;
                @DUP.canceled += instance.OnDUP;
                @DR.started += instance.OnDR;
                @DR.performed += instance.OnDR;
                @DR.canceled += instance.OnDR;
                @DL.started += instance.OnDL;
                @DL.performed += instance.OnDL;
                @DL.canceled += instance.OnDL;
                @DDown.started += instance.OnDDown;
                @DDown.performed += instance.OnDDown;
                @DDown.canceled += instance.OnDDown;
                @StickL.started += instance.OnStickL;
                @StickL.performed += instance.OnStickL;
                @StickL.canceled += instance.OnStickL;
                @StickR.started += instance.OnStickR;
                @StickR.performed += instance.OnStickR;
                @StickR.canceled += instance.OnStickR;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);
    public interface IGamepadActions
    {
        void OnCross(InputAction.CallbackContext context);
        void OnSquare(InputAction.CallbackContext context);
        void OnTriangle(InputAction.CallbackContext context);
        void OnCircle(InputAction.CallbackContext context);
        void OnDUP(InputAction.CallbackContext context);
        void OnDR(InputAction.CallbackContext context);
        void OnDL(InputAction.CallbackContext context);
        void OnDDown(InputAction.CallbackContext context);
        void OnStickL(InputAction.CallbackContext context);
        void OnStickR(InputAction.CallbackContext context);
    }
}
