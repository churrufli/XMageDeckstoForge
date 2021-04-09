Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            decks_dir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click
        If decks_dir.Text = "" Then
            txlog.Text = "Select Folder to convert files" & vbCrLf
            Exit Sub
        End If
        Dim files = Directory.GetFiles(decks_dir.Text, "*.dck", SearchOption.AllDirectories)
        Directory.CreateDirectory(Directory.GetCurrentDirectory & "\result")

        For Each foundedfile In files
            Dim name As String = Path.GetFileName(foundedfile)
            name = Replace(name, ".mwDeck", Nothing)
            name = Replace(name, ".dck", Nothing)
            Dim r As String
            r = File.ReadAllText(foundedfile)
            '   If r.Contains("NAME:") Then
            '       name = Split(r,"NAME:")(0).ToString
            '    r = Split(r,"NAME:",vblf)(1).ToString
            'End If
            If r.Contains("LAYOUT MAIN") Then r = Split(r, "LAYOUT MAIN")(0).ToString

            Dim t As String = "[metadata]" & vbLf & "Name=" & name & vbLf & "[Main]" & vbLf

            Dim lines = Split(r, vbLf)
            For i = 0 To lines.Length - 1
                Dim linea = lines(i)
                If linea <> "" Then

                    If linea.Contains("NAME:") Then
                        Dim newname = Split(linea, "NAME:")(1).ToString
                        t = Replace(t, "Name=" & name, "Name=" & newname)
                    Else

                        Dim c As String
                        Dim n As String
                        Dim l As String
                        If linea.Contains("SB:") Then
                            linea = Replace(linea, "SB: ", "")
                            If iscommander.Checked Then
                                If t.Contains("[Commander]") = False Then
                                    t = t & "[Commander]" & vbLf
                                End If
                            Else
                                If t.Contains("[Sideboard]") = False Then
                                    t = t & "[Sideboard]" & vbLf
                                End If
                            End If

                        End If
                        n = Split(linea, "[")(0).ToString()
                        c = Split(linea, "]")(1).ToString()
                        l = n & c & vbLf
                        l = Replace(l, "  ", " ")
                        t = t & l
                    End If
                End If
            Next i

            File.WriteAllText(
                Directory.GetCurrentDirectory & "\result\" & name & ".dck", t)
            WriteUserLog("Saving " & name & ".dck" & Environment.NewLine)
        Next
    End Sub

    Sub WriteUserLog(msg)
        txlog.SelectedText = msg
        txlog.SelectionStart = txlog.Text.Length
        txlog.ScrollToCaret()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://github.com/churrufli/")
    End Sub

    Private Sub iscommander_CheckedChanged(sender As Object, e As EventArgs) Handles iscommander.CheckedChanged

    End Sub
End Class
