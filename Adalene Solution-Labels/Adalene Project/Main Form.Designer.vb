<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblStore = New System.Windows.Forms.Label()
        Me.TblStoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoresDataSet = New Adalene_Project.StoresDataSet()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lbLOwner = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TblStoresTableAdapter = New Adalene_Project.StoresDataSetTableAdapters.tblStoresTableAdapter()
        Me.TableAdapterManager = New Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Adalene_Project.My.Resources.Resources.Fashion
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(138, 166)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 31)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Store:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(276, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 31)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sales:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ownership:"
        '
        'lblStore
        '
        Me.lblStore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblStore.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "StoreNum", True))
        Me.lblStore.Location = New System.Drawing.Point(212, 53)
        Me.lblStore.Name = "lblStore"
        Me.lblStore.Size = New System.Drawing.Size(43, 33)
        Me.lblStore.TabIndex = 6
        Me.lblStore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TblStoresBindingSource
        '
        Me.TblStoresBindingSource.DataMember = "tblStores"
        Me.TblStoresBindingSource.DataSource = Me.StoresDataSet
        '
        'StoresDataSet
        '
        Me.StoresDataSet.DataSetName = "StoresDataSet"
        Me.StoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblSales
        '
        Me.lblSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "Sales", True))
        Me.lblSales.Location = New System.Drawing.Point(280, 53)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(82, 33)
        Me.lblSales.TabIndex = 7
        Me.lblSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbLOwner
        '
        Me.lbLOwner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbLOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStoresBindingSource, "Ownership", True))
        Me.lbLOwner.Location = New System.Drawing.Point(386, 53)
        Me.lbLOwner.Name = "lbLOwner"
        Me.lbLOwner.Size = New System.Drawing.Size(39, 33)
        Me.lbLOwner.TabIndex = 8
        Me.lbLOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(161, 144)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(124, 33)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "&Previous Record"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(291, 145)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(124, 33)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "&Next Record"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(421, 144)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 33)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'TblStoresTableAdapter
        '
        Me.TblStoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblStoresTableAdapter = Me.TblStoresTableAdapter
        Me.TableAdapterManager.UpdateOrder = Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 210)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.lbLOwner)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.lblStore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adalene Fashions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoresDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStore As Label
    Friend WithEvents lblSales As Label
    Friend WithEvents lbLOwner As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StoresDataSet As StoresDataSet
    Friend WithEvents TblStoresBindingSource As BindingSource
    Friend WithEvents TblStoresTableAdapter As StoresDataSetTableAdapters.tblStoresTableAdapter
    Friend WithEvents TableAdapterManager As StoresDataSetTableAdapters.TableAdapterManager
End Class
