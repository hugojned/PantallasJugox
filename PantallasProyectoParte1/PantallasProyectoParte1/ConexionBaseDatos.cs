﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PantallasProyectoParte1
{
    class ConexionBaseDatos
    {
        static private string CadenaConexion = "Server=DESKTOP-NA66HVT; DataBase = EditorParte2; Integrated Security = true";
        private SqlConnection cn = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            return cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            return cn;
        }
    }
}
