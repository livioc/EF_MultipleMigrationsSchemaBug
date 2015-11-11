When trying to update the database with the second migration it will fails becouse it will try to create the
already existing table "public"."__MigrationHistory".

This are the Package Manager Console commands executed to get the current code:
* enable-migrations -ContextTypeName MultipleMigrationsSchemaBug.Dal.UserContext -MigrationsDirectory:Migrations\UserContextMigrations
* Add-Migration -configuration MultipleMigrationsSchemaBug.Migrations.UserContextMigrations.Configuration InitialMigration
* enable-migrations -ContextTypeName MultipleMigrationsSchemaBug.Dal.BookContext -MigrationsDirectory:Migrations\BookContextMigrations
* Add-Migration -configuration MultipleMigrationsSchemaBug.Migrations.BookContextMigrations.Configuration InitialMigration

To get the exception from the Package Manager Console:
* Update-Database -configuration MultipleMigrationsSchemaBug.Migrations.UserContextMigrations.Configuration -Verbose
* Update-Database -configuration MultipleMigrationsSchemaBug.Migrations.BookContextMigrations.Configuration -Verbose

To get the exception from the console application just run it


Note: the error is generated becouse the migration executed this psedo code
~~~
if table "dbo"."__MigrationHistory" not exists
then create table "public"."__MigrationHistory"
~~~
Note2: if i explicit set the schema of MigrationContext (as described in this link https://msdn.microsoft.com/en-us/data/dn456841.aspx)
it works (to try it add the compilation symbol WORKAROUND)