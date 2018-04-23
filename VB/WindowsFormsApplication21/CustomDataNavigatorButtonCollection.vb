Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.NavigatorButtons
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace WindowsFormsApplication21
	Public Class CustomDataNavigatorButtonCollection
		Inherits DataNavigatorButtonCollection
		Public Sub New(ByVal buttons As DataNavigatorButtons)
			MyBase.New(buttons)
		End Sub
		Protected Overrides Sub CreateButtons(ByVal buttons As NavigatorButtonsBase)
			AddButton(New DataNavigatorFirstButtonHelper(buttons))
			AddButton(New DataNavigatorPrevPageButtonHelper(buttons))
			AddButton(New DataNavigatorPrevButtonHelper(buttons))
			AddButton(New DataNavigatorNextButtonHelper(buttons))
			AddButton(New DataNavigatorNextPageButtonHelper(buttons))
			AddButton(New DataNavigatorLastButtonHelper(buttons))
			AddButton(New DataNavigatorAddButtonHelper(buttons))
			AddButton(New DataNavigatorRemoveButtonHelper(buttons))
			AddButton(New DataNavigatorCancelEditButtonHelper(buttons))
			AddButton(New DataNavigatorEndEditButtonHelper(buttons))
		End Sub
	End Class
End Namespace
