Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms

Namespace Runtime
	''' <summary>
	''' Summary description for UserControl1.
	''' </summary>
	Public Class UserControl1
		Inherits System.Windows.Forms.UserControl
		Private button1 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			' This call is required by the Windows.Forms Form Designer.
			InitializeComponent()

			' TODO: Add any initialization after the InitForm call

		End Sub

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"
		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(32, 16)
			Me.button1.Name = "button1"
			Me.button1.TabIndex = 0
			Me.button1.Text = "button1"
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(16, 64)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = "textBox1"
			' 
			' UserControl1
			' 
			Me.Controls.AddRange(New System.Windows.Forms.Control() { Me.textBox1, Me.button1})
			Me.Name = "UserControl1"
			Me.ResumeLayout(False)

		End Sub
		#End Region
	End Class
End Namespace
