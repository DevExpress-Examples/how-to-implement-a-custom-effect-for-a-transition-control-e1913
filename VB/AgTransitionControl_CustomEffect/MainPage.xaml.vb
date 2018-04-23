Imports Microsoft.VisualBasic
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input

Namespace AgTransitionControl_CustomEffect
	Partial Public Class MainPage
		Inherits UserControl
		Private index As Integer
		Public Sub New()
			InitializeComponent()
			trControl.Content = GetElement("r0")
		End Sub
		Private Sub trControl_MouseLeftButtonUp(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
			If index = 2 Then
				index = 0
			Else
				index += 1
			End If
			trControl.Content = GetElement("r" & index.ToString())
		End Sub
		Private Function GetElement(ByVal id As String) As FrameworkElement
			Return CType((CType(LayoutRoot.Resources(id), DataTemplate)).LoadContent(), FrameworkElement)
		End Function
	End Class
End Namespace
