Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class RibbonForm1
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
			Me.ribbon = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.clientPanel = New DevExpress.XtraEditors.PanelControl()
			Me.ribbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.lookAndFeelSettingsHelper1 = New WindowsApplication1.LookAndFeelSettingsHelper()
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbon
			' 
			Me.ribbon.ExpandCollapseItem.Id = 0
			Me.ribbon.ExpandCollapseItem.Name = ""
			Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbon.ExpandCollapseItem, Me.ribbonGalleryBarItem1})
			Me.ribbon.Location = New System.Drawing.Point(0, 0)
			Me.ribbon.MaxItemId = 2
			Me.ribbon.Name = "ribbon"
			Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbon.Size = New System.Drawing.Size(442, 144)
			Me.ribbon.StatusBar = Me.ribbonStatusBar
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.ribbonGalleryBarItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Skins"
			' 
			' ribbonStatusBar
			' 
			Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 418)
			Me.ribbonStatusBar.Name = "ribbonStatusBar"
			Me.ribbonStatusBar.Ribbon = Me.ribbon
			Me.ribbonStatusBar.Size = New System.Drawing.Size(442, 31)
			' 
			' clientPanel
			' 
			Me.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill
			Me.clientPanel.Location = New System.Drawing.Point(0, 144)
			Me.clientPanel.Name = "clientPanel"
			Me.clientPanel.Size = New System.Drawing.Size(442, 274)
			Me.clientPanel.TabIndex = 2
			' 
			' ribbonGalleryBarItem1
			' 
			Me.ribbonGalleryBarItem1.Caption = "ribbonGalleryBarItem1"
			Me.ribbonGalleryBarItem1.Id = 1
			Me.ribbonGalleryBarItem1.Name = "ribbonGalleryBarItem1"
			' 
			' RibbonForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(442, 449)
			Me.Controls.Add(Me.clientPanel)
			Me.Controls.Add(Me.ribbonStatusBar)
			Me.Controls.Add(Me.ribbon)
			Me.Name = "RibbonForm1"
			Me.Ribbon = Me.ribbon
			Me.StatusBar = Me.ribbonStatusBar
			Me.Text = "RibbonForm1"
			CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clientPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbon As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private clientPanel As DevExpress.XtraEditors.PanelControl
		Private ribbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
		Private lookAndFeelSettingsHelper1 As LookAndFeelSettingsHelper
	End Class
End Namespace