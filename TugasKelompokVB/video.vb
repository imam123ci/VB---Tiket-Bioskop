Imports System.IO
Public Class Video
    Dim FilePath As String
    Dim file_counter As Integer

    Sub PlayVideo()
        AxWindowsMediaPlayer1.URL = FilePath
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Public Sub New(ByVal item As String)
        InitializeComponent()

        If item = "KÀ" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "KAtrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.KAtrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "Michael Jackson ONE" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "MJtrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.MJtrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "The Beatles LOVE" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "beatlestrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.beatlestrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "Alegria" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "Alegriatrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.Alegriatrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "KOOZA" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "KOOZAtrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.KOOZAtrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "Corteo" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "Corteotrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.Corteotrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If

        If item = "O" Then
            AxWindowsMediaPlayer1.uiMode = "full"
            FilePath = Path.Combine(Application.StartupPath, "Otrailer.mp4")
            If (Not File.Exists(FilePath)) Then
                File.WriteAllBytes(FilePath, My.Resources.Otrailer)
            End If
            file_counter = 1
            PlayVideo()
        End If
    End Sub

End Class