﻿// *****************************************************************************
// BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
//  © Component Factory Pty Ltd, 2006 - 2016, All rights reserved.
// The software and associated documentation supplied hereunder are the 
//  proprietary information of Component Factory Pty Ltd, 13 Swallows Close, 
//  Mornington, Vic 3931, Australia and are supplied subject to license terms.
// 
//  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV) 2017 - 2020. All rights reserved. (https://github.com/Wagnerp/Krypton-NET-5.462)
//  Version 5.462.0.0  www.ComponentFactory.com
// *****************************************************************************

using System.ComponentModel;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace ComponentFactory.Krypton.Ribbon
{
    /// <summary>
    /// Storage for shortcut related properties.
    /// </summary>
    public class RibbonShortcuts : Storage
    {
        #region Static Fields

        private const Keys DEFAULT_TOGGLE_MINIMIZE_MODE = (Keys.Control | Keys.F1);
        private const Keys DEFAULT_TOGGLE_KEYBOARD_ACCESS1 = (Keys.RButton | Keys.ShiftKey | Keys.Alt);
        private const Keys DEFAULT_TOGGLE_KEYBOARD_ACCESS2 = Keys.F10;

        #endregion

        #region Instance Fields

        #endregion

        #region Identity
        /// <summary>
        /// Initialize a new instance of the RibbonShortcuts class.
        /// </summary>
        public RibbonShortcuts()
        {
            // Default values
            ToggleMinimizeMode = DEFAULT_TOGGLE_MINIMIZE_MODE;
            ToggleKeyboardAccess1 = DEFAULT_TOGGLE_KEYBOARD_ACCESS1;
            ToggleKeyboardAccess2 = DEFAULT_TOGGLE_KEYBOARD_ACCESS2;
        }
        #endregion

        #region IsDefault
        /// <summary>
        /// Gets a value indicating if all values are default.
        /// </summary>
        [Browsable(false)]
        public override bool IsDefault => ((ToggleMinimizeMode == DEFAULT_TOGGLE_MINIMIZE_MODE) &&
                                           (ToggleKeyboardAccess1 == DEFAULT_TOGGLE_KEYBOARD_ACCESS1) &&
                                           (ToggleKeyboardAccess2 == DEFAULT_TOGGLE_KEYBOARD_ACCESS2));

        #endregion

        #region ToggleMinimizeMode
        /// <summary>
        /// Gets and sets the shortcut to toggle the ribbon minimized mode..
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Shortcut to toggle the ribbon minimized mode.")]
        [DefaultValue(typeof(Keys), "F1, Control")]
        public Keys ToggleMinimizeMode { get; set; }

        private bool ShouldSerializeToggleMinimizeMode()
        {
            return (ToggleMinimizeMode != DEFAULT_TOGGLE_MINIMIZE_MODE);
        }

        /// <summary>
        /// Resets the ToggleMinimizeMode property to its default value.
        /// </summary>
        public void ResetToggleMinimizeMode()
        {
            ToggleMinimizeMode = DEFAULT_TOGGLE_MINIMIZE_MODE;
        }
        #endregion

        #region ToggleKeyboardAccess1
        /// <summary>
        /// Gets and sets the shortcut to toggle keyboard access to the ribbon.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Shortcut to toggle keyboard access to the ribbon.")]
        [DefaultValue(typeof(Keys), "Menu, Alt")]
        public Keys ToggleKeyboardAccess1 { get; set; }

        private bool ShouldSerializeToggleKeyboardAccess1()
        {
            return (ToggleKeyboardAccess1 != DEFAULT_TOGGLE_KEYBOARD_ACCESS1);
        }

        /// <summary>
        /// Resets the ToggleKeyboardAccess1 property to its default value.
        /// </summary>
        public void ResetToggleKeyboardAccess1()
        {
            ToggleKeyboardAccess1 = DEFAULT_TOGGLE_KEYBOARD_ACCESS1;
        }
        #endregion

        #region ToggleKeyboardAccess2
        /// <summary>
        /// Gets and sets the shortcut to toggle keyboard access to the ribbon.
        /// </summary>
        [Bindable(true)]
        [Localizable(true)]
        [Category("Visuals")]
        [Description("Shortcut to toggle keyboard access to the ribbon.")]
        [DefaultValue(typeof(Keys), "F10")]
        public Keys ToggleKeyboardAccess2 { get; set; }

        private bool ShouldSerializeToggleKeyboardAccess2()
        {
            return (ToggleKeyboardAccess2 != DEFAULT_TOGGLE_KEYBOARD_ACCESS2);
        }

        /// <summary>
        /// Resets the ToggleKeyboardAccess2 property to its default value.
        /// </summary>
        public void ResetToggleKeyboardAccess2()
        {
            ToggleKeyboardAccess2 = DEFAULT_TOGGLE_KEYBOARD_ACCESS2;
        }
        #endregion
    }
}
