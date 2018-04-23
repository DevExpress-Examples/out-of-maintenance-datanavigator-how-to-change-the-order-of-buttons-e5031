Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication21
	Public Class CustomDataNavigatorButtons
		Inherits DataNavigatorButtons
		Public Sub New(ByVal owner As INavigatorOwner)
			MyBase.New(owner)

		End Sub
		Protected Overrides Function CreateNavigatorButtonCollection() As NavigatorButtonCollectionBase
			Return New CustomDataNavigatorButtonCollection(Me)
		End Function
	End Class
End Namespace
