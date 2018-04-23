Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.ViewInfo

Namespace DXSample
	Public Class MyListBoxControl
		Inherits ListBoxControl
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Function CreateViewInfo() As BaseStyleControlViewInfo
			Return New MyBaseListBoxViewInfo(Me)
		End Function
	End Class

	Public Class MyListBoxItemPainter
		Inherits ListBoxItemPainter
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Sub DrawItemBar(ByVal e As ListBoxItemObjectInfoArgs)
			e.PaintAppearance.FillRectangle(e.Cache, e.Bounds)
		End Sub
	End Class

	Public Class MyBaseListBoxViewInfo
		Inherits BaseListBoxViewInfo
		Public Sub New(ByVal owner As BaseListBoxControl)
			MyBase.New(owner)
		End Sub

		Protected Overrides Function CreateItemPainter() As BaseListBoxItemPainter
			If IsSkinnedHighlightingEnabled Then
				Return New MyListBoxSkinItemPainter()
			End If
			Return New MyListBoxItemPainter()
		End Function
	End Class

	Public Class MyListBoxSkinItemPainter
		Inherits ListBoxSkinItemPainter
		Public Sub New()
			MyBase.New()
		End Sub
		Protected Overrides Sub DrawItemBar(ByVal e As ListBoxItemObjectInfoArgs)
			DrawItemBarCore(e)
		End Sub
	End Class
End Namespace