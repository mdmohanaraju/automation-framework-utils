﻿using System;
using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
	/// <summary>
	/// Extensions for <see cref="AutomationElement"/> objec t
	/// </summary>
    public static partial class AutomationElementExtensions
    {
        /// <summary>
        /// Get Invoke pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>Invoke pattern object if supported else null</returns>
        public static InvokePattern GetInvokePattern(this AutomationElement element)
        {
            return element.GetPattern<InvokePattern>(InvokePattern.Pattern);
        }

        /// <summary>
        /// Sends a request to activate a control and initiate its single, unambiguous action.
        /// </summary>
        /// <param name="element">Button element</param>
        /// <throws><see cref="InvalidOperationException"/> if the control does not support the InvokePattern control pattern or is hidden or blocked.</throws>
        /// <throws><see cref="ElementNotEnabledException"/> The element is not enabled. Can be raised when a UI Automation provider has implemented its own handling of the IsEnabled property.</throws>
        public static void Click(this AutomationElement element)
        {
            element.GetInvokePattern().Invoke();
        }
    }
}

