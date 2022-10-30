﻿using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaLog
{
    public partial class Userforms : Form
    {
        public Userforms()
        {
            InitializeComponent();
        }

        UsuarioDatos userDatos = new UsuarioDatos();
        string tipoOperacion = string.Empty;
        Usuario user;

        private void Userforms_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
        }

        private async void LlenarDataGrid()
        {
            UsuariosdataGridView.DataSource = await userDatos.DevolverListaAsync();
        }

        private void nuevobutton_Click(object sender, EventArgs e)
        {
            Habilitarcontroles();
            tipoOperacion = "Nuevo";
        }

        private void Habilitarcontroles()
        {
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ClavetextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            EstaActivocheckBox.Enabled = true;
        }
        private void Deshabilitarcontroles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ClavetextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            EstaActivocheckBox.Enabled = false;
        }
        private void Limpiarcontroles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ClavetextBox.Clear();
            CorreotextBox.Clear();
            RolcomboBox.Text = String.Empty;
            EstaActivocheckBox.Checked = false;
        }
        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Deshabilitarcontroles();
            Limpiarcontroles();
        }
        private void Modificarbutton_Click(object sender, EventArgs e)
        {
            tipoOperacion = "Modificar";

        }

        private async void Guardarbutton_Click(object sender, EventArgs e)
        {
            user = new Usuario();

            if (tipoOperacion == "Nuevo")
            {
                if (CodigotextBox.Text == "")
                {
                    errorProvider1.SetError(CodigotextBox, "Por favor ingrese un codigo");
                    CodigotextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(NombretextBox.Text));
                {
                    errorProvider1.SetError(NombretextBox, "Por favor ingrese un nombre");
                   NombretextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(ClavetextBox.Text)) ;
                {
                    errorProvider1.SetError(ClavetextBox, "Por favor ingrese una clave");
                    ClavetextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(RolcomboBox.Text)) ;
                {
                    errorProvider1.SetError(RolcomboBox, "seleccione un rol");
                    RolcomboBox.Focus();
                    return;
                }
                
                user.Codigo = CodigotextBox.Text;
                user.Nombre = NombretextBox.Text;
                user.Clave = ClavetextBox.Text;
                user.Correo = CorreotextBox.Text;
                user.Rol = RolcomboBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                bool inserto = await userDatos.InsertarAsync(user);


                if (inserto)
                {
                    LlenarDataGrid();
                    Limpiarcontroles();
                    Deshabilitarcontroles();

                    MessageBox.Show("Usuario Guardado","", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario no se pudo guardar", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}