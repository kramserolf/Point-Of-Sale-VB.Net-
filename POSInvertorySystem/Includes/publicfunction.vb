Imports System.IO
Module publicfunction
    Public Sub clear(ByVal container As Object)
        Try
            For Each txt As Control In container.Controls
                If TypeOf txt Is TextBox Or TypeOf txt Is RichTextBox Then
                    txt.Text = ""
                End If
            Next
        Catch ex As Exception
            logs(ex.Message & " at clear sub Procedure")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub RDOclear(ByVal container As Object)
        Try

            With container
                .rdoToday.Checked = False
                .rdoWeekly.Checked = False
                .rdoMonthly.Checked = False
                .rdo21days.Checked = False
            End With

            'For Each RDO As Control In container.Controls
            '    If TypeOf RDO Is RadioButton Then

            '    End If
            'Next
        Catch ex As Exception
            logs(ex.Message & " at clear sub Procedure")
            'MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub logs(ByVal errormsg As Object)
        Try
            'DECLARE A STRING VARIABLE TO HOLD THE PATH AND THE NAME OF THE TEXT FILE 
            Dim path_file As String = String.Format(Application.StartupPath & "\errorlogs\Logs.log", DateTime.Today.ToString("dd-MMM-yyyy"))
            'DECLARE A BOOLEAN VARIABLE TO DETERMINE WHETHER THE SPECIFIED FILE EXIST.
            Dim exist_file As Boolean = File.Exists(path_file)
            'CALL STREAMWRITER AND USE IT TO CREATE A TXT FILE.
            Using stream_writer As New StreamWriter(path_file, True)
                If Not exist_file Then 'CHECK THE TXT FILE IF IT DOES'NT EXIST.
                    'RESULT
                    'WRITE THE TEXT IN THE FIRST LINE.
                    stream_writer.WriteLine("Log starts")
                End If
                'WRITE THE ERROR MESSAGE.
                stream_writer.WriteLine("The Error Occured at " & DateTime.Now & " :: " & errormsg)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & "at logs sub")
        End Try

    End Sub

    Public Sub CBOFILL(ByVal query As String, ByVal combo As ComboBox, ByVal member As String, ByVal id As String)
        Try
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd
 
            'ds = New DataSet
            dt = New DataTable
            da.Fill(dt)


            'da.Fill(ds, "tblCategory")
            'ds.Tables(0).Rows.Add(1, "Select")

            dt.NewRow()
            dt.Rows.Add(1, "Select")
            With combo
                '.Items.Clear()
                .DataSource = dt
                .DisplayMember = member
                .ValueMember = id
                .Text = "Select"
                '.Items.Add("selects")
                '.SelectedValue = True
                '.Refresh()
            End With


        Catch ex As Exception
            logs(ex.Message & " at CBOFILL sub Procedure")
            MsgBox(ex.Message & " at CBOFILL sub Procedure")
        End Try
    End Sub
 
    Public Sub txtAutoComplete(ByVal query As String, ByVal txt As Object)
        Try
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = query
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            txt.AutoCompleteMode = AutoCompleteMode.Suggest
            txt.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt.AutoCompleteCustomSource.clear()
            Dim r As DataRow

            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next r




        Catch ex As Exception
            logs(ex.Message & " at txtAutoComplete sub Procedure")
            MsgBox(ex.Message & " at txtAutoComplete sub Procedure")
        End Try
    End Sub
    Public Sub checkData(ByVal Checkquery As String, ByVal insertQuery As String, ByVal updateQuery As String)
        Try
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = Checkquery
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                JANOBEUPDATE(updateQuery)
            Else
                JANOBECREATE(insertQuery)
            End If

        Catch ex As Exception
            logs(ex.Message & " at checkData sub Procedure")
            MsgBox(ex.Message & " at checkData sub Procedure")
        End Try
    End Sub
    Public Sub checkTransaction(ByVal Checkquery As String, ByVal insertQuery As String, ByVal updateQuery As String)
        Try
            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = Checkquery
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                JANOBEUPDATE(updateQuery)
            Else
                JANOBECREATE(insertQuery)
            End If

        Catch ex As Exception
            logs(ex.Message & " at checkData sub Procedure")
            MsgBox(ex.Message & " at checkData sub Procedure")
        End Try
    End Sub
    Public Function FindMyText(ByVal text As String, ByVal start As Integer, ByVal richTextBox As RichTextBox) As Integer
        ' Initialize the return value to false by default.
        Dim returnValue As Integer = -1

        ' Ensure that a search string has been specified and a valid start point.
        If text.Length > 0 And start >= 0 Then
            ' Obtain the location of the search string in richTextBox1.
            Dim indexToText As Integer = richTextBox.Find(text, start, _
                RichTextBoxFinds.MatchCase)
            ' Determine whether the text was found in richTextBox1.
            If indexToText >= 0 Then
                MsgBox(indexToText)
            End If
        End If

        Return returnValue
    End Function
    Public Function txtAutoNumber(ByVal autoid As Integer, ByVal txt As Object) As Boolean

        Try
            con.Open()

            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = "SELECT (STARTNUM & ENDNUM) FROM tblAutonumber WHERE ID=" & autoid
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd

            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                txt.text = dt.Rows(0).Item(0)
            End If
        Catch ex As Exception
            logs(ex.Message & " at txtAutoNumber sub Procedure")
            MsgBox(ex.Message & " at txtAutoNumber sub Procedure")
        Finally
            con.Close()
            da.Dispose()

        End Try
        Return True
    End Function
    Public Function updateAutoNumber(ByVal autoid As Integer, ByVal txt As Object) As Boolean
        con.Open()
        Try

            cmd = New OleDb.OleDbCommand
            With cmd
                .Connection = con
                .CommandText = "UPDATE tblAutonumber SET  ENDNUM=ENDNUM + INCNUM  WHERE ID=" & autoid
            End With

            da = New OleDb.OleDbDataAdapter
            da.SelectCommand = cmd
            result = cmd.ExecuteNonQuery

        Catch ex As Exception
            logs(ex.Message & " at txtAutoNumber sub Procedure")
            MsgBox(ex.Message & " at txtAutoNumber sub Procedure")

        Finally
            con.Close()
        End Try
        Return True
    End Function
 

    Public Function DECREASEITEMQTY(ByVal id As Integer, ByVal qty As Integer) As Boolean
        Try

            updateQuery = "UPDATE tblItems SET ITEMQTY = ITEMQTY - " & qty & " WHERE ITEMID =" & id
            JANOBEUPDATE(updateQuery)


            Return True
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        Return True
    End Function

#Region "EDIT TRANSACTIONS"
    Public Sub TRANSACTIONPROCESS(ByVal ACTIONTABLE As String, ByVal TBL As String, ByVal TRANSNUM As Integer, ByVal QTY As Double)
        Try
            Select Case ACTIONTABLE
                Case "ADD_QTY_PRODUCT"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROID = S.PROID AND TRANSNUM =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

                Case "DEDUCT_QTY_PRODUCT"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY- " & QTY & " WHERE P.PROID = S.PROID AND TRANSNUM =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

                Case "DEDUCT_QTY_STOCKOUT"
                    updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY - " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

                Case "ADD_QTY_STOCKOUT"
                    updateQuery = "UPDATE  " & TBL & "  SET OUTQTY = OUTQTY + " & QTY & " WHERE  TRANSNUM =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

                Case "ADD_QTY_RETURN"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY + " & QTY & " WHERE P.PROID = S.PROID AND RETURNEDPROID =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

                Case "DEDUCT_QTY_RETURN"
                    updateQuery = "UPDATE tblProductInfo AS P," & TBL & " AS S SET PROQTY = PROQTY - " & QTY & " WHERE P.PROID = S.PROID AND RETURNEDPROID =" & TRANSNUM
                    JANOBEUPDATE(updateQuery)

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
#End Region

    Public Sub frmMaxMinSize(ByVal frm As Form, ByVal w As Integer, ByVal h As Integer)
        frm.MaximumSize = New Size(w, h)
        frm.MinimumSize = New Size(w, h)
        frm.StartPosition = FormStartPosition.CenterScreen
    End Sub

#Region "Report"
    Public Sub reports(ByVal sql As String, ByVal rptname As String, ByVal crystalRpt As Object)
        Try
            con.Open()

            Dim reportname As String
            With cmd
                .Connection = con
                .CommandText = sql
            End With
            ds = New DataSet
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds)
            reportname = rptname
            Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim strReportPath As String
            strReportPath = Application.StartupPath & "\report\" & reportname & ".rpt"
            With reportdoc
                .Load(strReportPath)
                .SetDataSource(ds.Tables(0))
            End With
            With crystalRpt
                .ShowRefreshButton = False
                .ShowCloseButton = False
                .ShowGroupTreeButton = False
                .ReportSource = reportdoc
            End With
        Catch ex As Exception
            MsgBox(ex.Message & "No Crystal Reports have been Installed")
        End Try
        con.Close()
        da.Dispose()
    End Sub
#End Region

#Region "Invertory Search"
    Public Sub rdoStock(ByVal action As String, ByVal cbo As Object, ByVal txt As Object, ByVal dtglist As DataGridView)
        Try
            Dim condition As String
            Select Case action
                Case "Today"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy')"
                        STOCK_SEARCH(dtglist, condition)
                    Else
                        condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy') AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        STOCK_SEARCH(dtglist, condition)
                    End If

                Case "Weekly"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW())"
                        STOCK_SEARCH(dtglist, condition)
                    Else
                        condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        STOCK_SEARCH(dtglist, condition)
                    End If
                Case "21days"
                    ' SOLD_SEARCH(dtglist, condition)
                Case "Monthly"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND MONTH(TRANSDATE) =MONTH(NOW())"
                        STOCK_SEARCH(dtglist, condition)
                    Else
                        condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        STOCK_SEARCH(dtglist, condition)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub rdoSold(ByVal action As String, ByVal cbo As Object, ByVal txt As Object, ByVal dtglist As DataGridView)
        Try
            Dim condition As String
            Select Case action
                Case "Today"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy')"
                        SOLD_SEARCH(dtglist, condition)
                    Else
                        condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy') AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        SOLD_SEARCH(dtglist, condition)
                    End If

                Case "Weekly"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW())"
                        SOLD_SEARCH(dtglist, condition)
                    Else
                        condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        SOLD_SEARCH(dtglist, condition)
                    End If
                Case "21days"
                    ' SOLD_SEARCH(dtglist, condition)
                Case "Monthly"
                    If cbo.text = "Select" And txt.text = "" Then
                        condition = "AND MONTH(TRANSDATE) =MONTH(NOW())"
                        SOLD_SEARCH(dtglist, condition)
                    Else
                        condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                        SOLD_SEARCH(dtglist, condition)
                    End If
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Inventory Reports"
    Public Sub Stockin(ByVal rptname As String, ByVal crystalrpt As Object, ByVal condition As String, ByVal dates As String, ByVal cbo As Object, ByVal txt As Object)

        Select Case dates

            Case "Today"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy')"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy') AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt) 
                End If

            Case "Weekly"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW())"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt)
                End If
                
            Case "21days"
                'If cbo.text = "Select" And txt.text = "" Then
                '    condition = ""
                '    query = "SELECT I.ITEMID, TRANSNUM, ITEMNAME ,DESCRIPTION,CATEGORIES,UPRICE,FORMAT(TRANSDATE,'MM/dd/yyyy'),TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMID=I.ITEMID AND I.CATEGPROID=C.CATEGPROID " & condition
                '    reports(query, rptname, crystalrpt)
                'Else
                '    condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                '    query = "SELECT I.ITEMID, TRANSNUM, ITEMNAME ,DESCRIPTION,CATEGORIES,UPRICE,FORMAT(TRANSDATE,'MM/dd/yyyy'),TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMID=I.ITEMID AND I.CATEGPROID=C.CATEGPROID " & condition
                '    reports(query, rptname, crystalrpt)
                'End If
                
            Case "Monthly"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND MONTH(TRANSDATE) =MONTH(NOW())"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  " & condition
                    reports(query, rptname, crystalrpt)
                End If
               
            Case Else
                If cbo.text = "Select" And txt.text = "" Then
                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  "
                    reports(query, rptname, crystalrpt)
                Else

                    query = "SELECT  TRANSNUM,FORMAT(TRANSDATE,'MM/dd/yyyy'), (ITEMNAME & ', ' &  DESCRIPTION & ', ' & CATEGORIES),OPRICE, UPRICE,TRANSQTY  , TOTPRICE  FROM tblStockIn as S, tblItems AS I, tblCategory AS C  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID  AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'" & condition
                    reports(query, rptname, crystalrpt)
                End If
               

        End Select


    End Sub

    Public Sub Stockout(ByVal rptname As String, ByVal crystalrpt As Object, ByVal condition As String, ByVal dates As String, ByVal cbo As Object, ByVal txt As Object)
        'query = "SELECT  I.ITEMID, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND I.ITEMID=SO.ITEMID AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
        'reports(query, rptname, crystalrpt)


        Select Case dates

            Case "Today"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy')"
                    query = "SELECT  I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND  SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND FORMAT( TRANSDATE ,'mm/dd/yyyy')= FORMAT(NOW(),'mm/dd/yyyy') AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                End If

            Case "Weekly"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW())"
                    query = "SELECT  I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND DATEPART('ww', TRANSDATE )= DATEPART('ww',NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                End If

            Case "21days"
                'If cbo.text = "Select" And txt.text = "" Then
                '    condition = ""
                '      query = "SELECT  I.ITEMID, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND I.ITEMID=SO.ITEMID AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                '    reports(query, rptname, crystalrpt)
                'Else
                '    condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                '     query = "SELECT  I.ITEMID, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND I.ITEMID=SO.ITEMID AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                '     reports(query, rptname, crystalrpt)
                'End If

            Case "Monthly"
                If cbo.text = "Select" And txt.text = "" Then
                    condition = "AND MONTH(TRANSDATE) =MONTH(NOW())"
                    query = "SELECT I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                Else
                    condition = "AND MONTH(TRANSDATE) =MONTH(NOW()) AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'"
                    query = "SELECT I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & condition
                    reports(query, rptname, crystalrpt)
                End If

            Case Else
                If cbo.text = "Select" And txt.text = "" Then
                    query = "SELECT I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND  SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID"
                    reports(query, rptname, crystalrpt)
                Else

                    query = "SELECT  I.ITEMBARCODE, SM.TRANSNUM  ,TRANSDATE , ITEMNAME ,DESCRIPTION,CATEGORIES ,OPRICE,TRANSQTY, SUBTOTAL  FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM   WHERE C.CATEGPROID=I.CATEGPROID AND SO.ITEMBARCODE=I.ITEMBARCODE AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID  AND C.CATEGPROID=" & cbo.SelectedValue & " AND ITEMNAME LIKE '%" & txt.Text & "%'" & condition
                    reports(query, rptname, crystalrpt)
                End If


        End Select

    End Sub
#End Region

End Module
