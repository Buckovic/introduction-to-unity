using UnityEngine;
using UnityEngine.EventSystems;

public class CustomInputModule : StandaloneInputModule
{
    // Current cursor lock state (memory cache)
    private CursorLockMode _currentLockState = CursorLockMode.None;

    /// <summary>
    /// Process the current tick for the module.
    /// </summary>
    public override void Process()
    {
        _currentLockState = Cursor.lockState;

        Cursor.lockState = CursorLockMode.None;

        base.Process();

        Cursor.lockState = _currentLockState;
    }
}