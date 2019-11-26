namespace Proyecto_Clinica
{
    partial class FormCitas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label pacienteLabel1;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label fechaLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCitas));
            System.Windows.Forms.Label descripcionLabel;
            this.listaCitaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.listaCitaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.listaCitaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.pacienteComboBox = new System.Windows.Forms.ComboBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.listaDoctoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctoresBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.listaCitaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionComboBox = new System.Windows.Forms.ComboBox();
            this.listaHorasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            pacienteLabel1 = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            fechaLabel1 = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingNavigator)).BeginInit();
            this.listaCitaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHorasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(28, 62);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 49;
            idLabel.Text = "Id:";
            // 
            // pacienteLabel1
            // 
            pacienteLabel1.AutoSize = true;
            pacienteLabel1.Location = new System.Drawing.Point(376, 62);
            pacienteLabel1.Name = "pacienteLabel1";
            pacienteLabel1.Size = new System.Drawing.Size(52, 13);
            pacienteLabel1.TabIndex = 54;
            pacienteLabel1.Text = "Paciente:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(386, 92);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(42, 13);
            doctorLabel.TabIndex = 55;
            doctorLabel.Text = "Doctor:";
            // 
            // fechaLabel1
            // 
            fechaLabel1.AutoSize = true;
            fechaLabel1.Location = new System.Drawing.Point(28, 89);
            fechaLabel1.Name = "fechaLabel1";
            fechaLabel1.Size = new System.Drawing.Size(40, 13);
            fechaLabel1.TabIndex = 56;
            fechaLabel1.Text = "Fecha:";
            // 
            // listaCitaBindingNavigator
            // 
            this.listaCitaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.listaCitaBindingNavigator.BindingSource = this.listaCitaBindingSource;
            this.listaCitaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.listaCitaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.listaCitaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.listaCitaBindingNavigatorSaveItem,
            this.toolStripButtonCancelar});
            this.listaCitaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listaCitaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.listaCitaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.listaCitaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listaCitaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listaCitaBindingNavigator.Name = "listaCitaBindingNavigator";
            this.listaCitaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.listaCitaBindingNavigator.Size = new System.Drawing.Size(1129, 25);
            this.listaCitaBindingNavigator.TabIndex = 43;
            this.listaCitaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // listaCitaBindingSource
            // 
            this.listaCitaBindingSource.DataSource = typeof(BL.Cita);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
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
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // listaCitaBindingNavigatorSaveItem
            // 
            this.listaCitaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.listaCitaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("listaCitaBindingNavigatorSaveItem.Image")));
            this.listaCitaBindingNavigatorSaveItem.Name = "listaCitaBindingNavigatorSaveItem";
            this.listaCitaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.listaCitaBindingNavigatorSaveItem.Text = "Guardar datos";
            this.listaCitaBindingNavigatorSaveItem.Click += new System.EventHandler(this.listaCitaBindingNavigatorSaveItem_Click_2);
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Visible = false;
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click_1);
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataSource = typeof(BL.Paciente);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(86, 59);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 50;
            // 
            // pacienteComboBox
            // 
            this.pacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitaBindingSource, "Paciente", true));
            this.pacienteComboBox.DataSource = this.pacienteBindingSource;
            this.pacienteComboBox.DisplayMember = "Nombre";
            this.pacienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pacienteComboBox.FormattingEnabled = true;
            this.pacienteComboBox.Location = new System.Drawing.Point(434, 59);
            this.pacienteComboBox.Name = "pacienteComboBox";
            this.pacienteComboBox.Size = new System.Drawing.Size(178, 21);
            this.pacienteComboBox.TabIndex = 55;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaCitaBindingSource, "Doctor", true));
            this.doctorComboBox.DataSource = this.listaDoctoresBindingSource;
            this.doctorComboBox.DisplayMember = "Nombre";
            this.doctorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(434, 89);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(178, 21);
            this.doctorComboBox.TabIndex = 56;
            // 
            // listaDoctoresBindingSource
            // 
            this.listaDoctoresBindingSource.DataMember = "ListaDoctores";
            this.listaDoctoresBindingSource.DataSource = this.doctoresBLBindingSource;
            // 
            // doctoresBLBindingSource
            // 
            this.doctoresBLBindingSource.DataSource = typeof(BL.DoctoresBL);
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaCitaBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(84, 89);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 57;
            // 
            // listaCitaDataGridView
            // 
            this.listaCitaDataGridView.AutoGenerateColumns = false;
            this.listaCitaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaCitaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.listaCitaDataGridView.DataSource = this.listaCitaBindingSource;
            this.listaCitaDataGridView.Location = new System.Drawing.Point(42, 172);
            this.listaCitaDataGridView.Name = "listaCitaDataGridView";
            this.listaCitaDataGridView.Size = new System.Drawing.Size(545, 220);
            this.listaCitaDataGridView.TabIndex = 57;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Paciente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Paciente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Doctor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(28, 118);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(33, 13);
            descripcionLabel.TabIndex = 57;
            descripcionLabel.Text = "Hora:";
            // 
            // descripcionComboBox
            // 
            this.descripcionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.listaHorasBindingSource, "Descripcion", true));
            this.descripcionComboBox.DataSource = this.listaHorasBindingSource;
            this.descripcionComboBox.DisplayMember = "Descripcion";
            this.descripcionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.descripcionComboBox.FormattingEnabled = true;
            this.descripcionComboBox.Location = new System.Drawing.Point(86, 118);
            this.descripcionComboBox.Name = "descripcionComboBox";
            this.descripcionComboBox.Size = new System.Drawing.Size(200, 21);
            this.descripcionComboBox.TabIndex = 58;
            this.descripcionComboBox.ValueMember = "Id";
            // 
            // listaHorasBindingSource
            // 
            this.listaHorasBindingSource.DataSource = typeof(BL.Hora);
            // 
            // FormCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1129, 478);
            this.Controls.Add(this.descripcionComboBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.listaCitaDataGridView);
            this.Controls.Add(fechaLabel1);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(doctorLabel);
            this.Controls.Add(this.doctorComboBox);
            this.Controls.Add(pacienteLabel1);
            this.Controls.Add(this.pacienteComboBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.listaCitaBindingNavigator);
            this.Name = "FormCitas";
            this.Text = "Citas";
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingNavigator)).EndInit();
            this.listaCitaBindingNavigator.ResumeLayout(false);
            this.listaCitaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaDoctoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaCitaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaHorasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource listaCitaBindingSource;
        private System.Windows.Forms.BindingNavigator listaCitaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton listaCitaBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox pacienteComboBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.BindingSource doctoresBLBindingSource;
        private System.Windows.Forms.BindingSource listaDoctoresBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.DataGridView listaCitaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox descripcionComboBox;
        private System.Windows.Forms.BindingSource listaHorasBindingSource;
    }
}