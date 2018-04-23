using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DevExpress.XtraNavBar.ViewInfo;
using DevExpress.XtraNavBar;
using DevExpress.Utils.Drawing;

namespace NavBarSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void navBarControl1_CustomDrawLink(object sender, DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventArgs e) {
            if (e.ObjectInfo.State == ObjectState.Hot || e.ObjectInfo.State == ObjectState.Pressed) {
                LinearGradientBrush brush;
                NavLinkInfoArgs linkInfo = e.ObjectInfo as NavLinkInfoArgs;
                if (e.ObjectInfo.State == ObjectState.Hot) {
                    brush = new LinearGradientBrush(e.RealBounds, Color.Orange, Color.PeachPuff,
                        LinearGradientMode.Horizontal);
                }
                else
                    brush = new LinearGradientBrush(e.RealBounds, Color.PeachPuff, Color.Orange,
                        LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle(Brushes.OrangeRed, e.RealBounds);
                Rectangle rect = e.RealBounds;
                rect.Inflate(-1, -1);
                e.Graphics.FillRectangle(brush, rect);
                if (e.Image != null) {
                    Rectangle imageRect = linkInfo.ImageRectangle;
                    imageRect.X += (imageRect.Width - e.Image.Width) / 2;
                    imageRect.Y += (imageRect.Height - e.Image.Height) / 2;
                    imageRect.Size = e.Image.Size;
                    e.Graphics.DrawImageUnscaled(e.Image, imageRect);
                }
                e.Appearance.DrawString(e.Cache, e.Caption, linkInfo.RealCaptionRectangle, Brushes.White);
                e.Handled = true;
            }
        }
    }
}
