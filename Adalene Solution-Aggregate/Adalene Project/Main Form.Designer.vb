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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.StoresDataSet = New Adalene_Project.StoresDataSet()
        Me.TblStoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStoresTableAdapter = New Adalene_Project.StoresDataSetTableAdapters.tblStoresTableAdapter()
        Me.TableAdapterManager = New Adalene_Project.StoresDataSetTableAdapters.TableAdapterManager()
        Me.TblStoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblStoresBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ddbSales = New System.Windows.Forms.ToolStripDropDownButton()
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCompany = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFranchisee = New System.Windows.Forms.ToolStripMenuItem()
        Me.TblStoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.StoresDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStoresBindingNavigator.SuspendLayout()
        CType(Me.TblStoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoresDataSet
        '
        Me.StoresDataSet.DataSetName = "StoresDataSet"
        Me.StoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStoresBindingSource
        '
        Me.TblStoresBindingSource.DataMember = "tblStores"
        Me.TblStoresBindingSource.DataSource = Me.StoresDataSet
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
        'TblStoresBindingNavigator
        '
        Me.TblStoresBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStoresBindingNavigator.BindingSource = Me.TblStoresBindingSource
        Me.TblStoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStoresBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStoresBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblStoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStoresBindingNavigatorSaveItem, Me.ddbSales})
        Me.TblStoresBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblStoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStoresBindingNavigator.Name = "TblStoresBindingNavigator"
        Me.TblStoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStoresBindingNavigator.Size = New System.Drawing.Size(1097, 32)
        Me.TblStoresBindingNavigator.TabIndex = 0
        Me.TblStoresBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 29)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 29)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 32)
        '
        'TblStoresBindingNavigatorSaveItem
        '
        Me.TblStoresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblStoresBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStoresBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStoresBindingNavigatorSaveItem.Name = "TblStoresBindingNavigatorSaveItem"
        Me.TblStoresBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 29)
        Me.TblStoresBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ddbSales
        '
        Me.ddbSales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ddbSales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAll, Me.mnuCompany, Me.mnuFranchisee})
        Me.ddbSales.Image = CType(resources.GetObject("ddbSales.Image"), System.Drawing.Image)
        Me.ddbSales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbSales.Name = "ddbSales"
        Me.ddbSales.Size = New System.Drawing.Size(112, 29)
        Me.ddbSales.Text = "&Total Sales"
        '
        'mnuAll
        '
        Me.mnuAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(237, 30)
        Me.mnuAll.Text = "&All Stores"
        '
        'mnuCompany
        '
        Me.mnuCompany.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuCompany.Name = "mnuCompany"
        Me.mnuCompany.Size = New System.Drawing.Size(237, 30)
        Me.mnuCompany.Text = "&Company-Owned"
        '
        'mnuFranchisee
        '
        Me.mnuFranchisee.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.mnuFranchisee.Name = "mnuFranchisee"
        Me.mnuFranchisee.Size = New System.Drawing.Size(237, 30)
        Me.mnuFranchisee.Text = "&Franchisee"
        '
        'TblStoresDataGridView
        '
        Me.TblStoresDataGridView.AutoGenerateColumns = False
        Me.TblStoresDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TblStoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblStoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblStoresDataGridView.DataSource = Me.TblStoresBindingSource
        Me.TblStoresDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblStoresDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.TblStoresDataGridView.Name = "TblStoresDataGridView"
        Me.TblStoresDataGridView.Size = New System.Drawing.Size(1097, 528)
        Me.TblStoresDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "StoreNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Store"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn2.HeaderText = "City"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "State"
        Me.DataGridViewTextBoxColumn3.HeaderText = "State"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sales"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sales"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ownership"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Ownership"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1097, 560)
        Me.Controls.Add(Me.TblStoresDataGridView)
        Me.Controls.Add(Me.TblStoresBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Adalene Fashions"
        CType(Me.StoresDataSet,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TblStoresBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.TblStoresBindingNavigator,System.ComponentModel.ISupportInitialize).EndInit
        Me.TblStoresBindingNavigator.ResumeLayout(false)
        Me.TblStoresBindingNavigator.PerformLayout
        CType(Me.TblStoresDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents StoresDataSet As StoresDataSet
    Friend WithEvents TblStoresBindingSource As BindingSource
    Friend WithEvents TblStoresTableAdapter As StoresDataSetTableAdapters.tblStoresTableAdapter
    Friend WithEvents TableAdapterManager As StoresDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStoresBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblStoresBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblStoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ddbSales As ToolStripDropDownButton
    Friend WithEvents mnuAll As ToolStripMenuItem
    Friend WithEvents mnuCompany As ToolStripMenuItem
    Friend WithEvents mnuFranchisee As ToolStripMenuItem
End Class
