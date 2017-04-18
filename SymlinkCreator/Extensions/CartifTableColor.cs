using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;


namespace Smartcodinghub.CustomControls
{
    public class CartifTableColor
    {
        private static readonly CartifTableColor instance = new CartifTableColor();
        public static CartifTableColor INSTANCE { get { return instance; } }

        #region Toast

        public virtual Color ToastBorder
        {
            get { return SystemColors.MenuHighlight; }
        }

        public virtual Color ToastBackColor
        {
            get { return Color.White; }
        }

        public virtual Color ToastForeColor
        {
            get { return Color.Black; }
        }

        public virtual Color ToastCheck
        {
            get { return SystemColors.HotTrack; }
        }

        public virtual Color ToastCheckBorder
        {
            get { return Color.Gray; }
        }

        public virtual Color ToastCheckBackColor
        {
            get { return Color.White; }
        }
        #endregion
    }

    public class DefaultErrorTableColor : CartifTableColor
    {
        private static readonly DefaultErrorTableColor instance = new DefaultErrorTableColor();
        public new static CartifTableColor INSTANCE { get { return instance; } }

        #region Toast
        public override Color ToastBorder
        {
            get { return Color.Red; }
        }

        public override Color ToastBackColor
        {
            get { return Color.White; }
        }

        public override Color ToastForeColor
        {
            get { return Color.Black; }
        }

        public override Color ToastCheck
        {
            get { return Color.Red; }
        }

        public override Color ToastCheckBorder
        {
            get { return Color.Gray; }
        }

        public override Color ToastCheckBackColor
        {
            get { return Color.White; }
        }
        #endregion
    }
}