using Smartcodinghub.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Smartcodinghub.Extensions
{
    /**
     * @class   ControlExtensions
     * @brief   Some Extensions for Controls, like DoubleBuffering or Styles.
     * @author  Oscvic
     * @date    2015-12-10
     */
    public static class ControlExtensions
    {
        /**
         * @fn  public static Boolean SetDoubleBuffered(this Control control, Boolean isDoubleBuffered)
         * @brief   A Control extension method that sets double buffered.
         * @author  Oscvic
         * @date    2015-12-10
         * @param   control             The control to act on.
         * @param   isDoubleBuffered    true if this ControlExtensions is double buffered.
         * @return  true if it succeeds, false if it fails.
         */
        public static Boolean SetDoubleBuffered(this Control control, Boolean isDoubleBuffered)
        {
            PropertyInfo property = control.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

            if (property != null)
            {
                property.SetValue(control, isDoubleBuffered, null);
                return true;
            }

            return false;
        }

        /**
         * @fn  public static Boolean SetStylesOfControl(this Control control, ControlStyles styles, Boolean value)
         * @brief   A Control extension method that sets styles of control.
         * @author  Oscvic
         * @date    2015-12-10
         * @param   control The control to act on.
         * @param   styles  The styles.
         * @param   value   true to value.
         * @return  true if it succeeds, false if it fails.
         */
        public static Boolean SetStylesOfControl(this Control control, ControlStyles styles, Boolean value)
        {
            MethodInfo method = control.GetType().GetMethod("SetStyle", BindingFlags.Instance | BindingFlags.NonPublic);

            if (method != null)
            {
                method.Invoke(control, new Object[] { styles, value });
                return true;
            }

            return false;
        }

        /**
         * @fn  public static void OnHoverColor(this Control control, Color onHover, Color normal)
         * @brief   A Control extension method that executes the hover color action.
         * @author  Oscvic
         * @date    2015-12-10
         * @param   control The control to act on.
         * @param   onHover The on hover.
         * @param   normal  The normal.
         */
        public static void OnHoverColor(this Control control, Color onHover, Color normal)
        {
            control.MouseEnter += (sender, e) => control.BackColor = onHover;
            control.MouseLeave += (sender, e) => control.BackColor = normal;
        }

        public static Color GetTrueBackColor(this Control c)
        {
            return (c.BackColor == Color.Transparent) ? ControlUtils.GetNonTransparentColorFromParent(c) : c.BackColor;
        }

        public static Color GetNonTransparentColorFromParent(this Control c)
        {
            return ControlUtils.GetNonTransparentColorFromParent(c);
        }
    }
}
