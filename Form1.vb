Public Class Form1


    Private Sub btn_iniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_iniciar.Click
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True

       
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Beep.Beep.Beep(300, 1300, 3000)
    End Sub

    Private Sub btn_stop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_stop.Click
        BackgroundWorker1.CancelAsync()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Finalizado", MsgBoxStyle.Information, "CKPGen")
    End Sub

    Private Sub BW2_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BW2.DoWork
        WaveGen.GenerarOnda(pic, "G:\BasicProyects\CKPGen\CKPGen\bin\DebugSound.wav")

    End Sub

    Private Sub btn_verOnda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_verOnda.Click
        BW2.RunWorkerAsync()
    End Sub


End Class
