Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Scan.Click
        Dim Scanner As New MessagingToolkit.Barcode.BarcodeDecoder

        Dim result As MessagingToolkit.Barcode.Result
        Try
            result = Scanner.Decode(New Bitmap(PictureBox1.Image))
            MsgBox(result.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button_Generate_Click(sender As Object, e As EventArgs) Handles Button_Generate.Click
        Dim Generator As New MessagingToolkit.Barcode.BarcodeEncoder
        Generator.IncludeLabel = True
        Generator.CustomLabel = TextBox1.Text
        Try
            PictureBox1.Image = New Bitmap(Generator.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128B, TextBox1.Text))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button_Save_Click(sender As Object, e As EventArgs) Handles Button_Save.Click
        Dim SD As New SaveFileDialog
        SD.Filter = "PNG File|*.png"
        If SD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Image.Save(SD.FileName, Imaging.ImageFormat.Png)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button_Load_Click(sender As Object, e As EventArgs) Handles Button_Load.Click
        Dim OD As New OpenFileDialog
        OD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        If OD.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox1.Load(OD.FileName)
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
