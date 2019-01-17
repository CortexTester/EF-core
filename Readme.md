in CBX.Data project 
	nuget install Microsoft.EntityFrameworkCore.sqlserver
	nuget install Microsoft.EntityFrameworkCore.tools and design //for data migration, not needed for web.api project. it may need by console project 

to migration.
	1. use Package Manager Console //get-help entityframeworkcore
	2. start project need to set to Cbx.Api (exe)  and Package Manager default project set to CBX.Data
	3. add-migration <name> //shoud creat files under migration floder
	4. optional, script-migration // create sql script
	5. update-database //create or update database form model
