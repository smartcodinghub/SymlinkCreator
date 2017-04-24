﻿using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Smartcodinghub.UserControls
{
    ///------------------------------------------------------------------------------------------------------
    /// <summary> A switch control. </summary>
    /// <remarks> Oscvic, 2016-01-18. </remarks>
    ///------------------------------------------------------------------------------------------------------
    public partial class SwitchControl : UserControl
    {
        [Category("ClickCustomEvents")]
        [Description("Fired when this is clicked")]
        public event SelectionChanged OnSelectionChanged;    /* Event queue for all listeners interested in onSelected events. */

        ///--------------------------------------------------------------------------------------------------
        /// <summary> The delegate on selection changes. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="Value"> The value. </param>
        ///--------------------------------------------------------------------------------------------------
        public delegate void SelectionChanged(Object value);

        // TODO Add delegation to TopColor and the other properties of the SwitchButton
        private SwitchButton selected;  /* The selected */

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Gets or sets the selected. </summary>
        /// <value> The selected. </value>
        ///--------------------------------------------------------------------------------------------------
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SwitchButton Selected
        {
            get
            {
                return selected;
            }
            set
            {
                if (selected != null)
                    selected.Selected = false;

                if (value != null)
                {
                    value.Selected = true;

                    selected = value;

                    /* Refresh the button with the new appearence */
                    this.Refresh();

                    /* Call the event */
                    OnSelectionChanged?.Invoke(selected.Value);
                }
            }
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Gets or sets the selected item. </summary>
        /// <value> The selected item. </value>
        ///--------------------------------------------------------------------------------------------------
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Object SelectedItem
        {
            get { return selected?.Value; }
            set
            {
                this.Selected = flow.Controls.OfType<SwitchButton>().FirstOrDefault(sb => Object.Equals(sb.Value, value));
            }
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Default constructor. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        ///--------------------------------------------------------------------------------------------------
        public SwitchControl()
        {
            InitializeComponent();
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Adds a range. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="toAdd"> to add to add. </param>
        ///--------------------------------------------------------------------------------------------------
        public void AddItems(Object[] toAdd)
        {
            foreach (Object add in toAdd)
                AddItem(add);
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Adds toAdd. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="toAdd"> to add to add. </param>
        ///--------------------------------------------------------------------------------------------------
        public void AddItem(Object toAdd)
        {
            int count = flow.Controls.Count;

            SwitchButton button = new SwitchButton(toAdd) { Margin = new Padding(0, 0, 0, 0) };

            if (count == 0)
            {
                // First Button (All corners rounded)
                button.Extreme = Extreme.NoExtreme;
                flow.Controls.Add(button);
            }
            else if (count == 1)
            {
                // Second Button, the first button should have left rounded corners
                (flow.Controls[0] as SwitchButton).Extreme = Extreme.Left;
                button.Extreme = Extreme.Right;
                flow.Controls.Add(button);
            }
            else
            {
                // Rest of the buttons, the button before shouldn't have rounded corners
                (flow.Controls[count - 1] as SwitchButton).Extreme = Extreme.Center;
                button.Extreme = Extreme.Right;
                flow.Controls.Add(button);
            }

            RecalculateSize();

            button.OnSwitchButtonSelectedEvent += button_OnSwitchButtonSelectedEvent;
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Calculates the size. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        ///--------------------------------------------------------------------------------------------------
        private void RecalculateSize()
        {
            SuspendLayout();

            float newWidth = (flow.Width - flow.Padding.Left - flow.Padding.Right) / (float)(flow.Controls.Count);
            float newHeight = flow.Height - flow.Padding.Top - flow.Padding.Bottom;

            foreach (Control c in flow.Controls)
            {
                c.Width = (int)newWidth;
                c.Height = (int)newHeight;
            }

            ResumeLayout(true);
            this.Refresh();
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Button switch button selected event. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="button"> The button. </param>
        ///--------------------------------------------------------------------------------------------------
        void button_OnSwitchButtonSelectedEvent(SwitchButton button)
        {
            if (!button.Selected)
                this.Selected = button;
        }

        ///--------------------------------------------------------------------------------------------------
        /// <summary> Event handler. Called by SwitchControl for size changed events. </summary>
        /// <remarks> Oscvic, 2016-01-18. </remarks>
        /// <param name="sender"> Source of the event. </param>
        /// <param name="e">      Event information. </param>
        ///--------------------------------------------------------------------------------------------------
        private void SwitchControl_SizeChanged(object sender, EventArgs e)
        {
            if (flow.Controls.Count > 0)
                RecalculateSize();
        }
    }
}
