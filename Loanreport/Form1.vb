Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoanledgerDataSet.Loan' table. You can move, or remove it, as needed.
        Me.LoanTableAdapter.Fill(Me.LoanledgerDataSet.Loan)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CrystalReportViewer1.Enabled = True
        CrystalReportViewer1.ReportSource = "G:\interview project\Loan Ledger\Loanreport\Loanreport\rptLoan.rpt"
        CrystalReportViewer1.SelectionFormula = "{Loan.LoanNo}=" & ComboBox1.SelectedValue.ToString
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class
