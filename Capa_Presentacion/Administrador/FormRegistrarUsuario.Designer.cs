namespace ArimaERP.Administrador
{
    partial class FormRegistrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarUsuario));
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label iD_rolLabel;
          
            this.uSUARIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
           
            this.uSUARIOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.uSUARIOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.uSUARIOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.estadoCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.iD_rolTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dniLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            iD_rolLabel = new System.Windows.Forms.Label();
        
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingNavigator)).BeginInit();
            this.uSUARIOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tallerProgramacionIIDataSet
            // 
            
            // uSUARIOSBindingSource
            // is.tallerProgramacionIIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            this.uSUARIOSBindingSource.DataMember = "USUARIOS";
         
            // 
            // uSUARIOSTableAdapter
            // 
            
            // 
            // tableAdapterManager
            // 
           
            // 
            // uSUARIOSBindingNavigator
            // 
            this.uSUARIOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.uSUARIOSBindingNavigator.BindingSource = this.uSUARIOSBindingSource;
            this.uSUARIOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.uSUARIOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.uSUARIOSBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.uSUARIOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.uSUARIOSBindingNavigatorSaveItem});
            this.uSUARIOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.uSUARIOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.uSUARIOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.uSUARIOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.uSUARIOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.uSUARIOSBindingNavigator.Name = "uSUARIOSBindingNavigator";
            this.uSUARIOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.uSUARIOSBindingNavigator.Size = new System.Drawing.Size(1298, 27);
            this.uSUARIOSBindingNavigator.TabIndex = 0;
            this.uSUARIOSBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 20);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // uSUARIOSBindingNavigatorSaveItem
            // 
            this.uSUARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.uSUARIOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uSUARIOSBindingNavigatorSaveItem.Image")));
            this.uSUARIOSBindingNavigatorSaveItem.Name = "uSUARIOSBindingNavigatorSaveItem";
            this.uSUARIOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.uSUARIOSBindingNavigatorSaveItem.Text = "Guardar datos";
  
            // 
            // uSUARIOSDataGridView
            // 
            this.uSUARIOSDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uSUARIOSDataGridView.AutoGenerateColumns = false;
            this.uSUARIOSDataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.uSUARIOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uSUARIOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.uSUARIOSDataGridView.DataSource = this.uSUARIOSBindingSource;
            this.uSUARIOSDataGridView.GridColor = System.Drawing.SystemColors.Window;
            this.uSUARIOSDataGridView.Location = new System.Drawing.Point(42, 78);
            this.uSUARIOSDataGridView.Name = "uSUARIOSDataGridView";
            this.uSUARIOSDataGridView.RowHeadersVisible = false;
            this.uSUARIOSDataGridView.RowHeadersWidth = 51;
            this.uSUARIOSDataGridView.RowTemplate.Height = 24;
            this.uSUARIOSDataGridView.Size = new System.Drawing.Size(1204, 302);
            this.uSUARIOSDataGridView.TabIndex = 1;
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(47, 411);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(28, 16);
            dniLabel.TabIndex = 2;
            dniLabel.Text = "dni:";
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(130, 408);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(256, 22);
            this.dniTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(47, 439);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(130, 436);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(256, 22);
            this.emailTextBox.TabIndex = 5;
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(47, 467);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(77, 16);
            contraseñaLabel.TabIndex = 6;
            contraseñaLabel.Text = "contraseña:";
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(130, 464);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(256, 22);
            this.contraseñaTextBox.TabIndex = 7;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(47, 497);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(52, 16);
            estadoLabel.TabIndex = 8;
            estadoLabel.Text = "estado:";
            // 
            // estadoCheckBox
            // 
            this.estadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uSUARIOSBindingSource, "estado", true));
            this.estadoCheckBox.Location = new System.Drawing.Point(130, 492);
            this.estadoCheckBox.Name = "estadoCheckBox";
            this.estadoCheckBox.Size = new System.Drawing.Size(256, 24);
            this.estadoCheckBox.TabIndex = 9;
            this.estadoCheckBox.Text = "activo";
            this.estadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(47, 525);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(56, 16);
            nombreLabel.TabIndex = 10;
            nombreLabel.Text = "nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(130, 522);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(256, 22);
            this.nombreTextBox.TabIndex = 11;
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(47, 553);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(59, 16);
            apellidoLabel.TabIndex = 12;
            apellidoLabel.Text = "apellido:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(130, 550);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(256, 22);
            this.apellidoTextBox.TabIndex = 13;
            // 
            // iD_rolLabel
            // 
            iD_rolLabel.AutoSize = true;
            iD_rolLabel.Location = new System.Drawing.Point(47, 581);
            iD_rolLabel.Name = "iD_rolLabel";
            iD_rolLabel.Size = new System.Drawing.Size(41, 16);
            iD_rolLabel.TabIndex = 14;
            iD_rolLabel.Text = "ID rol:";
            // 
            // iD_rolTextBox
            // 
            this.iD_rolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uSUARIOSBindingSource, "ID_rol", true));
            this.iD_rolTextBox.Location = new System.Drawing.Point(130, 578);
            this.iD_rolTextBox.Name = "iD_rolTextBox";
            this.iD_rolTextBox.Size = new System.Drawing.Size(256, 22);
            this.iD_rolTextBox.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "dni";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "contraseña";
            this.dataGridViewTextBoxColumn3.HeaderText = "contraseña";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "estado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Estado";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "apellido";
            this.dataGridViewTextBoxColumn5.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ID_rol";
            this.dataGridViewTextBoxColumn6.HeaderText = "ID_rol";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // FormRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 674);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(contraseñaLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoCheckBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(iD_rolLabel);
            this.Controls.Add(this.iD_rolTextBox);
            this.Controls.Add(this.uSUARIOSDataGridView);
            this.Controls.Add(this.uSUARIOSBindingNavigator);
            this.Name = "FormRegistrarUsuario";
            this.Text = "Alta-Modificación-Baja de Usuario";
            this.Load += new System.EventHandler(this.FormRegistrarUsuario_Load);

            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSBindingNavigator)).EndInit();
            this.uSUARIOSBindingNavigator.ResumeLayout(false);
            this.uSUARIOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSUARIOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.BindingSource uSUARIOSBindingSource;
        private System.Windows.Forms.BindingNavigator uSUARIOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton uSUARIOSBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uSUARIOSDataGridView;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.CheckBox estadoCheckBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox iD_rolTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}