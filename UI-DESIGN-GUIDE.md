# Restyling the screens with the Visual Studio Toolbox

Every screen has a `.Designer.vb` file, so you edit it by dragging and dropping, exactly like any Windows Forms project.

## Open a screen in the designer
1. Press **Ctrl+Shift+B** once to build. The charts are a custom control (`BarChart`) and the designer needs the build to show them.
2. In **Solution Explorer**, expand `Forms` or `Modules` and **double-click** the screen (for example `ucProducts.vb`). It opens in the designer. Click the arrow beside it to see its `.Designer.vb` file; do not edit that by hand.

| Screen | File | What it is |
|---|---|---|
| Login / Sign Up | `Forms\frmLogin`, `Forms\frmSignUp` | Two stand-alone forms |
| Main window | `Forms\frmMain` | Green sidebar (`flpNav` with the 11 buttons) + empty `pnlContent` |
| Dashboard, Products, Categories, Customers, Suppliers, Sales, Inventory, Reports, Users, Settings | `Modules\uc...` | UserControls shown inside `pnlContent` |

## Everyday edits
* **Move or resize:** drag the control, or set `Location` / `Size` in the **Properties** window.
* **Colours and fonts:** select the control, then change `BackColor`, `ForeColor`, `Font`. Theme colours used: dark green `0, 77, 38`, green `0, 110, 50`, light green `226, 240, 217`, gold `255, 204, 0`, red `214, 40, 40`, blue `30, 100, 220`.
* **Change text:** edit the `Text` property (for example the page title labels `lblProductsTitle`, `lblCustomersTitle`).
* **Add a control:** drag it from the **Toolbox** onto the screen. Double-click a button to create its `Click` handler in the code file.
* **Replace the logo:** on `frmLogin` and `frmSignUp`, delete `lblLogo` from `pnlBrand`, drag in a **PictureBox**, name it `picLogo`, and set `Image` and `SizeMode = Zoom`.
* **Reorder or hide sidebar buttons:** drag them in `flpNav` on `frmMain`. Buttons must keep the name `btn` + screen name (`btnProducts`), because the code finds the screen from the name.

## Rules that keep the code working
* **Renaming:** use the `(Name)` property in the Properties window so VS updates the code that uses the control. Keep the prefixes (`btn`, `txt`, `lbl`, `dgv`, `dtp`, `cmb`, `nud`, `pnl`, `cht`).
* **Layout:** panels use `Dock` (Fill, Top, Bottom, Right) so they resize with the window. If you add a docked panel and it covers another, use **Bring to Front / Send to Back** on the panel.
* **Grids (`dgv...`):** columns are filled from the database at run time. The look (header colour, row height, selection colour) is applied by `Ui.StyleGrid(...)` in each screen's `Sub New`. To style a grid yourself in the designer, set its properties and delete that one line.
* **Sales grid:** its six columns are real designer columns (`colProductID`, `colStock`, `colProduct`, `colPrice`, `colQty`, `colTotal`). Edit them with the grid's **Edit Columns** smart-tag. Keep the order, because `Rows.Add` fills them in that order.
* **Dashboard cards:** each card is a panel (`pnlTotalSales`, `pnlProducts`, ...) holding a caption label and a value label (`lbl...Value`). Change colours freely; the code only sets the value labels' text.

## What is still created by code
The small pop-up windows used for Add / Edit (a product, customer, user ...), Adjust Stock and the MySQL connection settings are built by one reusable dialog, `Core\FieldDialog.vb`, so they all validate the same way. Restyle them in that file, or ask me to turn any of them into its own designer form.
