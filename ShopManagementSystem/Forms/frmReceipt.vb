Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class frmReceipt

    Private _saleId As Long

    ''' <summary>Loads the receipt for a saved sale into the preview.</summary>
    Public Sub LoadSale(saleId As Long)
        _saleId = saleId
        Text = "Receipt - Sale #" & saleId
        ppcReceipt.Document = Receipt.BuildDocument(saleId)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Ui.Run(AddressOf PrintReceipt)
    End Sub

    Private Sub PrintReceipt()
        Using pd As New PrintDialog()
            pd.Document = Receipt.BuildDocument(_saleId)
            If pd.ShowDialog(Me) = DialogResult.OK Then pd.Document.Print()
        End Using
    End Sub

    Private Sub btnSavePdf_Click(sender As Object, e As EventArgs) Handles btnSavePdf.Click
        Ui.Run(AddressOf SavePdf)
    End Sub

    Private Sub SavePdf()
        Using sfd As New SaveFileDialog()
            sfd.Filter = "PDF file (*.pdf)|*.pdf"
            sfd.FileName = "Receipt_" & _saleId & ".pdf"
            If sfd.ShowDialog(Me) <> DialogResult.OK Then Return
            Dim doc = Receipt.BuildDocument(_saleId)
            doc.PrinterSettings.PrinterName = "Microsoft Print to PDF"
            If Not doc.PrinterSettings.IsValid Then
                Ui.Warn("The 'Microsoft Print to PDF' printer was not found on this computer." & vbCrLf & "Use the Print button and choose any PDF printer instead.")
                Return
            End If
            doc.PrinterSettings.PrintToFile = True
            doc.PrinterSettings.PrintFileName = sfd.FileName
            doc.Print()
            Ui.Info("Receipt saved to:" & vbCrLf & sfd.FileName)
        End Using
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
