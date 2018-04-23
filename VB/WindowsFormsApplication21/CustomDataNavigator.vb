Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication21
	<ToolboxItem(True)> _
	Public Class CustomDataNavigator
		Inherits DataNavigator
		Public Sub New()
			MyBase.New()

		End Sub
		Protected Overrides Function CreateButtons() As NavigatorButtonsBase
			Return New CustomDataNavigatorButtons(Me)
		End Function
	End Class
End Namespace
