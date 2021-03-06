﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clases;
using System.Collections;

namespace asistencia
{
    public partial class frmTipoPermiso : Form
    {
        
        CValidacion ValidarDatos;
        CConection ConexionBD;
        object[] VariablesTiposDePermiso = { "pIdTipoPermiso","pNombrePermiso","pConGoceHaber","pDetalles", "pTipo","pLimiteLicencia"};
        object[] DatosTipoDePermiso = new object[6];
        ArrayList ListaMenuDiasPermiso;
        object[] ParametrosRecuperarDiasConPermiso = {"pDNI","pMes","pAnio"};
        object[] DatosRecuperarDiasConPermiso = { "DNI",01, 2011 };
        string string_ArchivoConfiguracion;
        public frmTipoPermiso(string ArchivoCOnfig)
        {
            string_ArchivoConfiguracion = ArchivoCOnfig;
            InitializeComponent();
            ValidarDatos = new CValidacion();
            ConexionBD = new CConection();
            ListaMenuDiasPermiso = new ArrayList();
            CargarDatosPersonalYPermisos();
            

        }


        public void CargarDatosPersonalYPermisos()
        {

            LimpiarDatosTipoPermiso();

            CargarDatos();

        }

        private void CargarDatos()
        {
            CargarTiposDePermiso();
        }
        /*PARA CARGAR LOS DATOS AL DATA GRIDVIEW*/
        DataSet pds_TiposDePermiso;
        private void CargarTiposDePermiso()
        {
            //Cargar dias no laborables
            ConexionBD.Conectar(false, string_ArchivoConfiguracion);
            dgvTiposDePermiso.Rows.Clear();
            string ParamName = "pValor";
            string ParamValue = "P";//P DE PERMISO
            pds_TiposDePermiso = ConexionBD.EjecutarProcedimientoReturnDataSet("spupri_ListarTiposDePermiso", ParamName, ParamValue);

            object[] ValoresFila = new object[9];
            dgvTiposDePermiso.Rows.Add(pds_TiposDePermiso.Tables[0].Rows.Count);

            for (int i = 0; i < pds_TiposDePermiso.Tables[0].Rows.Count; i++)
            {

                dgvTiposDePermiso.Rows[i].Cells[0].Value = (System.Drawing.Image)(asistencia.Properties.Resources.edit_button);
                dgvTiposDePermiso.Rows[i].Cells[1].Value = (System.Drawing.Image)(asistencia.Properties.Resources.delete);
                dgvTiposDePermiso.Rows[i].Cells[2].Value = pds_TiposDePermiso.Tables[0].Rows[i][0];
                dgvTiposDePermiso.Rows[i].Cells[3].Value = pds_TiposDePermiso.Tables[0].Rows[i][1];


                if (Convert.ToInt32(pds_TiposDePermiso.Tables[0].Rows[i][2]) == 0)
                {
                    dgvTiposDePermiso.Rows[i].Cells[4].Value = "Sin Goce de Haber";
                    dgvTiposDePermiso.Rows[i].Cells[4].Style.BackColor = Color.Red;
                    dgvTiposDePermiso.Rows[i].Cells[4].Style.ForeColor = Color.White;

                }
                if (Convert.ToInt32(pds_TiposDePermiso.Tables[0].Rows[i][2]) == 1)
                {
                    dgvTiposDePermiso.Rows[i].Cells[4].Value = "Con Goce de Haber";
                    dgvTiposDePermiso.Rows[i].Cells[4].Style.BackColor = Color.SkyBlue;
                }




                dgvTiposDePermiso.Rows[i].Cells[5].Value = pds_TiposDePermiso.Tables[0].Rows[i][3];//HORA INICIO
            }
            ConexionBD.Desconectar();


        }

        private void LimpiarDatosTipoPermiso()
        {
            DatosTipoDePermiso[0] = "0";//
            DatosTipoDePermiso[1] = "";//
            DatosTipoDePermiso[2] = "";//
            DatosTipoDePermiso[3] = "";// 
            DatosTipoDePermiso[4] = "";// 
            DatosTipoDePermiso[5] = 0;//

            tbNombre.Text = "";
            chbGoce.Checked = false;
            tbDetalles.Text = "";
            
            tbNombre.Focus();
            tbNombre.Select();

            
        }

        private void dgvTiposDePermiso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && dgvTiposDePermiso.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() != "2")
            {
                DatosTipoDePermiso[0] = dgvTiposDePermiso.Rows[e.RowIndex].Cells[2].Value;//Id
                DatosTipoDePermiso[1] = dgvTiposDePermiso.Rows[e.RowIndex].Cells[3].Value;//Nombre
                if (dgvTiposDePermiso.Rows[e.RowIndex].Cells[4].Value.ToString() == "Sin Goce de Haber")
                {
                    DatosTipoDePermiso[2] = 0;//Descuento
                }
                if (dgvTiposDePermiso.Rows[e.RowIndex].Cells[4].Value.ToString() == "Con Goce de Haber")
                {
                    DatosTipoDePermiso[2] = 1;//Descuento
                }
                DatosTipoDePermiso[3] = dgvTiposDePermiso.Rows[e.RowIndex].Cells[5].Value;// Detalle


                tbNombre.Text = DatosTipoDePermiso[1].ToString();
                if (DatosTipoDePermiso[2].ToString() == "1")
                {
                    chbGoce.Checked = true;
                }
                else
                {
                    chbGoce.Checked = false;
                }
                tbDetalles.Text = DatosTipoDePermiso[3].ToString();

                tipo = Tipo.modificar;
                habilitaBoton();
            }
            else
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 1 && dgvTiposDePermiso.Rows[e.RowIndex].Cells[2].Value.ToString().Trim() != "2")
                {
                    if (MessageBox.Show("¿Esta Seguro que quiere eliminar este tipo de permiso (" + dgvTiposDePermiso.Rows[e.RowIndex].Cells[3].Value.ToString() + ")?, \r\n Si lo hace cualquier permiso registrado de este tipo sera borrado para cualquier trabajador", "ATENCION", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        // Guardar los datos
                        ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                        bool TransaccionCompletada = false;
                        string Mensaje = "";
                        try
                        {
                            ConexionBD.EjecutarProcedimientoReturnVoid("spuDia_EliminarTipoPermiso", VariablesTiposDePermiso[0], dgvTiposDePermiso.Rows[e.RowIndex].Cells[2].Value);
                            TransaccionCompletada = true;
                            ConexionBD.COMMIT();

                            tipo = Tipo.eliminar;
                            habilitaBoton();
                        }
                        catch (Exception ex)
                        {
                            ConexionBD.ROLLBACK();
                            TransaccionCompletada = false;
                            Mensaje = ex.Message;
                        }
                        finally
                        {
                            ConexionBD.Desconectar();
                        }


                        if (TransaccionCompletada)
                        {
                            MessageBox.Show("TIPO DE PERMISO ELIMINADO CORRECTAMENTE", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarDatosTipoPermiso();
                            CargarDatos();

                        }
                        else
                            MessageBox.Show("NO SE PUDO ELIMINAR EL TIPO DE PERMISO \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarTipoPermiso();
        }


        private void GuardarTipoPermiso()
        {
            if (!ValidarDatos.EsTextoVacioOMenorLongitud(tbNombre, 3))
            {


                int goce;
                if (chbGoce.Checked)
                {
                    goce = 1;
                }
                else
                {
                    goce = 0;
                }



                DatosTipoDePermiso[1] = tbNombre.Text;
                DatosTipoDePermiso[2] = goce;
                DatosTipoDePermiso[3] = tbDetalles.Text;
                DatosTipoDePermiso[4] = "P";//P DE PERMISO
                DatosTipoDePermiso[5] = 0;//P DE PERMISO

                if (DatosTipoDePermiso[2].ToString().Trim() == "")
                    DatosTipoDePermiso[2] = 0;


                // Guardar los datos
                ConexionBD.Conectar(true, string_ArchivoConfiguracion);
                bool TransaccionCompletada = false;
                string Mensaje = "";
                try
                {
                    ConexionBD.EjecutarProcedimientoReturnVoid("spuDia_GuardarTipoPermiso", VariablesTiposDePermiso, DatosTipoDePermiso);
                    TransaccionCompletada = true;
                    ConexionBD.COMMIT();

                    tipo = Tipo.guardar;
                    habilitaBoton();


                }
                catch (Exception ex)
                {
                    ConexionBD.ROLLBACK();
                    TransaccionCompletada = false;
                    Mensaje = ex.Message;
                }
                finally
                {
                    ConexionBD.Desconectar();
                }


                if (TransaccionCompletada)
                {
                    MessageBox.Show("DATOS GUARDADOS CON EXITO", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarDatosTipoPermiso();
                    CargarDatos();
                }
                else
                    MessageBox.Show("HUBO UN ERROR AL GUARDAR LOS DATOS, ENTENTELO NUEVAMENTE \r\n" + Mensaje, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("EL TIPO DE PERMISO NO DEBE ESTAR VACIO O TIENE LONGITUD MINIMA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarDatosTipoPermiso();
            }
        }

        #region ------para las logica de botoners-------------
        private enum Tipo
        {
            guardar, modificar, eliminar, grid, subturno
        }
        private Tipo tipo;




        private void habilitaBoton()
        {
            btnGuardar.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            gbDatos.Enabled = tipo == Tipo.guardar || tipo == Tipo.modificar || tipo == Tipo.subturno;
            dgvTiposDePermiso.Enabled = dgvTiposDePermiso.Rows.Count > 0;


        }
        #endregion




        #region ---------------validacion caja de texto-----------------


        private void validaMayuscula(object sender, KeyPressEventArgs e)
        {
            ValidarDatos.texto_KeyPress(((TextBox)sender).Text, "LetrasNumerosEspacio", sender, e);

            //((TextBox)sender).CharacterCasing = CharacterCasing.Upper;

        }



        #endregion

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tipo = Tipo.guardar;
            habilitaBoton();

            LimpiarDatosTipoPermiso();
        }


    }
}
