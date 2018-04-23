Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	<Serializable> _
	Public Class LookAndFeelSettings
		Public SkinName As String
		Public Style As LookAndFeelStyle
		Public UseWindowsXPTheme As Boolean

		Public Sub New()

		End Sub
	End Class
End Namespace
