Imports System.Data.SQLite
Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call mySQLiteReadDB()
    End Sub
    Private Function MyDictionaryExists()
        MyDictionaryExists = False
        If My.Computer.FileSystem.FileExists("en-dictionary.db") Then
            MyStatusLine.Text = "Dictionary db file exists."
            'Debug.Print("Dictionary db file exists.")
            ListBox1.Items.Add("Dictionary db file exists.")
            MyDictionaryExists = True
        Else
            MyStatusLine.Text = "Dictionary db file does not exist."
            'Debug.Print("Dictionary db file does not exist.")
            ListBox1.Items.Add("Dictionary db file does not exist.")
        End If
    End Function

    Private Sub mySQLiteReadDB()
        Try
            If MyDictionaryExists() Then
                Dim myconnectionString = "Data Source=" & Application.StartupPath & "\en-dictionary.db" & ";Version=3; FailIfMissing=True;"
                Dim myConnection As SQLiteConnection = New SQLiteConnection()
                Dim myCommand As New SQLite.SQLiteCommand()
                Dim myData As SQLite.SQLiteDataReader

                myConnection.ConnectionString = myconnectionString
                myConnection.Open()
                ' execute queries, etc

                'get max row count.
                myCommand = myConnection.CreateCommand
                myCommand.CommandText = "SELECT count(*) as [maxcount] FROM e"
                myData = myCommand.ExecuteReader()
                myData.Read()

                'get the max records in the english db
                Dim maxrec
                maxrec = 0
                If myData.HasRows Then
                    maxrec = myData(0)
                    ListBox1.Items.Add("max record count: " & maxrec)
                    'Debug.Print("max record count: " & maxrec)
                    MyStatusLine.Text = "Dictionary db file exists." & maxrec & " entries."
                End If

                'just get me a random starting point st from 1 to maxrecords
                Dim st
                Dim random As New Random()
                random.Next()
                st = random.Next(1, maxrec)

                'check for the over, you won't run into the under
                'this means the st is ver close to maxrec
                If maxrec - st < 15 Then
                    'set the starting point (st) to what it was -25
                    st -= 25
                End If

                's now is a random start value in the record set

                myCommand = myConnection.CreateCommand
                'myCommand.CommandText = "SELECT * FROM e LIMIT 15 "
                myCommand.CommandText = "SELECT * FROM e where field1 >= " & st & " LIMIT 15"
                myData = myCommand.ExecuteReader()
                myData.Read()
                If myData.HasRows Then
                    ListBox1.Items.Add("Has rows. Reading 15 random records starting at row " & st)
                    Dim mycount
                    mycount = 1
                    Do While (myData.Read())
                        ListBox1.Items.Add(mycount & ") " & myData(1) & "," & myData(2) & ", " & myData(3))
                        'Debug.Print(mycount & ") " & myData(1) & ", " & myData(2) & ", " & myData(3))
                        mycount = mycount + 1
                    Loop
                End If

                myConnection.Close()
            End If

        Catch
            'nothing here to do
        Finally
            'nothing here to do
        End Try

    End Sub

    Private Sub BtnRandomWords_Click(sender As Object, e As EventArgs) Handles BtnRandomWords.Click
        ListBox1.Items.Clear()
        Call mySQLiteReadDB()
    End Sub

    Private Sub BtnGames_Click(sender As Object, e As EventArgs) Handles BtnGames.Click
        Form2.Show()
    End Sub


End Class