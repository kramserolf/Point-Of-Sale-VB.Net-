Module crud

#Region "New Crud"
    Public Function JANOBECREATE(ByVal sql As String) As Boolean

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            result = cmd.ExecuteNonQuery()


            Return True

        Catch ex As Exception
            logs(ex.Message & " at JANOBECREATE Function")
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return True
    End Function
    Public Function JANOBEDELETE(ByVal sql As String) As Boolean

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            logs(ex.Message & " at JANOBEDELETE Function")
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return True
    End Function
    Public Function JANOBEUPDATE(ByVal sql As String) As Boolean

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            result = cmd.ExecuteNonQuery
            Return True
        Catch ex As Exception
            logs(ex.Message & " at JANOBEUPDATE Function")
            MsgBox(ex.Message)
        Finally
            con.Close()

        End Try
        Return True
    End Function

    Public Function RETRIEVEDATA(ByVal sql As String, ByVal dtg As DataGridView) As Boolean
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)



            dtg.DataSource = dt

            With dtg
                '.Columns(0).Width = 18
                '   .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                .Columns(0).Visible = False
                .Font = New Font("arial", 8, FontStyle.Bold)
                '.SelectionMode = False
            End With
            Return True

        Catch ex As Exception
            logs(ex.Message & " at retrieve sub Procedure")
            MsgBox(ex.Message)
        Finally

            con.Close()
            da.Dispose()

        End Try
        Return True
    End Function

    Public Sub LoadDTG(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)



            dtg.DataSource = dt


        Catch ex As Exception
            logs(ex.Message & " at retrieve sub Procedure")
            MsgBox(ex.Message)
        Finally

            con.Close()
            da.Dispose()

        End Try
    End Sub

    Public Function RETRIEVESIGLE(ByVal sql As String) As Boolean

        Try
            con.Open()
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = sql
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            'da.Fill(ds, "tblProductInfo")
            If dt.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If



        Catch ex As Exception
            logs(ex.Message & " at retrieveSingleResult sub Procedure")
            MsgBox(ex.Message)
        Finally

            con.Close()
            da.Dispose()

        End Try
        Return True
    End Function

    Private _userid As String
    Private _uname As String

    Public Property UserID() As String
        Get
            Return _userid
        End Get
        Private Set(ByVal value As String)
            _userid = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return _uname
        End Get
        Private Set(ByVal value As String)
            _uname = value
        End Set
    End Property

#End Region
    Public Function login(ByVal username As Object, ByVal pass As Object) As Boolean
        Try


            RETRIEVESIGLE("SELECT * FROM tblUser WHERE U_UNAME= '" & username & "' and U_PASS = '" & pass & "'")

            With Form1

                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("U_TYPE") = "Administrator" Then
                        MsgBox("You have successfully logged in as an " & dt.Rows(0).Item("U_TYPE"))
                        .ManageProductsToolStripMenuItem.Enabled = True
                        .ManageUsersToolStripMenuItem.Enabled = True
                        .ReportsToolStripMenuItem.Enabled = True
                        .tsPOS.Enabled = True
                        .tsSearchProducts.Enabled = True


                    ElseIf dt.Rows(0).Item("U_TYPE") = "Cashier" Then
                        MsgBox("You have successfully logged in as a " & dt.Rows(0).Item("U_TYPE"))

                        .tsPOS.Enabled = True
                        .tsSearchProducts.Enabled = True

                    ElseIf dt.Rows(0).Item("U_TYPE") = "Staff" Then
                        MsgBox("You have successfully logged in as a " & dt.Rows(0).Item("U_TYPE"))
                        .ManageProductsToolStripMenuItem.Enabled = True
                        .ReportsToolStripMenuItem.Enabled = True
                        .tsPOS.Enabled = True
                        .tsSearchProducts.Enabled = True
                    End If
                    _userid = dt.Rows(0).Item("USERID")

                    .LoginToolStripMenuItem.Text = "Logout"
                    frmLogin.Close()
                Else
                    MsgBox("Acount doest not exist! Please contact Administrator.", MsgBoxStyle.Information)
                End If
            End With
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return True
    End Function
End Module



