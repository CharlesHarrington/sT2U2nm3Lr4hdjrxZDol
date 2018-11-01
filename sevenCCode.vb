'Form1 Code
btnDone.Visible = False
lblAnswer.Visible = False
lblTotalCost.Visible = False

'btnDone Code
'-----------------------------------------------------------------------------------

Const decGUMCOST As Decimal = 0.25
Const decCANDYCOST As Decimal = 1
Const decCOOKIECOST As Decimal = 0.5
Const decCHIPSCOST As Decimal = 0.35
Const decSODACOST As Decimal = 1.25

Dim strItems As String
Dim decTotal As Decimal

decTotalCost = 0
strItems = ""

If chkGum.Checked = True Then
  strItems = strItems & vbNewLine & ""
  decTotal = decTotal + decGUMCOST
End If

If chkCandy.Checked = True Then
  strItems = strItems & vbNewLine & "Candy"
  decTotal = decTotal + decCANDYCOST
End If

If chkCookie.Checked = True Then
  strItems = strItems & vbNewLine & "Cookie"
  decTotal = decTotal + decCOOKIECOST
End If

If chkChips.Checked = True Then
  strItems = strItems & vbNewLine & "Chips"
  decTotal = decTotal + decCHIPSCOST
End If

If chkSoda.Checked = True Then
  strItems = strItems & vbNewLine & "Soda"
  decTotal = decTotal + decSODACOST
End If

lblAnswer.Text = strItems
lblTotalCost.Text = "Total Cost: " & Format(decTotalCost, "$##0.00")
'-----------------------------------------------------------------------------------
'All Checkbox button code
btnDone.Visible = True
lblAnswer.Visible = False
lblTotalCost.Visible = False
