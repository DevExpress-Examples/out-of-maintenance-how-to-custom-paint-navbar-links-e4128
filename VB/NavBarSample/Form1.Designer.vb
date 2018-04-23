Imports Microsoft.VisualBasic
Imports System
Namespace NavBarSample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
			Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
			Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
			Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.navBarGroup2
			Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.navBarGroup1, Me.navBarGroup2})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6})
			Me.navBarControl1.LargeImages = Me.imageCollection2
			Me.navBarControl1.Location = New System.Drawing.Point(0, 0)
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = 164
			Me.navBarControl1.Size = New System.Drawing.Size(164, 377)
			Me.navBarControl1.SmallImages = Me.imageCollection1
			Me.navBarControl1.TabIndex = 0
			Me.navBarControl1.Text = "navBarControl1"
'			Me.navBarControl1.CustomDrawLink += New DevExpress.XtraNavBar.ViewInfo.CustomDrawNavBarElementEventHandler(Me.navBarControl1_CustomDrawLink);
			' 
			' navBarGroup2
			' 
			Me.navBarGroup2.Caption = "Export "
			Me.navBarGroup2.Expanded = True
			Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
			Me.navBarGroup2.Name = "navBarGroup2"
			' 
			' navBarItem6
			' 
			Me.navBarItem6.Caption = "XML"
			Me.navBarItem6.LargeImageIndex = 2
			Me.navBarItem6.Name = "navBarItem6"
			' 
			' navBarItem5
			' 
			Me.navBarItem5.Caption = "PDF"
			Me.navBarItem5.LargeImageIndex = 1
			Me.navBarItem5.Name = "navBarItem5"
			' 
			' navBarItem4
			' 
			Me.navBarItem4.Caption = "HTML"
			Me.navBarItem4.LargeImageIndex = 0
			Me.navBarItem4.Name = "navBarItem4"
			' 
			' navBarGroup1
			' 
			Me.navBarGroup1.Caption = "Edit"
			Me.navBarGroup1.Expanded = True
			Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
			Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() { New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1)})
			Me.navBarGroup1.Name = "navBarGroup1"
			' 
			' navBarItem3
			' 
			Me.navBarItem3.Caption = "Paste"
			Me.navBarItem3.Name = "navBarItem3"
			Me.navBarItem3.SmallImageIndex = 2
			' 
			' navBarItem2
			' 
			Me.navBarItem2.Caption = "Cut"
			Me.navBarItem2.Name = "navBarItem2"
			Me.navBarItem2.SmallImageIndex = 1
			' 
			' navBarItem1
			' 
			Me.navBarItem1.Caption = "Copy"
			Me.navBarItem1.Name = "navBarItem1"
			Me.navBarItem1.SmallImageIndex = 0
			' 
			' imageCollection2
			' 
			Me.imageCollection2.ImageSize = New System.Drawing.Size(32, 32)
			Me.imageCollection2.ImageStream = (CType(resources.GetObject("imageCollection2.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection2.Images.SetKeyName(0, "html16x16.png")
			Me.imageCollection2.Images.SetKeyName(1, "pdf32x32.png")
			Me.imageCollection2.Images.SetKeyName(2, "xml32x32.png")
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.imageCollection1.Images.SetKeyName(0, "copy16x16.png")
			Me.imageCollection1.Images.SetKeyName(1, "cut16x16.png")
			Me.imageCollection1.Images.SetKeyName(2, "paste16x16.png")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(356, 377)
			Me.Controls.Add(Me.navBarControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private imageCollection2 As DevExpress.Utils.ImageCollection
		Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup
		Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem
		Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem
	End Class
End Namespace

