using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

public partial class StoredProcedures
{
    [Microsoft.SqlServer.Server.SqlProcedure]
    public static void SqlStoredProcedure1 ()
    {
        // Put your code here

        // communiquer avec le Server SQL 
        // Send
        // Comment communiquer ? 
        // pour cela on utilise un Pipe : SqlPipe

        // 1 - Déclarer un Pipe

        SqlPipe p;

        // Rattache le Pipe au context du Server
        p = SqlContext.Pipe;
        p.Send(DateTime.Today.ToString());
        // Uploader la procedure sur le server

       
    }
}
