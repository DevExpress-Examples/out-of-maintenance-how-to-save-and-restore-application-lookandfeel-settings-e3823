Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Helpers

Namespace WindowsApplication1
	Partial Public Class RibbonForm1
		Inherits DevExpress.XtraBars.Ribbon.RibbonForm
		Public Sub New()
			InitializeComponent()
			SkinHelper.InitSkinGallery(ribbonGalleryBarItem1)
		End Sub
	End Class

End Namespace