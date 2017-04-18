using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Smartcodinghub.CustomControls
{
    public class AbstractButton : Button
    {
        public int Radius { get; set; }
        public bool Hover { get; set; }
        public bool Pressed { get; set; }
        
        public StringFormat StringFormat { get; set; }

        [DefaultValue(typeof(StringAlignment), "Center")]
        public StringAlignment StringAlignment
        {
            get { return StringFormat.Alignment; }
            set { StringFormat.Alignment = value; }
        }

        [DefaultValue(typeof(StringAlignment), "Center")]
        public StringAlignment StringLineAlignment
        {
            get { return StringFormat.LineAlignment; }
            set { StringFormat.LineAlignment = value; }
        }

        public AbstractButton()
            : base()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor | ControlStyles.AllPaintingInWmPaint
                          | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint
                          | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer, true);

            Hover = false;
            Radius = 4;
            Pressed = false;
            StringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            this.MouseEnter += (sender, e) => { Hover = true; Cursor = Cursors.Hand; };
            this.MouseLeave += (sender, e) => { Hover = false; Cursor = Cursors.Arrow; };

            this.MouseDown += (sender, e) => Pressed = true;
            this.MouseUp += (sender, e) => Pressed = false;
        }
    }
}
