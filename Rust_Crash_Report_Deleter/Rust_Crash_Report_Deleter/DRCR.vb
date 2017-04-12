Public Class DRCR
    Private Sub DRCR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0

        'Target Directory
        Dim directory = "C:\Program Files (x86)\Steam\steamapps\common\Rust\"

        'Searches directory and it's subdirectories for all files, which "*" stands for
        'Say for example you only want to search for jpeg files... then change "*" to "*.jpg"  
        For Each filename As String In IO.Directory.GetFiles(directory, "*", IO.SearchOption.AllDirectories)

            'The next line of code gets only file extensions from searched directories and subdirectories
            Dim fName As String = IO.Path.GetFileName(filename)

            If fName = "_CommonRedist" Then

                'Skips to next iteration of Loop, ignoring files with filename
                Continue For

            Else
                If fName = "Bundles" Then

                    'Skips to next iteration of Loop, ignoring files with filename
                    Continue For

                Else
                    If fName = "cfg" Then

                        'Skips to next iteration of Loop, ignoring files with filename 
                        Continue For

                    Else
                        If fName = "EasyAntiCheat" Then

                            'Skips to next iteration of Loop, ignoring files with filename
                            Continue For

                        Else
                            If fName = "maps" Then

                                'Skips to next iteration of Loop, ignoring files with filename
                                Continue For

                            Else
                                If fName = "RustClient_Data" Then

                                    'Skips to next iteration of Loop, ignoring files with filename
                                    Continue For

                                Else
                                    If fName = "Screenshots" Then

                                        'Skips to next iteration of Loop, ignoring files with filename
                                        Continue For

                                    Else
                                        If fName = "storage" Then

                                            'Skips to next iteration of Loop, ignoring files with filename
                                            Continue For

                                        Else
                                            If fName = "EasyAntiCheat.Client.dll" Then

                                                'Skips to next iteration of Loop, ignoring files with filename
                                                Continue For

                                            Else
                                                If fName = "Rust.exe" Then

                                                    'Skips to next iteration of Loop, ignoring files with filename 
                                                    Continue For

                                                Else
                                                    If fName = "RustClient.exe" Then

                                                        'Skips to next iteration of Loop, ignoring files with filename 
                                                        Continue For

                                                    Else
                                                        If fName = "steam_api64.dll" Then

                                                            'Skips to next iteration of Loop, ignoring files with filename
                                                            Continue For

                                                        Else
                                                            If fName = "steam_appid.txt" Then

                                                                'Skips to next iteration of Loop, ignoring files with filename
                                                                Continue For

                                                            Else
                                                                If fName = "win_installscript.vdf" Then

                                                                    'Skips to next iteration of Loop, ignoring files with filename
                                                                    Continue For

                                                                Else

                                                                    'Kill function deletes all files in target directory and it's subdirectories 
                                                                    System.IO.File.Delete(directory & fName)

                                                                    'The below counter only displays the final count after all files have been processed
                                                                    i = i + 1
                                                                    TextBox1.Text = Convert.ToString(i)
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("IEXPLORE.exe", LinkLabel1.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

End Class
