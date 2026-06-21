# Blood Bank Management System

WinForms desktop app for managing blood donors, inventory, and requests.


## Tech Stack
- C# / .NET Framework 4.7.2, WinForms
- ADO.NET (SqlConnection, SqlCommand, SqlParameter)
- SQL Server LocalDB
- LiveCharts2 for dashboard charts

## Architecture
- **App.Core** - Models, Interfaces, Services (business logic + data access)
- **App.WindowsApp** - UI (MainForm, UserControls, Forms)

## Database
Three tables in `BloodBankDB`: **Donors**, **BloodUnits**, **BloodRequests**
(NVARCHAR primary keys, no FK constraints)

## Features
- Full CRUD on all 3 entities via ADO.NET (parameterized queries)
- Mode-driven forms (Add / Edit / View) with validation
- DataGridView + BindingSource, confirm-before-delete
- Search + filter, async data loading, status bar
- Dashboard with Pie Chart (inventory by blood group) and Column Chart (requests by status)

## Setup
1. Open `BloodBankSystem.sln` in Visual Studio
2. Create `BloodBankDB` in SQL Server Object Explorer and run the schema script
3. Confirm connection string in `App.WindowsApp/App.config`
4. Set `App.WindowsApp` as Startup Project
5. Restore NuGet packages (incl. `LiveChartsCore.SkiaSharpView.WinForms`)
6. Press F5

## Note
If LiveCharts throws `DllNotFoundException: libHarfBuzzSharp`, reinstall the
NuGet package (try version 2.0.0) and set Platform target to x64.
