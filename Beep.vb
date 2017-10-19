Imports System.IO
Imports System.Media

Module Beep

    Public Class Beep
        Shared Sub Beep(ByVal Amplitude As Integer, _
                 ByVal Frequency As Integer, _
                 ByVal Duration As Integer)
            Dim A As Double = ((Amplitude * 2 ^ 15) / 1000) - 1
            Dim DeltaFT As Double = 2 * Math.PI * Frequency / 44100

            Dim Samples As Integer = 441 * Duration \ 10
            Dim Bytes As Integer = Samples * 4
            Dim Hdr() As Integer = {&H46464952, 36 + Bytes, &H45564157, _
                                    &H20746D66, 16, &H20001, 44100, _
                                     176400, &H100004, &H61746164, Bytes}
            Using MS As New MemoryStream(44 + Bytes)
                Using BW As New BinaryWriter(MS)
                    For I As Integer = 0 To Hdr.Length - 1
                        BW.Write(Hdr(I))
                    Next
                    For T As Integer = 0 To Samples - 1
                        Dim Sample As Short = CShort(A * Math.Sin(DeltaFT * T))
                        BW.Write(Sample)
                        BW.Write(Sample)
                    Next
                    BW.Flush()
                    MS.Seek(0, SeekOrigin.Begin)
                    Dim fs As FileStream = File.Create(Path.GetDirectoryName(Application.ExecutablePath) + "Sound.wav")
                    fs.Write(MS.ToArray, 0, MS.Length)
                    Using SP As New SoundPlayer(MS)
                        SP.PlaySync()
                    End Using
                End Using
            End Using

        End Sub
    End Class
End Module
