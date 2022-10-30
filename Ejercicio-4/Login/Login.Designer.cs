namespace Login
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.ClaveText = new System.Windows.Forms.TextBox();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave";
            // 
            // CodigoUsuarioTextBox
            // 
            this.CodigoUsuarioTextBox.Location = new System.Drawing.Point(104, 34);
            this.CodigoUsuarioTextBox.Name = "CodigoUsuarioTextBox";
            this.CodigoUsuarioTextBox.Size = new System.Drawing.Size(100, 23);
            this.CodigoUsuarioTextBox.TabIndex = 2;
            // 
            // ClaveText
            // 
            this.ClaveText.Location = new System.Drawing.Point(104, 112);
            this.ClaveText.Name = "ClaveText";
            this.ClaveText.PasswordChar = '*';
            this.ClaveText.Size = new System.Drawing.Size(100, 23);
            this.ClaveText.TabIndex = 3;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aceptarbutton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Aceptarbutton1.Image = global::VistaLog.Properties.Resources.aceptar;
            this.Aceptarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton1.Location = new System.Drawing.Point(34, 186);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(88, 30);
            this.Aceptarbutton1.TabIndex = 4;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton1.UseVisualStyleBackColor = false;
            this.Aceptarbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancelarbutton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Cancelarbutton2.Image = global::VistaLog.Properties.Resources.cancelar;
            this.Cancelarbutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton2.Location = new System.Drawing.Point(187, 186);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(92, 30);
            this.Cancelarbutton2.TabIndex = 5;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton2.UseVisualStyleBackColor = false;
            this.Cancelarbutton2.Click += new System.EventHandler(this.Cancelarbutton2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.errorProvider1.SetIconAlignment(this.pictureBox1, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.pictureBox1.Image = global::VistaLog.Properties.Resources.iniciar_sesion__1_;
            this.pictureBox1.Location = new System.Drawing.Point(370, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.Aceptarbutton1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton2;
            this.ClientSize = new System.Drawing.Size(536, 233);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.ClaveText);
            this.Controls.Add(this.CodigoUsuarioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox CodigoUsuarioTextBox;
        private TextBox ClaveText;
        private Button Aceptarbutton1;
        private Button Cancelarbutton2;
        private ErrorProvider errorProvider1;
        private PictureBox pictureBox1;
    }
}