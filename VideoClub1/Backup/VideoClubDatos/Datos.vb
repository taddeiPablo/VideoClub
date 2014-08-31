Imports System.Data.SqlClient

Public Class Datos

    Private sqlconn As SqlConnection
    Private sqlcommand As SqlCommand
    Private sqlDataAdapter As SqlDataAdapter

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ConnectionSQL() As SqlConnection
        Get
            Return Me.sqlconn
        End Get
        Set(ByVal value As SqlConnection)
            Me.sqlconn = value
        End Set
    End Property

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        Try
            sqlconn = New SqlConnection(My.Settings.Setting)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub abrirConexion()
        Me.sqlconn.Open()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sp"></param>
    ''' <param name="dtTable"></param>
    ''' <remarks></remarks>
    Public Sub cargarTablas(ByVal sp As String, ByVal dtTable As DataTable)
        Try
            Me.sqlconn.Open()
            Me.sqlcommand = New SqlClient.SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            Me.sqlDataAdapter = New SqlClient.SqlDataAdapter(Me.sqlcommand)
            Me.sqlDataAdapter.Fill(dtTable)
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.sqlDataAdapter.Dispose()
            Me.Finalize()
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sp"></param>
    ''' <param name="params"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function existe(ByVal sp As String, ByVal params As SqlParameter()) As Integer
        Try
            Me.sqlconn.Open()
            Me.sqlcommand = New SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlcommand.ExecuteNonQuery()
            Return params(1).Value
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.Finalize()
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sp"></param>
    ''' <param name="params"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function existePelicula(ByVal sp As String, ByVal params As SqlParameter()) As String
        Try
            Me.sqlconn.Open()
            Me.sqlcommand = New SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlcommand.ExecuteNonQuery()
            Return params(1).Value
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.Finalize()
        End Try
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sp"></param>
    ''' <param name="params"></param>
    ''' <remarks></remarks>
    Public Sub Abm(ByVal sp As String, ByVal params As SqlParameter())
        Try
            Me.sqlconn.Open()
            Me.sqlcommand = New SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlcommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.Finalize()
        End Try
    End Sub

#Region "TRANSACCIONES"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sp"></param>
    ''' <param name="params"></param>
    ''' <param name="sqltrans"></param>
    ''' <remarks></remarks>
    Public Sub abmAlquileres_Compras(ByVal sp As String, ByVal params As SqlParameter(), ByRef sqltrans As SqlTransaction)
        Try
            Me.sqlcommand = New SqlCommand()
            Me.sqlcommand.Connection = Me.sqlconn
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            Me.sqlcommand.CommandText = sp
            Me.sqlcommand.Transaction = sqltrans
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlcommand.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub actualizarCatalogoTran(ByVal sp As String, ByVal dtCatalogo As DataTable, ByVal sqltrans As SqlTransaction)
        Try
            Me.sqlcommand = New SqlCommand()
            Me.sqlcommand.Connection = Me.sqlconn
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            Me.sqlcommand.CommandText = sp
            Me.sqlcommand.Transaction = sqltrans
            Me.sqlDataAdapter = New SqlClient.SqlDataAdapter(Me.sqlcommand)
            Me.sqlDataAdapter.Fill(dtCatalogo)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub actualizarAlqTrans(ByVal sp As String, ByVal dtTabla As DataTable, ByVal params As SqlParameter(), ByVal sqlTrans As SqlTransaction)
        Try
            Me.sqlcommand = New SqlCommand()
            Me.sqlcommand.Connection = Me.sqlconn
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            Me.sqlcommand.CommandText = sp
            Me.sqlcommand.Transaction = sqlTrans
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlDataAdapter = New SqlClient.SqlDataAdapter(Me.sqlcommand)
            Me.sqlDataAdapter.Fill(dtTabla)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Public Sub cargarTablasALQ_COMPRAS(ByVal sp As String, ByVal dtTables As DataTable, ByVal params As SqlParameter())
        Try
            Me.sqlcommand = New SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            For Each param As SqlParameter In params
                Me.sqlcommand.Parameters.Add(param)
            Next
            Me.sqlDataAdapter = New SqlDataAdapter(Me.sqlcommand)
            Me.sqlDataAdapter.Fill(dtTables)
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.Finalize()
        End Try
    End Sub


    Public Sub cargarTablaVista(ByVal sp As String, ByVal dtTable As DataTable)
        Try
            Me.sqlcommand = New SqlClient.SqlCommand(sp, Me.sqlconn)
            Me.sqlcommand.CommandType = CommandType.StoredProcedure
            Me.sqlDataAdapter = New SqlClient.SqlDataAdapter(Me.sqlcommand)
            Me.sqlDataAdapter.Fill(dtTable)
        Catch ex As Exception
            Throw ex
        Finally
            Me.sqlconn.Close()
            Me.sqlcommand.Dispose()
            Me.sqlDataAdapter.Dispose()
            Me.Finalize()
        End Try
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub close()
        Me.sqlconn.Close()
        Me.sqlcommand.Dispose()
        Me.Finalize()
    End Sub
#End Region
   
 

End Class
