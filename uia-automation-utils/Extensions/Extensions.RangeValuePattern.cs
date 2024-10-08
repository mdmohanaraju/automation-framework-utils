﻿#region Copyright (c) 2024 Mohanraj Devadoss
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

using System.Windows.Automation;

namespace UIA.Automation.Utils.Extensions
{
    /// <summary>
    /// Extensions for <see cref="AutomationElement"/> objec t
    /// </summary>
    public static partial class AutomationElementExtensions
	{
        /// <summary>
        /// Get RangeValue pattern object
        /// </summary>
        /// <param name="element">Automation element</param>
        /// <returns>RangeValue pattern object if supported else null</returns>
        public static RangeValuePattern GetRangeValuePattern(this AutomationElement element)
        {
            return element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
        }

        public static void SetRange(this AutomationElement element, double value)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            rangeValuePattern?.SetValue(value);
        }

        /// <summary>
        /// Gets a value that specifies whether the value of a UI Automation element is read-only.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>true if the value is read-only; false if it can be modified. The default is true.</returns>
        public static bool IsReadOnly(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.IsReadOnly;
        }

        /// <summary>
        /// Gets the current value of the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The current value of the UI Automation element or null if the element does not support Value. The default value is 0.0.</returns>
        public static double GetRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Value;
        }

        /// <summary>
        /// Gets the maximum range value supported by the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The maximum value supported by the UI Automation element or null if the element does not support Maximum. The default value is 0.0.</returns>
        public static double GetMaximumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Maximum;
        }

        /// <summary>
        /// Gets the minimum range value supported by the UI Automation element.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>he minimum value supported by the UI Automation element or null if the element does not support Minimum. The default value is 0.0.</returns>
        public static double GetMinimumRange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.Minimum;
        }

        /// <summary>
        /// Gets the control-specific large-change value which is added to or subtracted from the Value property.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The large-change value or null if the element does not support LargeChange. The default value is 0.0.</returns>
        public static double GetLargeChange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.LargeChange;
        }

        /// <summary>
        /// Gets the control-specific small-change value which is added to or subtracted from the Value property.
        /// </summary>
        /// <param name="element">Represents a control that can be set to a value within a range.</param>
        /// <returns>The small-change value unique to the UI Automation element or null if the element does not support SmallChange. The default value is 0.0.</returns>
        public static double GetSmallChange(this AutomationElement element)
        {
            var rangeValuePattern = element.GetPattern<RangeValuePattern>(RangeValuePattern.Pattern);
            return rangeValuePattern.Current.SmallChange;
        }
    }
}

