# Shop Management System

A desktop shop-management application built with **VB.NET (.NET 10) Windows Forms** and a **MySQL** database.

**Modules:** Login, Sign Up, Dashboard, Products, Categories, Customers, Suppliers, Sales (with stock deduction), Inventory (with stock adjustments and an audit trail), Reports (with PDF export), Users (role-based access) and Settings.

## Requirements
* Windows 10/11
* [Visual Studio 2026](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload (needed for .NET 10)
* [MySQL Community Server 8+](https://dev.mysql.com/downloads/mysql/) installed and running

## Run it
1. Open `ShopManagementSystem.sln` in Visual Studio. NuGet restores `MySqlConnector` automatically.
2. Press **F5**.
3. On first run the app connects to MySQL (default `localhost:3306`, user `root`), creates the `shop_management_db` database and tables, and adds sample data.
   If the connection fails, a dialog lets you enter your MySQL host, user and password. These are saved to `%AppData%\ShopManagementSystem\dbconfig.json`, never in the project, so they are not pushed to GitHub.
4. Log in with **admin / Admin@123**, then change the password in **Settings**.

## Roles
| Role | Access |
|---|---|
| Administrator | Everything, including Users |
| Staff | Everything except Users |
| Cashier | Dashboard, Sales, Customers, Products and Inventory (view only), Settings |

New accounts created from **Sign Up** are Cashiers; an administrator can change the role in **Users**.

## Project layout
```
ShopManagementSystem.sln
UI-DESIGN-GUIDE.md      How to restyle the screens with the Toolbox
ShopManagementSystem/
  schema.sql            Database tables (embedded and run automatically)
  Core/                 Program (start-up), Db, password hashing + session, theme/helpers, bar chart, pop-up input dialog
  Forms/                frmLogin, frmSignUp, frmMain (sidebar + content area): each has a .Designer.vb
  Modules/              One screen per module (ucProducts, ucSales, ucReports, ...): each has a .Designer.vb
```
All screens are built in the Visual Studio designer (drag and drop). Build once (Ctrl+Shift+B), then double-click any file in `Forms` or `Modules` to open it in the designer. See `UI-DESIGN-GUIDE.md`.

## Publish a release others can download
**Automatic (recommended):** push a version tag and GitHub Actions builds and attaches a zip to a Release.
```
git tag v1.0.0
git push origin v1.0.0
```
**Manual:** `dotnet publish ShopManagementSystem/ShopManagementSystem.vbproj -c Release -r win-x64 --self-contained true -o publish`, zip the `publish` folder, then on GitHub choose **Releases > Draft a new release** and attach the zip.

Users unzip it and run `ShopManagementSystem.exe`. Each computer needs access to a MySQL server (its own, or a shared one entered in the connection dialog).
