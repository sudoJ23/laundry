Imports MySql.Data.MySqlClient

Public Class Form2

    Private Sub loadData()
        konek()
        da = New MySqlDataAdapter("SELECT * FROM karyawan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "karyawan")
        DataGridView1.DataSource = ds.Tables("karyawan")
        da.Dispose()
        ds.Dispose()
        conn.Close()
        DataGridView1.Columns(0).HeaderText = "NIK"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Alamat"
        DataGridView1.Columns(3).HeaderText = "No Telp"
        DataGridView1.Columns(4).HeaderText = "Gender"
    End Sub

    Private Sub loadGrid()
        da = New MySqlDataAdapter("select * from karyawan", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Baru()
        boxnik.Text = generateNIK()
        boxnama.Text = ""
        boxalamat.Text = ""
        boxtelp.Text = ""
        combogender.Text = "Laki laki"
    End Sub

    Private Sub Clear()
        boxnik.Text = ""
        boxnama.Text = ""
        boxalamat.Text = ""
        boxtelp.Text = ""
        combogender.Text = "Laki laki"
    End Sub

    Private Sub search()
        da = New MySqlDataAdapter("select * from karyawan where nama like '%" & boxsearch.Text & "%' or alamat like '%" & boxsearch.Text & "%' or NIK like '%" & boxsearch.Text & "%' or telp like '%" & boxsearch.Text & "%' or gender like '%" & boxsearch.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        loadGrid()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim banyakrow As Integer = DataGridView1.RowCount - 2
        Dim indexnya As Integer = e.RowIndex
        If indexnya > banyakrow Then
        Else
            selectednik = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim nik As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim nm As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Dim almt As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim telp As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            Dim gender As String = DataGridView1.Rows(e.RowIndex).Cells(4).Value

            boxnik.Text = nik
            boxnama.Text = nm
            boxalamat.Text = almt
            boxtelp.Text = telp
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Call konek()
        Dim queryedit As String = "update karyawan set nama='" & boxnama.Text & "',alamat='" & boxalamat.Text & "',telp='" & boxtelp.Text & "', gender='" & combogender.Text & "' where NIK='" + selectednik + "'"
        cmd = New MySqlCommand(queryedit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di update")
        Call loadGrid()
    End Sub

    Private Sub btnbaru_Click(sender As Object, e As EventArgs) Handles btnbaru.Click
        Baru()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If boxnama.Text = "" Or boxalamat.Text = "" Or boxtelp.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call konek()
            Dim querysimpan As String = "insert into karyawan values ('" & boxnik.Text & "', '" & boxnama.Text & "','" & boxalamat.Text & "','" & boxtelp.Text & "', '" & combogender.Text & "')"
            cmd = New MySqlCommand(querysimpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call loadGrid()
        End If
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If selectednik = "" Then
            MsgBox("Harap pilih terlebih dahulu")
        Else
            Call konek()
            Clear()
            Dim queryhapus As String = "delete from karyawan where NIK=" + selectednik
            cmd = New MySqlCommand(queryhapus, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil di hapus")
            Call loadGrid()
        End If
    End Sub

    Private Sub btncari_Click(sender As Object, e As EventArgs) Handles btncari.Click
        search()
    End Sub

    Private Sub boxsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles boxsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            search()
        End If
    End Sub

    Private Sub boxsearch_TextChanged(sender As Object, e As EventArgs) Handles boxsearch.TextChanged
        If Not boxsearch.Text = "" Then
            search()
        End If
    End Sub

    Function generateNIK() As Integer
        Dim result As Integer = 1

        Call konek()
        cmd = New MySqlCommand("SELECT MAX(NIK) FROM karyawan", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            If rd.IsDBNull(0) Then
                result = 1
            Else
                Dim n As Integer = rd.GetValue(0)
                result = n + 1
            End If
        End If
        Return result
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(generateNIK())
    End Sub
End Class