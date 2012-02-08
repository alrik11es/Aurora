Module MySQL
    Function escape(query As String)
        query = query.Replace("'", "\'")
        Return query
    End Function
End Module
