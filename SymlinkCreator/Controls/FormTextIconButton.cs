using Smartcodinghub.Util;
using Smartcodinghub.Extensions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Smartcodinghub.CustomControls
{
    class FormTextIconButton : AbstractButton
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Font Font
        {
            get { return base.Font; }
            set { base.Font = value; }
        }

        public new Image Image
        {
            get { return base.Image; }
            set
            {
                if (value != null)
                {
                    base.Image = value;
                    imageSize.Width = value.Width;
                    imageSize.Height = value.Height;
                    textLocation.X = ImageLocation.X + TextGap + imageSize.Width;
                    textLocation.Y = 0;
                }
            }
        }

        public int TextGap { get; set; }
        private Point textLocation;
        public Point TextLocation { get { return textLocation; } set { textLocation = value; } }
        public Point ImageLocation { get; set; }

        public Boolean UseGradient { get; set; }
        public Color AltGradientColor { get; set; }

        public float PercentageOfDark { get; set; }

        public float PercentageOfLight { get; set; }

        public float PercentageForHover { get; set; }

        public float PercentageForPressed { get; set; }

        private Size imageSize;
        public Size ImageSize
        {
            get { return imageSize; }
            set
            {
                imageSize = value;
                textLocation.X = ImageLocation.X + TextGap + imageSize.Width;
                textLocation.Y = 0;
            }
        }

        public FormTextIconButton()
            : base()
        {
            ForeColor = Color.White;
            Font = new Font("Segoe UIO", 9.75f);
            BackColor = Color.FromArgb(50, 50, 50);
            HoverColor = Color.FromArgb(80, 80, 80);
            PercentageForHover = 0.15f;
            PercentageForPressed = 0.15f;
            StringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            TextLocation = new Point(Padding.Left, Padding.Top);
            ImageLocation = new Point(Padding.Left, Padding.Top);
            ImageSize = new Size(0, 0);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            using (Brush brush = new SolidBrush(this.GetNonTransparentColorFromParent()))
                e.Graphics.FillRectangle(brush, rect);

            rect.Width -= 1;
            rect.Height -= 1;


            var (fillBrush, pen) = GetBrushAndPen();

            using (fillBrush)
                e.Graphics.FillRoundedRectangle(fillBrush, rect, Radius);

            using (pen)
                e.Graphics.DrawRoundedRectangle(pen, rect, Radius);

            if (Image != null)
            {
                rect.X = ImageLocation.X;
                rect.Y = ImageLocation.Y;
                rect.Width = imageSize.Width;
                rect.Height = imageSize.Height;

                e.Graphics.DrawImage(Image, rect);
            }

            if (Text != null)
            {
                rect.X = textLocation.X;
                rect.Y = textLocation.Y;
                rect.Width = Width - textLocation.X;
                rect.Height = Height - textLocation.Y;
                using (SolidBrush brush = new SolidBrush(ForeColor))
                    e.Graphics.DrawString(Text, Font, brush, rect, StringFormat);
            }
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Paints the area. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="e">          Paint event information. </param>
        /// <param name="filter">     Specifies the filter. </param>
        /// <param name="StartColor"> The start color. </param>
        /// <param name="EndColor">   The end color. </param>
        /// <param name="invertDark"> true to invert dark. </param>
        ///--------------------------------------------------------------------------------------------------
        private (Brush, Pen) GetBrushAndPen()
        {
            Brush brush = null;

            if (UseGradient)
            {

            }
            else
            {
                Color color = BackColor;

                if (Pressed)
                    color = ControlUtils.ChangeColorBrightness(color, -PercentageForPressed);
                else if (Hover)
                    color = ControlUtils.ChangeColorBrightness(color, PercentageForHover);
                else
                    color = BackColor;

                brush = new SolidBrush(color);
            }

            return (brush, new Pen(BackColor));

            //Color StartColor = BackColor;
            //Color EndColor = ForeColor;
            //StartColor = (invertDark) ? ControlPaint.Dark(StartColor, PercentageOfDark) : StartColor;
            //EndColor = (invertDark) ? ControlPaint.Light(StartColor, PercentageOfLight) : ControlPaint.Dark(EndColor, PercentageOfDark);


            //using (LinearGradientBrush brush = new LinearGradientBrush(
            //    new Point(this.Width / 2, (invertDark) ? -(this.Height / 2) : 0),
            //    new Point(this.Width / 2, this.Height + ((invertDark) ? 0 : this.Height / 2)),
            //    StartColor, EndColor))
            //    e.Graphics.FillRoundedRectangle(brush, 0, 0, this.Width - 1, this.Height, Radius, filter);

            //using (Pen pen = new Pen((invertDark) ? StartColor : EndColor))
            //    e.Graphics.DrawRoundedRectangle(pen, 0, 0, this.Width - 1, this.Height - 1, Radius, filter);
        }
    }
}
