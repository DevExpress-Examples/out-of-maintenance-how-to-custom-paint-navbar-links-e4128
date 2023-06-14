Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraNavBar.ViewInfo
Imports DevExpress.Utils.Drawing

Namespace NavBarSample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub navBarControl1_CustomDrawLink(ByVal sender As Object, ByVal e As CustomDrawNavBarElementEventArgs)
            If e.ObjectInfo.State = ObjectState.Hot OrElse e.ObjectInfo.State = ObjectState.Pressed Then
                Dim brush As LinearGradientBrush
                Dim linkInfo As NavLinkInfoArgs = TryCast(e.ObjectInfo, NavLinkInfoArgs)
                If e.ObjectInfo.State = ObjectState.Hot Then
                    brush = New LinearGradientBrush(e.RealBounds, Color.Orange, Color.PeachPuff, LinearGradientMode.Horizontal)
                Else
                    brush = New LinearGradientBrush(e.RealBounds, Color.PeachPuff, Color.Orange, LinearGradientMode.Horizontal)
                End If

                e.Graphics.FillRectangle(Brushes.OrangeRed, e.RealBounds)
                Dim rect As Rectangle = e.RealBounds
                rect.Inflate(-1, -1)
                e.Graphics.FillRectangle(brush, rect)
                If e.Image IsNot Nothing Then
                    Dim imageRect As Rectangle = linkInfo.ImageRectangle
                    imageRect.X +=(imageRect.Width - e.Image.Width) \ 2
                    imageRect.Y +=(imageRect.Height - e.Image.Height) \ 2
                    imageRect.Size = e.Image.Size
                    e.Graphics.DrawImageUnscaled(e.Image, imageRect)
                End If

                e.Appearance.DrawString(e.Cache, e.Caption, linkInfo.RealCaptionRectangle, Brushes.White)
                e.Handled = True
            End If
        End Sub
    End Class
End Namespace
