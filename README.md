Getting Started with RavenDB Index Replication Bundle
=====================================================
Being able to push Raven data out to a SQL-based data repository for reporting will be a huge boost to RavenDB adoption. The Index Replication Bundle does a great job of solving that problem, but the documentation is a little weak.

This sample provides working code to get someone started with using the bundle.

+ Create a "Plugins" directory under the directory where Raven.Server.exe resides.
+ Add a connection string to Raven.Server.exe.config...
	<connectionStrings>
    <add name="Reports"
         providerName="System.Data.SqlClient"
         connectionString="Data Source=(local);Initial Catalog=Sample;Integrated Security=SSPI;"/>
	</connectionStrings>
+ Create a database in SQL Server called "Sample".
+ Run the program.
+ Click the Create Table button.
+ Click the Create Index button.
+ Click the configure Replication button.
+ Add a dog to Raven

You should see that dog appear in the Dogs table in SQL Server.