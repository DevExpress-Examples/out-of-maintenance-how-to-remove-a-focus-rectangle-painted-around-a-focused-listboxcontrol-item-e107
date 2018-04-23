Imports Microsoft.VisualBasic
Imports System
Namespace Q140416
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
			Me.myListBoxControl1 = New DXSample.MyListBoxControl()
			CType(Me.myListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' myListBoxControl1
			' 
			Me.myListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myListBoxControl1.Items.AddRange(New Object() { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5"})
			Me.myListBoxControl1.Location = New System.Drawing.Point(0, 0)
			Me.myListBoxControl1.Name = "myListBoxControl1"
			Me.myListBoxControl1.Size = New System.Drawing.Size(284, 264)
			Me.myListBoxControl1.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.myListBoxControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private myListBoxControl1 As DXSample.MyListBoxControl

	End Class
End Namespace

