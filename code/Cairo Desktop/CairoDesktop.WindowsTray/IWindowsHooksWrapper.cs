﻿
namespace CairoDesktop.WindowsTray
{
    using System;

    /// <summary>
    /// Contract interface for the WindowsHooksWrapper implementations
    /// </summary>
    public interface IWindowsHooksWrapper
    {
        /// <summary>
        /// Sets the delegate for the system tray callback.
        /// </summary>
        /// <param name="theDelegate">The system tray callback delegate.</param>
        void SetSystrayCallback(SystrayDelegate theDelegate);

        /// <summary>
        /// Initializes the system tray hooks.
        /// </summary>
        void InitializeSystray();

        /// <summary>
        /// Starts the system tray listener (send the TaskbarCreated message).
        /// </summary>
        void Run();

        /// <summary>
        /// Shuts down the system tray hooks.
        /// </summary>
        void ShutdownSystray();
    }
}
