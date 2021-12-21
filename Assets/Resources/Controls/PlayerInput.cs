// GENERATED AUTOMATICALLY FROM 'Assets/Resources/Controls/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1adbb043-a5b9-4f9e-baec-507282f625d4"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""1f25fe36-2238-49d8-9d44-70e97a59a731"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""4112b67d-d30e-4c69-a7dd-0ead01810054"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c09c70ae-c1fe-4069-a95d-cbd3ffb65af2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""52d8e680-46f4-4b48-afaf-91f2c3e40dda"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""16456e99-d888-4553-b805-61d360421238"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b4dc5143-4c49-4a22-805b-027af4296667"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""62a5fa93-3366-4c0e-b651-961770a2a044"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ed1e67f8-dfcd-4cb3-b7f6-3461b165f269"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c50a52cd-5de8-4616-89cf-393a89ea058f"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6dd4d48-5c7e-4bf0-b81c-9d56164b2887"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Drone"",
            ""id"": ""edb7f26c-4bd7-43af-97c2-44e2cb324c91"",
            ""actions"": [
                {
                    ""name"": ""FrontLeft"",
                    ""type"": ""Value"",
                    ""id"": ""cdca24a1-ee35-451c-8c27-e43d75654434"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FrontRight"",
                    ""type"": ""Value"",
                    ""id"": ""4b6f13b4-1517-48ab-b4e8-ba39e00840a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RearLeft"",
                    ""type"": ""Value"",
                    ""id"": ""69f706f1-6c9d-41b2-bc3c-aa1dccbbab50"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RearRight"",
                    ""type"": ""Value"",
                    ""id"": ""7eb86670-65ac-405a-be15-f8d6f8d3f652"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""36e51084-1f2a-47b7-985d-8b9a938d41ce"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""66fb4208-bdf3-43dd-b314-06fd5e5d0b61"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""45cf113c-e0d7-4258-a5cf-a06699bf2a63"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8410fc12-657f-4ae5-a3b5-755cbda32c72"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e1710a7b-5ae7-4914-8c2e-b592ab68b229"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""22bd0748-30d8-4c42-897d-013827370867"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d1eac678-d0fa-4ea9-a51e-f4440c15a67d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bf1ac93b-75ee-401c-95e0-42c07fecdfa6"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FrontRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""20fb8b25-4c6f-4eaf-840b-644645642e8a"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""55b83629-a568-41c8-9775-bba31c4bc805"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearLeft"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""16f889e7-a1e6-4c19-b59a-36e43b019eb2"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0a8cc4ea-60d7-4eb7-9649-9d1e45d392fb"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""203ea84c-5745-41f4-98d6-b74bfa378f08"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearRight"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6752ca8e-59ea-4949-b0d5-03578eb70e49"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RearRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""DroneAxis"",
            ""id"": ""8ad8f27c-6a06-4c8e-ba16-c3a5cf79a643"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Value"",
                    ""id"": ""e724745f-56e3-4d71-a511-ce675bf2a3ad"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PitchRoll"",
                    ""type"": ""Value"",
                    ""id"": ""d160ea0e-a32a-4ddd-941a-bb44398f5a09"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""c91b6b12-7aa6-415f-a471-8adefdace125"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""be9b3833-2aec-4507-85c6-d23c65605c42"",
                    ""path"": ""*/{SecondaryTrigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b98e5a2a-018f-4366-855b-6ba6207bc31c"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PitchRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""77afa406-d2fe-4a76-8cf2-10e5684f9d6d"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // Drone
        m_Drone = asset.FindActionMap("Drone", throwIfNotFound: true);
        m_Drone_FrontLeft = m_Drone.FindAction("FrontLeft", throwIfNotFound: true);
        m_Drone_FrontRight = m_Drone.FindAction("FrontRight", throwIfNotFound: true);
        m_Drone_RearLeft = m_Drone.FindAction("RearLeft", throwIfNotFound: true);
        m_Drone_RearRight = m_Drone.FindAction("RearRight", throwIfNotFound: true);
        // DroneAxis
        m_DroneAxis = asset.FindActionMap("DroneAxis", throwIfNotFound: true);
        m_DroneAxis_Thrust = m_DroneAxis.FindAction("Thrust", throwIfNotFound: true);
        m_DroneAxis_PitchRoll = m_DroneAxis.FindAction("PitchRoll", throwIfNotFound: true);
        m_DroneAxis_Yaw = m_DroneAxis.FindAction("Yaw", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @PlayerInput m_Wrapper;
        public PlayerActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Drone
    private readonly InputActionMap m_Drone;
    private IDroneActions m_DroneActionsCallbackInterface;
    private readonly InputAction m_Drone_FrontLeft;
    private readonly InputAction m_Drone_FrontRight;
    private readonly InputAction m_Drone_RearLeft;
    private readonly InputAction m_Drone_RearRight;
    public struct DroneActions
    {
        private @PlayerInput m_Wrapper;
        public DroneActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @FrontLeft => m_Wrapper.m_Drone_FrontLeft;
        public InputAction @FrontRight => m_Wrapper.m_Drone_FrontRight;
        public InputAction @RearLeft => m_Wrapper.m_Drone_RearLeft;
        public InputAction @RearRight => m_Wrapper.m_Drone_RearRight;
        public InputActionMap Get() { return m_Wrapper.m_Drone; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneActions set) { return set.Get(); }
        public void SetCallbacks(IDroneActions instance)
        {
            if (m_Wrapper.m_DroneActionsCallbackInterface != null)
            {
                @FrontLeft.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontLeft;
                @FrontLeft.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontLeft;
                @FrontLeft.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontLeft;
                @FrontRight.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontRight;
                @FrontRight.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontRight;
                @FrontRight.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnFrontRight;
                @RearLeft.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearLeft;
                @RearLeft.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearLeft;
                @RearLeft.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearLeft;
                @RearRight.started -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearRight;
                @RearRight.performed -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearRight;
                @RearRight.canceled -= m_Wrapper.m_DroneActionsCallbackInterface.OnRearRight;
            }
            m_Wrapper.m_DroneActionsCallbackInterface = instance;
            if (instance != null)
            {
                @FrontLeft.started += instance.OnFrontLeft;
                @FrontLeft.performed += instance.OnFrontLeft;
                @FrontLeft.canceled += instance.OnFrontLeft;
                @FrontRight.started += instance.OnFrontRight;
                @FrontRight.performed += instance.OnFrontRight;
                @FrontRight.canceled += instance.OnFrontRight;
                @RearLeft.started += instance.OnRearLeft;
                @RearLeft.performed += instance.OnRearLeft;
                @RearLeft.canceled += instance.OnRearLeft;
                @RearRight.started += instance.OnRearRight;
                @RearRight.performed += instance.OnRearRight;
                @RearRight.canceled += instance.OnRearRight;
            }
        }
    }
    public DroneActions @Drone => new DroneActions(this);

    // DroneAxis
    private readonly InputActionMap m_DroneAxis;
    private IDroneAxisActions m_DroneAxisActionsCallbackInterface;
    private readonly InputAction m_DroneAxis_Thrust;
    private readonly InputAction m_DroneAxis_PitchRoll;
    private readonly InputAction m_DroneAxis_Yaw;
    public struct DroneAxisActions
    {
        private @PlayerInput m_Wrapper;
        public DroneAxisActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_DroneAxis_Thrust;
        public InputAction @PitchRoll => m_Wrapper.m_DroneAxis_PitchRoll;
        public InputAction @Yaw => m_Wrapper.m_DroneAxis_Yaw;
        public InputActionMap Get() { return m_Wrapper.m_DroneAxis; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DroneAxisActions set) { return set.Get(); }
        public void SetCallbacks(IDroneAxisActions instance)
        {
            if (m_Wrapper.m_DroneAxisActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnThrust;
                @PitchRoll.started -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnPitchRoll;
                @PitchRoll.performed -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnPitchRoll;
                @PitchRoll.canceled -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnPitchRoll;
                @Yaw.started -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_DroneAxisActionsCallbackInterface.OnYaw;
            }
            m_Wrapper.m_DroneAxisActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @PitchRoll.started += instance.OnPitchRoll;
                @PitchRoll.performed += instance.OnPitchRoll;
                @PitchRoll.canceled += instance.OnPitchRoll;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
            }
        }
    }
    public DroneAxisActions @DroneAxis => new DroneAxisActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IDroneActions
    {
        void OnFrontLeft(InputAction.CallbackContext context);
        void OnFrontRight(InputAction.CallbackContext context);
        void OnRearLeft(InputAction.CallbackContext context);
        void OnRearRight(InputAction.CallbackContext context);
    }
    public interface IDroneAxisActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnPitchRoll(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
    }
}
