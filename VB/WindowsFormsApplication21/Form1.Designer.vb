Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication21
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
			Me.customDataNavigator1 = New WindowsFormsApplication21.CustomDataNavigator()
			Me.SuspendLayout()
			' 
			' customDataNavigator1
			' 
			Me.customDataNavigator1.Buttons.CancelEdit.Visible = False
			Me.customDataNavigator1.Buttons.EndEdit.Visible = False
			Me.customDataNavigator1.CustomButtons.AddRange(New DevExpress.XtraEditors.NavigatorCustomButton() { New DevExpress.XtraEditors.NavigatorCustomButton(10), New DevExpress.XtraEditors.NavigatorCustomButton(9)})
			Me.customDataNavigator1.Location = New System.Drawing.Point(64, 254)
			Me.customDataNavigator1.Name = "customDataNavigator1"
			Me.customDataNavigator1.Size = New System.Drawing.Size(260, 19)
			Me.customDataNavigator1.TabIndex = 21
			Me.customDataNavigator1.Text = "customDataNavigator1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(951, 469)
			Me.Controls.Add(Me.customDataNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customDataNavigator1 As CustomDataNavigator

	End Class
End Namespace

