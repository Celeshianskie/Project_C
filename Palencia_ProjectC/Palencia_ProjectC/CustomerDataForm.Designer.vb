<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerDataForm
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim NumPaxLabel As System.Windows.Forms.Label
        Dim DepDateLabel As System.Windows.Forms.Label
        Dim ModPaymentLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomerDataForm))
        Me.ProjectCDataSet = New Palencia_ProjectC.ProjectCDataSet()
        Me.CustomerDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerDataTableAdapter = New Palencia_ProjectC.ProjectCDataSetTableAdapters.CustomerDataTableAdapter()
        Me.TableAdapterManager = New Palencia_ProjectC.ProjectCDataSetTableAdapters.TableAdapterManager()
        Me.CustomerDataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomerDataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.NumPaxTextBox = New System.Windows.Forms.TextBox()
        Me.DepDateTextBox = New System.Windows.Forms.TextBox()
        Me.ModPaymentTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPaxDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModPaymentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        NumPaxLabel = New System.Windows.Forms.Label()
        DepDateLabel = New System.Windows.Forms.Label()
        ModPaymentLabel = New System.Windows.Forms.Label()
        TotalCostLabel = New System.Windows.Forms.Label()
        CType(Me.ProjectCDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerDataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerDataBindingNavigator.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(88, 75)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(71, 112)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(61, 150)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "Address:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Location = New System.Drawing.Point(43, 191)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(66, 13)
        PhoneNumLabel.TabIndex = 7
        PhoneNumLabel.Text = "Phone Num:"
        '
        'NumPaxLabel
        '
        NumPaxLabel.AutoSize = True
        NumPaxLabel.Location = New System.Drawing.Point(56, 234)
        NumPaxLabel.Name = "NumPaxLabel"
        NumPaxLabel.Size = New System.Drawing.Size(53, 13)
        NumPaxLabel.TabIndex = 9
        NumPaxLabel.Text = "Num Pax:"
        '
        'DepDateLabel
        '
        DepDateLabel.AutoSize = True
        DepDateLabel.Location = New System.Drawing.Point(53, 272)
        DepDateLabel.Name = "DepDateLabel"
        DepDateLabel.Size = New System.Drawing.Size(56, 13)
        DepDateLabel.TabIndex = 11
        DepDateLabel.Text = "Dep Date:"
        '
        'ModPaymentLabel
        '
        ModPaymentLabel.AutoSize = True
        ModPaymentLabel.Location = New System.Drawing.Point(34, 312)
        ModPaymentLabel.Name = "ModPaymentLabel"
        ModPaymentLabel.Size = New System.Drawing.Size(75, 13)
        ModPaymentLabel.TabIndex = 13
        ModPaymentLabel.Text = "Mod Payment:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Location = New System.Drawing.Point(51, 358)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(58, 13)
        TotalCostLabel.TabIndex = 15
        TotalCostLabel.Text = "Total Cost:"
        '
        'ProjectCDataSet
        '
        Me.ProjectCDataSet.DataSetName = "ProjectCDataSet"
        Me.ProjectCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerDataBindingSource
        '
        Me.CustomerDataBindingSource.DataMember = "CustomerData"
        Me.CustomerDataBindingSource.DataSource = Me.ProjectCDataSet
        '
        'CustomerDataTableAdapter
        '
        Me.CustomerDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AdminAccountTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerAccountTableAdapter = Nothing
        Me.TableAdapterManager.CustomerDataTableAdapter = Me.CustomerDataTableAdapter
        Me.TableAdapterManager.UpdateOrder = Palencia_ProjectC.ProjectCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerDataBindingNavigator
        '
        Me.CustomerDataBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomerDataBindingNavigator.BindingSource = Me.CustomerDataBindingSource
        Me.CustomerDataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomerDataBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomerDataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomerDataBindingNavigatorSaveItem})
        Me.CustomerDataBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.CustomerDataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomerDataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomerDataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomerDataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomerDataBindingNavigator.Name = "CustomerDataBindingNavigator"
        Me.CustomerDataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomerDataBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CustomerDataBindingNavigator.TabIndex = 0
        Me.CustomerDataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CustomerDataBindingNavigatorSaveItem
        '
        Me.CustomerDataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomerDataBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomerDataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomerDataBindingNavigatorSaveItem.Name = "CustomerDataBindingNavigatorSaveItem"
        Me.CustomerDataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CustomerDataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(115, 72)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(115, 109)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(115, 147)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AddressTextBox.TabIndex = 6
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(115, 188)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumTextBox.TabIndex = 8
        '
        'NumPaxTextBox
        '
        Me.NumPaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "NumPax", True))
        Me.NumPaxTextBox.Location = New System.Drawing.Point(115, 231)
        Me.NumPaxTextBox.Name = "NumPaxTextBox"
        Me.NumPaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumPaxTextBox.TabIndex = 10
        '
        'DepDateTextBox
        '
        Me.DepDateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "DepDate", True))
        Me.DepDateTextBox.Location = New System.Drawing.Point(115, 269)
        Me.DepDateTextBox.Name = "DepDateTextBox"
        Me.DepDateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DepDateTextBox.TabIndex = 12
        '
        'ModPaymentTextBox
        '
        Me.ModPaymentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "ModPayment", True))
        Me.ModPaymentTextBox.Location = New System.Drawing.Point(115, 309)
        Me.ModPaymentTextBox.Name = "ModPaymentTextBox"
        Me.ModPaymentTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ModPaymentTextBox.TabIndex = 14
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerDataBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Location = New System.Drawing.Point(115, 355)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalCostTextBox.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PhoneNumDataGridViewTextBoxColumn, Me.NumPaxDataGridViewTextBoxColumn, Me.DepDateDataGridViewTextBoxColumn, Me.ModPaymentDataGridViewTextBoxColumn, Me.TotalCostDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerDataBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(274, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 331)
        Me.DataGridView1.TabIndex = 17
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PhoneNumDataGridViewTextBoxColumn
        '
        Me.PhoneNumDataGridViewTextBoxColumn.DataPropertyName = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.HeaderText = "PhoneNum"
        Me.PhoneNumDataGridViewTextBoxColumn.Name = "PhoneNumDataGridViewTextBoxColumn"
        '
        'NumPaxDataGridViewTextBoxColumn
        '
        Me.NumPaxDataGridViewTextBoxColumn.DataPropertyName = "NumPax"
        Me.NumPaxDataGridViewTextBoxColumn.HeaderText = "NumPax"
        Me.NumPaxDataGridViewTextBoxColumn.Name = "NumPaxDataGridViewTextBoxColumn"
        '
        'DepDateDataGridViewTextBoxColumn
        '
        Me.DepDateDataGridViewTextBoxColumn.DataPropertyName = "DepDate"
        Me.DepDateDataGridViewTextBoxColumn.HeaderText = "DepDate"
        Me.DepDateDataGridViewTextBoxColumn.Name = "DepDateDataGridViewTextBoxColumn"
        '
        'ModPaymentDataGridViewTextBoxColumn
        '
        Me.ModPaymentDataGridViewTextBoxColumn.DataPropertyName = "ModPayment"
        Me.ModPaymentDataGridViewTextBoxColumn.HeaderText = "ModPayment"
        Me.ModPaymentDataGridViewTextBoxColumn.Name = "ModPaymentDataGridViewTextBoxColumn"
        '
        'TotalCostDataGridViewTextBoxColumn
        '
        Me.TotalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost"
        Me.TotalCostDataGridViewTextBoxColumn.Name = "TotalCostDataGridViewTextBoxColumn"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToMenuToolStripMenuItem
        '
        Me.BackToMenuToolStripMenuItem.Name = "BackToMenuToolStripMenuItem"
        Me.BackToMenuToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.BackToMenuToolStripMenuItem.Text = "Back to Menu"
        '
        'CustomerDataForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(TotalCostLabel)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(ModPaymentLabel)
        Me.Controls.Add(Me.ModPaymentTextBox)
        Me.Controls.Add(DepDateLabel)
        Me.Controls.Add(Me.DepDateTextBox)
        Me.Controls.Add(NumPaxLabel)
        Me.Controls.Add(Me.NumPaxTextBox)
        Me.Controls.Add(PhoneNumLabel)
        Me.Controls.Add(Me.PhoneNumTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.CustomerDataBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CustomerDataForm"
        Me.Text = "CustomerDataForm"
        CType(Me.ProjectCDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerDataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerDataBindingNavigator.ResumeLayout(False)
        Me.CustomerDataBindingNavigator.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProjectCDataSet As ProjectCDataSet
    Friend WithEvents CustomerDataBindingSource As BindingSource
    Friend WithEvents CustomerDataTableAdapter As ProjectCDataSetTableAdapters.CustomerDataTableAdapter
    Friend WithEvents TableAdapterManager As ProjectCDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomerDataBindingNavigator As BindingNavigator
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
    Friend WithEvents CustomerDataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents NumPaxTextBox As TextBox
    Friend WithEvents DepDateTextBox As TextBox
    Friend WithEvents ModPaymentTextBox As TextBox
    Friend WithEvents TotalCostTextBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPaxDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DepDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ModPaymentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToMenuToolStripMenuItem As ToolStripMenuItem
End Class
