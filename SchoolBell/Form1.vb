Public Class Form1

    Private Sub ScheduleBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ScheduleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.Schedule' table. You can move, or remove it, as needed.
        Me.ScheduleTableAdapter.Fill(Me.ScheduleDataSet.Schedule)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim LItem As New ListViewItem()
        LItem.Text = "new item"
        LItem.SubItems(1).Text = "dsd"
        LItem.SubItems(2).Text = "dsd"
        LItem.SubItems(3).Text = "dsd"
        LItem.SubItems(4).Text = "dsd"
        LItem.SubItems(5).Text = "dsd"

        ListView1.Items.Add(LItem)

    End Sub
End Class
