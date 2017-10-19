Module WaveGen
    Dim PictureBox1 As PictureBox
    Dim Samplez2
    Dim maxamount As Short
    Dim gfx As Graphics
    Dim pic
    Public ChangeBar As ProgressBar


    Function GenerarOnda(ByVal picturebox As PictureBox, ByVal file As String)
        pic = New Bitmap(picturebox.Width, picturebox.Height)
        gfx = Graphics.FromImage(pic)

        'Data storage
        Samplez2 = New List(Of Short)
        PictureBox1 = picturebox
        'ChangeBar.Value = 10
        GC.Collect()
        Dim wavefile() As Byte = IO.File.ReadAllBytes(file)
        GC.Collect()

        Dim memstream As New IO.MemoryStream(wavefile)
        Dim binreader As New IO.BinaryReader(memstream)

        Dim ChunkID As Integer = binreader.ReadInt32()
        Dim filesize As Integer = binreader.ReadInt32()
        Dim rifftype As Integer = binreader.ReadInt32()
        Dim fmtID As Integer = binreader.ReadInt32()
        Dim fmtsize As Integer = binreader.ReadInt32()
        Dim fmtcode As Integer = binreader.ReadInt16()
        Dim channels As Integer = binreader.ReadInt16()
        Dim samplerate As Integer = binreader.ReadInt32()
        Dim fmtAvgBPS As Integer = binreader.ReadInt32()
        Dim fmtblockalign As Integer = binreader.ReadInt16()
        Dim bitdepth As Integer = binreader.ReadInt16()
        ' ChangeBar.Value = 30
        If fmtsize = 18 Then
            Dim fmtextrasize As Integer = binreader.ReadInt16()
            binreader.ReadBytes(fmtextrasize)
        End If

        Dim DataID As Integer = binreader.ReadInt32()
        Dim DataSize As Integer = binreader.ReadInt32()
        'ChangeBar.Value = 40
        'Grabbing the data into 16bit words known as samples
        Samplez2.Clear()
        For i = 0 To (DataSize - 1) / 2

            Samplez2.Add(binreader.ReadInt16())

            If Samplez2(Samplez2.Count - 1) > maxamount Then 'Using this for the pic
                maxamount = Samplez2(Samplez2.Count - 1)
            End If

        Next
        ' ChangeBar.Value = 50
        DrawAudio()

        Return True

    End Function

    Private Sub DrawAudio()


        'Redefine since size changed
        pic = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        gfx = Graphics.FromImage(pic)

        'Clear picturebox
        gfx.FillRectangle(Brushes.Black, 0, 0, pic.Width, pic.Height)
        'ChangeBar.Value = 60

        Dim ratio As Integer = (Samplez2.Count - 1) / (pic.Width - 1) 'If there are 10000 samples and 200 pixels, this would be every 50th sample is shown
        Dim halfpic As Integer = (pic.Height / 2) 'Simply half the height of the picturebox
        'ChangeBar.Value = 75
        For i = 1 To pic.Width - 10 Step 2 'Steping 2 because in one go, we do 2 samples
            Dim leftdata As Integer = Math.Abs(Samplez2(i * ratio)) 'Grabbing that N-th sample to display. Using Absolute to show them one direction
            Dim leftpercent As Single = leftdata / (maxamount * 2) 'This breaks it down to something like 0.0 to 1.0. Multiplying by 2 to make it half.
            Dim leftpicheight As Integer = leftpercent * pic.Height 'So when the percent is tied to the height, its only a percent of the height
            gfx.DrawLine(Pens.LimeGreen, i, halfpic, i, leftpicheight + halfpic) 'Draw dat! The half pic puts it in the center

            Dim rightdata As Integer = Math.Abs(Samplez2((i + 1) * ratio)) 'Same thing except we're grabbing i + 1 because we'd skip it because of the 'step 2' on the for statement
            Dim rightpercent As Single = -rightdata / (maxamount * 2) 'put a negative infront of data so it goes down.
            Dim rightpicheight As Integer = rightpercent * pic.Height
            gfx.DrawLine(Pens.Blue, i, halfpic, i, rightpicheight + halfpic)

        Next
        'ChangeBar.Value = 100
        PictureBox1.Image = pic


    End Sub


End Module
