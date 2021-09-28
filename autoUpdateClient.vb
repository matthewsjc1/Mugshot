Public Class autoUpdateClient

    'inter-app message strings
    Private Const CLIENT_APP_CONTINUE_RUNNING_MESSAGE As String = "client_app_continue_running"
    Private Const CLIENT_APP_STOP_RUNNING_MESSAGE As String = "client_app_stop_running"

    Private Const AUTO_UPDATER_EXE_NAME As String = "Auto-Updater.exe"

    'PUBLIC METHODS********************************************************************************

    Public Sub StartAutoUpdater()

        Dim wasSuccessful As Boolean = False

        Try

            System.Diagnostics.Process.Start(AppContext.BaseDirectory + AUTO_UPDATER_EXE_NAME)

        Catch ex As Exception

            MessageBox.Show("Unable to start Auto-Updater." + vbCrLf + "Please contact jmatthews@earthsunmoon.com for assistance.", "Auto-Updater Error")
            wasSuccessful = False

        End Try

    End Sub

    Public Sub WaitForClientMessage()

        Dim wasMessageFound As Boolean = False
        Dim continueRunning As Boolean = True

        Do

            If My.Computer.Clipboard.ContainsText() = True Then

                If My.Computer.Clipboard.GetText() = CLIENT_APP_CONTINUE_RUNNING_MESSAGE Then

                    wasMessageFound = True
                    continueRunning = True

                ElseIf My.Computer.Clipboard.GetText() = CLIENT_APP_STOP_RUNNING_MESSAGE Then

                    wasMessageFound = True
                    continueRunning = False

                End If

            End If

            Application.DoEvents()

        Loop Until wasMessageFound = True

        My.Computer.Clipboard.Clear()

        If continueRunning = False Then

            End

        End If

    End Sub

End Class
