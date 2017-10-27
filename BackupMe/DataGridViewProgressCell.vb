Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel

Class DataGridViewProgressCell
    Inherits DataGridViewImageCell
    ' Used to make custom cell consistent with a DataGridViewImageCell
    Shared emptyImage As Image
    ' Used to remember color of the progress bar
    Shared _ProgressBarColor As Color

    Public Property ProgressBarColor() As Color
        Get
            Return _ProgressBarColor
        End Get
        Set
            _ProgressBarColor = Value
        End Set
    End Property

    Shared Sub New()

        emptyImage = New Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format32bppArgb)
    End Sub
    Public Sub New()
        Me.ValueType = GetType(Integer)
    End Sub
    ' Method required to make the Progress Cell consistent with the default Image Cell.
    ' The default Image Cell assumes an Image as a value, although the value of the Progress Cell is an int.
    Protected Overrides Function GetFormattedValue(value As Object, rowIndex As Integer, ByRef cellStyle As DataGridViewCellStyle, valueTypeConverter As TypeConverter, formattedValueTypeConverter As TypeConverter, context As DataGridViewDataErrorContexts) As Object
        Return emptyImage
    End Function

    Protected Overrides Sub Paint(g As System.Drawing.Graphics, clipBounds As System.Drawing.Rectangle, cellBounds As System.Drawing.Rectangle, rowIndex As Integer, cellState As DataGridViewElementStates, value As Object,
        formattedValue As Object, errorText As String, cellStyle As DataGridViewCellStyle, advancedBorderStyle As DataGridViewAdvancedBorderStyle, paintParts As DataGridViewPaintParts)
        If Convert.ToInt16(value) = 0 OrElse value Is Nothing Then
            value = 0
        End If

        Dim progressVal As Integer = Convert.ToInt32(value)

        Dim percentage As Single = (CSng(progressVal) / 100.0F)
        ' Need to convert to float before division; otherwise C# returns int which is 0 for anything but 100%.
        Dim backColorBrush As Brush = New SolidBrush(cellStyle.BackColor)
        Dim foreColorBrush As Brush = New SolidBrush(cellStyle.ForeColor)

        ' Draws the cell grid
        MyBase.Paint(g, clipBounds, cellBounds, rowIndex, cellState, value,
            formattedValue, errorText, cellStyle, advancedBorderStyle, (paintParts And Not DataGridViewPaintParts.ContentForeground))

        Dim posX As Single = cellBounds.X
        Dim posY As Single = cellBounds.Y

        Dim textWidth As Single = TextRenderer.MeasureText(progressVal.ToString() + "%", cellStyle.Font).Width
        Dim textHeight As Single = TextRenderer.MeasureText(progressVal.ToString() + "%", cellStyle.Font).Height

        'evaluating text position according to alignment
        Select Case cellStyle.Alignment
            Case DataGridViewContentAlignment.BottomCenter
                posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2
                posY = cellBounds.Y + cellBounds.Height - textHeight
                Exit Select
            Case DataGridViewContentAlignment.BottomLeft
                posX = cellBounds.X
                posY = cellBounds.Y + cellBounds.Height - textHeight
                Exit Select
            Case DataGridViewContentAlignment.BottomRight
                posX = cellBounds.X + cellBounds.Width - textWidth
                posY = cellBounds.Y + cellBounds.Height - textHeight
                Exit Select
            Case DataGridViewContentAlignment.MiddleCenter
                posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2
                posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2
                Exit Select
            Case DataGridViewContentAlignment.MiddleLeft
                posX = cellBounds.X
                posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2
                Exit Select
            Case DataGridViewContentAlignment.MiddleRight
                posX = cellBounds.X + cellBounds.Width - textWidth
                posY = cellBounds.Y + (cellBounds.Height / 2) - textHeight / 2
                Exit Select
            Case DataGridViewContentAlignment.TopCenter
                posX = cellBounds.X + (cellBounds.Width / 2) - textWidth / 2
                posY = cellBounds.Y
                Exit Select
            Case DataGridViewContentAlignment.TopLeft
                posX = cellBounds.X
                posY = cellBounds.Y
                Exit Select

            Case DataGridViewContentAlignment.TopRight
                posX = cellBounds.X + cellBounds.Width - textWidth
                posY = cellBounds.Y
                Exit Select

        End Select

        If percentage >= 0.0 Then

            ' Draw the progress 
            g.FillRectangle(New SolidBrush(_ProgressBarColor), cellBounds.X + 2, cellBounds.Y + 2, Convert.ToSingle((percentage * cellBounds.Width * 0.8)), Convert.ToSingle(cellBounds.Height / 1 - 5))
            'Draw text
            g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, posX, posY)
        Else
            'if percentage is negative, we don't want to draw progress bar
            'wa want only text
            If Me.DataGridView.CurrentRow.Index = rowIndex Then
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, New SolidBrush(cellStyle.SelectionForeColor), posX, posX)
            Else
                g.DrawString(progressVal.ToString() + "%", cellStyle.Font, foreColorBrush, posX, posY)
            End If
        End If
    End Sub

    Public Overrides Function Clone() As Object
        Dim dataGridViewCell As DataGridViewProgressCell = TryCast(MyBase.Clone(), DataGridViewProgressCell)
        If dataGridViewCell IsNot Nothing Then
            dataGridViewCell.ProgressBarColor = Me.ProgressBarColor
        End If
        Return dataGridViewCell
    End Function

    Friend Sub SetProgressBarColor(rowIndex As Integer, value As Color)
        Me.ProgressBarColor = value
    End Sub

End Class


