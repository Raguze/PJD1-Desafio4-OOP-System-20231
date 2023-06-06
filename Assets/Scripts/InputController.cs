using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputController : MonoBehaviour
{
    protected static Dictionary<KeyCode, bool> keyDowns = new Dictionary<KeyCode, bool>();
    protected static Dictionary<KeyCode, bool> keyHolds = new Dictionary<KeyCode, bool>();

    public static KeyCode FireButtonKeyCode { get; protected set; }
    public static KeyCode ReloadButtonKeyCode { get; protected set; }
    public static KeyCode SelectWeapon1ButtonKeyCode { get; protected set; }
    public static KeyCode SelectWeapon2ButtonKeyCode { get; protected set; }
    public static KeyCode SelectWeapon3ButtonKeyCode { get; protected set; }

    private void Awake()
    {
        FireButtonKeyCode = KeyCode.Mouse0;
        ReloadButtonKeyCode = KeyCode.Mouse1;
        SelectWeapon1ButtonKeyCode = KeyCode.Alpha1;
        SelectWeapon2ButtonKeyCode = KeyCode.Alpha2;
        SelectWeapon3ButtonKeyCode = KeyCode.Alpha3;

        keyDowns.Add(FireButtonKeyCode, false);
        keyDowns.Add(ReloadButtonKeyCode, false);
        keyDowns.Add(SelectWeapon1ButtonKeyCode, false);
        keyDowns.Add(SelectWeapon2ButtonKeyCode, false);
        keyDowns.Add(SelectWeapon3ButtonKeyCode, false);

        keyHolds.Add(FireButtonKeyCode, false);
    }

    public static bool FireButton { 
        get { return keyDowns[FireButtonKeyCode]; } 
    }

    public static bool FireHold
    {
        get { return keyHolds[FireButtonKeyCode]; }
    }

    public static bool ReloadButton
    {
        get { return keyDowns[ReloadButtonKeyCode]; }
    }

    public static bool SelectWeapon1Button
    {
        get { return keyDowns[SelectWeapon1ButtonKeyCode]; }
    }

    public static bool SelectWeapon2Button
    {
        get { return keyDowns[SelectWeapon2ButtonKeyCode]; }
    }

    public static bool SelectWeapon3Button
    {
        get { return keyDowns[SelectWeapon3ButtonKeyCode]; }
    }

    void Update()
    {
        KeyCode[] keyDownKeys = keyDowns.Keys.ToArray();

        for (int i = 0; i < keyDownKeys.Length; i++)
        {
            KeyCode keyCode = keyDownKeys[i];
            bool down = Input.GetKeyDown(keyCode);
            keyDowns[keyCode] = down;
        }

        KeyCode[] keyHoldKeys = keyHolds.Keys.ToArray();

        for (int i = 0; i < keyHoldKeys.Length; i++)
        {
            KeyCode keyCode = keyHoldKeys[i];
            bool down = Input.GetKey(keyCode);
            keyHolds[keyCode] = down;
        }
    }
}
