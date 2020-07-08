Imports BusinessLayer

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
		Me.CrystalReportViewer1.ReportSource = New CR_PL
		'Me.CrystalReportViewer1.ReportSource = New CR_BL
	End Sub
End Class
