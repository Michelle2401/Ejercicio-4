namespace VistaLog
{
    partial class Userforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userforms));
            this.label1 = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.RolcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Enabled = false;
            this.CodigotextBox.Location = new System.Drawing.Point(103, 12);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(192, 23);
            this.CodigotextBox.TabIndex = 1;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Enabled = false;
            this.NombretextBox.Location = new System.Drawing.Point(103, 51);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(192, 23);
            this.NombretextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Clave";
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Enabled = false;
            this.ClavetextBox.Location = new System.Drawing.Point(103, 90);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(192, 23);
            this.ClavetextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Correo";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Enabled = false;
            this.CorreotextBox.Location = new System.Drawing.Point(103, 141);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(192, 23);
            this.CorreotextBox.TabIndex = 7;
            // 
            // RolcomboBox
            // 
            this.RolcomboBox.Enabled = false;
            this.RolcomboBox.FormattingEnabled = true;
            this.RolcomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.RolcomboBox.Location = new System.Drawing.Point(103, 194);
            this.RolcomboBox.Name = "RolcomboBox";
            this.RolcomboBox.Size = new System.Drawing.Size(192, 23);
            this.RolcomboBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(51, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(21, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "EstaActivo";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Enabled = false;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(103, 253);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 11;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Guardarbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton.Location = new System.Drawing.Point(461, 229);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(85, 38);
            this.Guardarbutton.TabIndex = 12;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Modificarbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Modificarbutton.Image = global::VistaLog.Properties.Resources.editar_documento;
            this.Modificarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Modificarbutton.Location = new System.Drawing.Point(371, 229);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(94, 38);
            this.Modificarbutton.TabIndex = 13;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Modificarbutton.UseVisualStyleBackColor = false;
            this.Modificarbutton.Click += new System.EventHandler(this.Modificarbutton_Click);
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(27, 288);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowTemplate.Height = 25;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(555, 153);
            this.UsuariosdataGridView.TabIndex = 14;
            // 
            // nuevobutton
            // 
            this.nuevobutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nuevobutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("nuevobutton.Image")));
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nuevobutton.Location = new System.Drawing.Point(293, 229);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(81, 38);
            this.nuevobutton.TabIndex = 15;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.nuevobutton.UseVisualStyleBackColor = false;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelarbutton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancelarbutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Cancelarbutton.Image = global::VistaLog.Properties.Resources.prohibido;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(543, 229);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(86, 38);
            this.Cancelarbutton.TabIndex = 16;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Userforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 453);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RolcomboBox);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.label1);
            this.Name = "Userforms";
            this.Text = "Userforms";
            this.Load += new System.EventHandler(this.Userforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox CodigotextBox;
        private TextBox NombretextBox;
        private Label label2;
        private Label label3;
        private TextBox ClavetextBox;
        private Label label4;
        private TextBox CorreotextBox;
        private ComboBox RolcomboBox;
        private Label label5;
        private Label label6;
        private CheckBox EstaActivocheckBox;
        private Button Guardarbutton;
        private Button Modificarbutton;
        private DataGridView UsuariosdataGridView;
        private Button nuevobutton;
        private Button Cancelarbutton;
        private ErrorProvider errorProvider1;
    }
}