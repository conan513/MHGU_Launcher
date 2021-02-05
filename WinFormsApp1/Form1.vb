Imports System.Diagnostics

Public Class Launcher
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not System.IO.Directory.Exists("SPP-PortableNSWE")) Then
            Process.Start("git\update.bat")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ChDir("SPP-PortableNSWE\Yuzu")
        Process.Start("yuzu.exe")
        ChDir("..\..")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChDir("SPP-PortableNSWE\Ryujinx\")
        Process.Start("!start-portable.bat")
        ChDir("..\..")
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Each proc As Process In Process.GetProcessesByName("Ryujinx")
            proc.Kill()
        Next
        For Each proc As Process In Process.GetProcessesByName("Yuzu")
            proc.Kill()
        Next
        Process.Start("git\update.bat")
    End Sub
End Class
