namespace ADOSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label dATELabel;
            System.Windows.Forms.Label aYTHORLabel;
            System.Windows.Forms.Label mEMOLabel;
            this.infosys202017DataSet = new ADOSample.infosys202017DataSet();
            this.memoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoTableTableAdapter = new ADOSample.infosys202017DataSetTableAdapters.memoTableTableAdapter();
            this.tableAdapterManager = new ADOSample.infosys202017DataSetTableAdapters.TableAdapterManager();
            this.memoTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.memoTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.memoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.dATEDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.aYTHORTextBox = new System.Windows.Forms.TextBox();
            this.mEMOTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            dATELabel = new System.Windows.Forms.Label();
            aYTHORLabel = new System.Windows.Forms.Label();
            mEMOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingNavigator)).BeginInit();
            this.memoTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // infosys202017DataSet
            // 
            this.infosys202017DataSet.DataSetName = "infosys202017DataSet";
            this.infosys202017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoTableBindingSource
            // 
            this.memoTableBindingSource.DataMember = "memoTable";
            this.memoTableBindingSource.DataSource = this.infosys202017DataSet;
            // 
            // memoTableTableAdapter
            // 
            this.memoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.memoTableTableAdapter = this.memoTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = ADOSample.infosys202017DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memoTableBindingNavigator
            // 
            this.memoTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.memoTableBindingNavigator.BindingSource = this.memoTableBindingSource;
            this.memoTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.memoTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.memoTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.memoTableBindingNavigatorSaveItem});
            this.memoTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.memoTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.memoTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.memoTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.memoTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.memoTableBindingNavigator.Name = "memoTableBindingNavigator";
            this.memoTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.memoTableBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.memoTableBindingNavigator.TabIndex = 0;
            this.memoTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "新規追加";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "項目の総数";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "削除";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "最初に移動";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "前に戻る";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "位置";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "現在の場所";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "次に移動";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "最後に移動";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // memoTableBindingNavigatorSaveItem
            // 
            this.memoTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.memoTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("memoTableBindingNavigatorSaveItem.Image")));
            this.memoTableBindingNavigatorSaveItem.Name = "memoTableBindingNavigatorSaveItem";
            this.memoTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.memoTableBindingNavigatorSaveItem.Text = "データの保存";
            this.memoTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.memoTableBindingNavigatorSaveItem_Click);
            // 
            // memoTableDataGridView
            // 
            this.memoTableDataGridView.AutoGenerateColumns = false;
            this.memoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.memoTableDataGridView.DataSource = this.memoTableBindingSource;
            this.memoTableDataGridView.Location = new System.Drawing.Point(12, 45);
            this.memoTableDataGridView.Name = "memoTableDataGridView";
            this.memoTableDataGridView.RowTemplate.Height = 21;
            this.memoTableDataGridView.Size = new System.Drawing.Size(644, 220);
            this.memoTableDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DATE";
            this.dataGridViewTextBoxColumn2.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "AYTHOR";
            this.dataGridViewTextBoxColumn3.HeaderText = "AYTHOR";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MEMO";
            this.dataGridViewTextBoxColumn4.HeaderText = "MEMO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(25, 296);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(18, 12);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(84, 293);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(200, 19);
            this.iDTextBox.TabIndex = 3;
            // 
            // dATELabel
            // 
            dATELabel.AutoSize = true;
            dATELabel.Location = new System.Drawing.Point(25, 322);
            dATELabel.Name = "dATELabel";
            dATELabel.Size = new System.Drawing.Size(37, 12);
            dATELabel.TabIndex = 4;
            dATELabel.Text = "DATE:";
            // 
            // dATEDateTimePicker
            // 
            this.dATEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memoTableBindingSource, "DATE", true));
            this.dATEDateTimePicker.Location = new System.Drawing.Point(84, 318);
            this.dATEDateTimePicker.Name = "dATEDateTimePicker";
            this.dATEDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.dATEDateTimePicker.TabIndex = 5;
            // 
            // aYTHORLabel
            // 
            aYTHORLabel.AutoSize = true;
            aYTHORLabel.Location = new System.Drawing.Point(25, 346);
            aYTHORLabel.Name = "aYTHORLabel";
            aYTHORLabel.Size = new System.Drawing.Size(53, 12);
            aYTHORLabel.TabIndex = 6;
            aYTHORLabel.Text = "AYTHOR:";
            // 
            // aYTHORTextBox
            // 
            this.aYTHORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "AYTHOR", true));
            this.aYTHORTextBox.Location = new System.Drawing.Point(84, 343);
            this.aYTHORTextBox.Name = "aYTHORTextBox";
            this.aYTHORTextBox.Size = new System.Drawing.Size(200, 19);
            this.aYTHORTextBox.TabIndex = 7;
            // 
            // mEMOLabel
            // 
            mEMOLabel.AutoSize = true;
            mEMOLabel.Location = new System.Drawing.Point(25, 371);
            mEMOLabel.Name = "mEMOLabel";
            mEMOLabel.Size = new System.Drawing.Size(40, 12);
            mEMOLabel.TabIndex = 8;
            mEMOLabel.Text = "MEMO:";
            // 
            // mEMOTextBox
            // 
            this.mEMOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "MEMO", true));
            this.mEMOTextBox.Location = new System.Drawing.Point(84, 368);
            this.mEMOTextBox.Name = "mEMOTextBox";
            this.mEMOTextBox.Size = new System.Drawing.Size(200, 19);
            this.mEMOTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(519, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 85);
            this.button1.TabIndex = 10;
            this.button1.Text = "接続";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memoTableBindingSource, "AYTHOR", true));
            this.textBox1.Location = new System.Drawing.Point(301, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 19);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(dATELabel);
            this.Controls.Add(this.dATEDateTimePicker);
            this.Controls.Add(aYTHORLabel);
            this.Controls.Add(this.aYTHORTextBox);
            this.Controls.Add(mEMOLabel);
            this.Controls.Add(this.mEMOTextBox);
            this.Controls.Add(this.memoTableDataGridView);
            this.Controls.Add(this.memoTableBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.infosys202017DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableBindingNavigator)).EndInit();
            this.memoTableBindingNavigator.ResumeLayout(false);
            this.memoTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private infosys202017DataSet infosys202017DataSet;
        private System.Windows.Forms.BindingSource memoTableBindingSource;
        private infosys202017DataSetTableAdapters.memoTableTableAdapter memoTableTableAdapter;
        private infosys202017DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator memoTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton memoTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView memoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.DateTimePicker dATEDateTimePicker;
        private System.Windows.Forms.TextBox aYTHORTextBox;
        private System.Windows.Forms.TextBox mEMOTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

