			-----HUMAN RESOURCE MANAGEMENT SYSTEM INSTALLATION GUIDE -----

						| Regarding the Database |
Before installing, please be mindful of the following prerequisite programs needed to install the application:
	- SQL Server Express 2019 or later
	- SQL Server Express 2019 LocalDB
	- SQL Server Management Studio

If these software are not currently installed in your device, it is required that they be installed to run the application.
SQL Server Express 2019 LocalDB is an optional installation as the installer will automatically install it for you, but 
SQL Server 2019 Express must be installed beforehand to do this.

The database comes in a .bak format which is a backup of an SQL Database. The backup that comes with the application
must be restored using SQL Server Management Studio to create an instance of the databast that will persist in the 
SQL Server and the Device it is currently running on. 


To restore the database, Open SQL Server Management Studio and login either with Windows Authentication or SQL Authentication.
Once logged in, right-click the "Databases" folder and select "Restore Database...". In the "General" Page, select device and click
the "..." button that was previously greyed-out. Once the "Select backup devices" window appears, click "Add". Once the File Dialog opens,
navigate to the folder where the .bak file is kept and select "HRMSDB.bak". Once the directory of the file appears in the "Backup Media"
box, click OK. After a few seconds, the database is restored and ready for use.

Once the database is restored, open the installer to install the program.

DL Link for SQL Server Management Studio:
 https://learn.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver16

An installer for SQL Server Express 2019 is provided in the application files.
 