Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ShowData()
        Call TampilGrid()
    End Sub

    Private Sub ShowData()
        konek()
        da = New MySqlDataAdapter("SELECT * FROM konsumen", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "konsumen")
        DataGridView1.DataSource = ds.Tables("konsumen")
        da.Dispose()
        ds.Dispose()
        conn.Close()
        DataGridView1.Columns(0).HeaderText = "kode"
        DataGridView1.Columns(1).HeaderText = "Nama"
        DataGridView1.Columns(2).HeaderText = "Alamat"
        DataGridView1.Columns(3).HeaderText = "No Telp"
    End Sub

    Sub TampilGrid()
        da = New MySqlDataAdapter("select * from konsumen", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
        nama.Focus()
    End Sub

    Sub Baru()
        kodekonsumen.Text = idselected + 1
        nama.Text = ""
        alamat.Text = ""
        notelp.Text = ""
    End Sub

    Sub Clear()
        kodekonsumen.Text = ""
        nama.Text = ""
        alamat.Text = ""
        notelp.Text = ""
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        If nama.Text = "" Or alamat.Text = "" Or notelp.Text = "" Then
            MsgBox("Silahkan Isi Semua Form")
        Else
            Call konek()
            Dim simpan As String = "insert into konsumen values (null, '" & nama.Text & "','" & alamat.Text & "','" & notelp.Text & "')"
            cmd = New MySqlCommand(simpan, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Input data berhasil")
            Call TampilGrid()
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Call konek()
        Dim edit As String = "update konsumen set nama='" & nama.Text & "',alamat='" & alamat.Text & "',telp='" & notelp.Text & "' where kodekonsumen='" + idselected + "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di update")
        Call TampilGrid()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim banyakrow As Integer = DataGridView1.RowCount - 2
        Dim indexnya As Integer = e.RowIndex
        If indexnya > banyakrow Then
            MsgBox("kelewatan")
        Else
            idselected = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim kode As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            Dim nm As String = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            Dim almt As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value
            Dim telp As String = DataGridView1.Rows(e.RowIndex).Cells(3).Value
            kodekonsumen.Text = kode
            nama.Text = nm
            alamat.Text = almt
            notelp.Text = telp
        End If
    End Sub

    Private Sub baru_Click(sender As Object, e As EventArgs) Handles tmblbaru.Click
        Baru()
    End Sub

    Private Sub tmblhapus_Click(sender As Object, e As EventArgs) Handles tmblhapus.Click
        Call konek()
        Clear()
        Dim edit As String = "delete from konsumen where kodekonsumen=" + idselected
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di hapus")
        Call TampilGrid()
    End Sub

    Sub search()
        da = New MySqlDataAdapter("select * from konsumen where nama like '%" & textsearch.Text & "%' or alamat like '%" & textsearch.Text & "%' or kodekonsumen like '%" & textsearch.Text & "%' or telp like '%" & textsearch.Text & "%'", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub

    Private Sub textsearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textsearch.KeyPress
        If e.KeyChar = Chr(13) Then
            search()
        End If
    End Sub

    Private Sub textsearch_TextChanged(sender As Object, e As EventArgs) Handles textsearch.TextChanged
        If Not textsearch.Text = "" Then
            search()
        End If

    End Sub
End Class
