Module RetrieveStocks
    Public Function List_of_Stocks(ByVal dtg As DataGridView) As Boolean

        query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode], TRANSNUM AS [Transaction#], ITEMNAME AS [Item],UPRICE AS [Price] ,TRANSDATE AS [TransactionDate],TRANSQTY  AS [Quantity], TOTPRICE AS [TotalPrice]  FROM tblStockIn as S, tblItems AS I, tblCategory AS C WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID"
        RETRIEVEDATA(query, dtg)
        Return True
    End Function
    Public Function Search_Stocks(ByVal condition As String, ByVal dtg As DataGridView) As Boolean

        query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode], TRANSNUM AS [Transaction#], ITEMNAME AS [Item],UPRICE AS [Price] ,TRANSDATE AS [TransactionDate],TRANSQTY  AS [Quantity], TOTPRICE AS [TotalPrice]  " &
                " FROM tblStockIn as S, tblItems AS I, tblCategory AS C " &
                " WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID AND " & condition
        RETRIEVEDATA(query, dtg)

        Return True
    End Function

    Public Function Autocomplete_ItemName(ByVal txt As TextBox) As Boolean
        query = "SELECT  ITEMNAME  FROM tblItems AS i, tblCategory AS c WHERE i.CATEGPROID=c.CATEGPROID "
        txtAutoComplete(query, txt)
        Return True
    End Function

    Public Function ALL_STOCKS(ByVal DTG As DataGridView) As Boolean
        query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode],  ITEMNAME AS [Item],DESCRIPTION AS [Description],CATEGORIES AS [Category], UPRICE AS [Price] ,ITEMQTY AS [Quantity], (UPRICE * ITEMQTY) AS [TotalPrice]  FROM tblItems AS I, tblCategory AS C WHERE  I.CATEGPROID=C.CATEGPROID"
        RETRIEVEDATA(query, DTG)
        Return True
    End Function

    Public Function ALL_STOCKS_SEARCH(ByVal DTG As DataGridView, ByVal condition As String) As Boolean
        query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode], ITEMNAME AS [Item],DESCRIPTION AS [Description],CATEGORIES AS [Category], UPRICE AS [Price] ,ITEMQTY AS [Quantity], (UPRICE * ITEMQTY) AS [TotalPrice]  FROM tblItems AS I, tblCategory AS C WHERE  I.CATEGPROID=C.CATEGPROID " & condition
        RETRIEVEDATA(query, DTG)
        Return True
    End Function
    Public Sub ALL_STOCK_REPORT(ByVal rptname As String, ByVal crystalrpt As Object, ByVal cbo As Object, ByVal txt As Object, ByVal condition As String)

        Try
            If cbo.text = "Select" And txt.text = "" Then
                query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode],  ITEMNAME ,DESCRIPTION  ,CATEGORIES , UPRICE  ,ITEMQTY  , (UPRICE * ITEMQTY)  FROM tblItems AS I, tblCategory AS C WHERE  I.CATEGPROID=C.CATEGPROID"
                reports(query, rptname, crystalrpt)
            Else
                query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode],  ITEMNAME ,DESCRIPTION  ,CATEGORIES , UPRICE  ,ITEMQTY  , (UPRICE * ITEMQTY)  FROM tblItems AS I, tblCategory AS C WHERE  I.CATEGPROID=C.CATEGPROID " & condition
                reports(query, rptname, crystalrpt)
            End If
        Catch ex As Exception

        End Try
    End Sub

#Region "TestRdo"
    Public Function SOLD_SEARCH(ByVal DTG As DataGridView, ByVal CONDITION As String) As Boolean
        'query = "SELECT  I.ITEMID, SM.TRANSNUM AS [Transaction#],TRANSDATE AS [TransactionDate], ITEMNAME AS [Item],DESCRIPTION AS [Description],CATEGORIES AS [Category],TRANSQTY AS [Quantity], SUBTOTAL AS [Subtotal] " & _
        '        " FROM tblCategory C,tblItems I,tblsoldout SO,tblUser U, tblsummary SM  " & _
        '        " WHERE C.CATEGPROID=I.CATEGPROID AND I.ITEMID=SO.ITEMID AND SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & CONDITION
        query = "SELECT  I.ITEMID,I.ITEMBARCODE AS [Barcode], SM.TRANSNUM AS [Transaction #]  ,FORMAT(TRANSDATE,'dd/MM/yyyy') AS [TransactionDate] ,( ITEMNAME  & ' ' & DESCRIPTION) AS [Items],CATEGORIES AS [Category],UPRICE AS [Markup Price],TRANSQTY AS [Quantity], SUBTOTAL AS [Total]  FROM tblItems I,tblCategory C,tblsoldout SO, tblsummary SM  ,tblUser U WHERE SO.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID AND  SO.TRANSNUM=SM.TRANSNUM AND SO.USERID=U.USERID " & CONDITION
        RETRIEVEDATA(query, DTG)
        Return True
    End Function
    Public Function STOCK_SEARCH(ByVal DTG As DataGridView, ByVal CONDITION As String) As Boolean
        'query = "SELECT I.ITEMID, TRANSNUM AS [Transaction#], ITEMNAME AS [Item],DESCRIPTION AS [Description],CATEGORIES AS [Category],UPRICE AS [Price] ,TRANSDATE AS [TransactionDate],TRANSQTY  AS [Quantity], TOTPRICE AS [TotalPrice]  " & _
        '        " FROM tblStockIn as S, tblItems AS I, tblCategory AS C " & _
        '        " WHERE S.ITEMID=I.ITEMID AND I.CATEGPROID=C.CATEGPROID " & CONDITION
        query = "SELECT I.ITEMID,I.ITEMBARCODE AS [Barcode], TRANSNUM AS [Transaction #],FORMAT(TRANSDATE,'MM/dd/yyyy') AS [TransactionDate], (ITEMNAME & ' ' &  DESCRIPTION) AS [Items],CATEGORIES AS [Category] ,OPRICE AS [Unit Price], UPRICE AS [Markup Price],TRANSQTY AS [Quantity]  , TOTPRICE  AS [Subtotal] FROM  tblItems AS I,tblCategory AS C, tblStockIn as S  WHERE S.ITEMBARCODE=I.ITEMBARCODE AND I.CATEGPROID=C.CATEGPROID " & CONDITION
        RETRIEVEDATA(query, DTG)
        Return True
    End Function

#End Region
End Module
