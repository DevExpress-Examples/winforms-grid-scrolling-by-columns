Imports DevExpress.XtraEditors
Imports System

Namespace WindowsApplication3

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim helper As GridHScrollHelper = New GridHScrollHelper(gridView1)
            helper.EnableScrollByColumns()
            gridControl1.DataSource = GetList()
            gridView1.Columns(0).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        End Sub
    End Class
End Namespace
