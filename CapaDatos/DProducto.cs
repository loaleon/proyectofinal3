﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
   public class DProducto
    {
        public void InsertarProducto(EProducto obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombreProd", obj.nombreProd);
            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);
            cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
            cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
            cmd.Parameters.AddWithValue("@prodMax", obj.prodMax);
            cmd.Parameters.AddWithValue("@prodMin", obj.prodMin);
            cmd.Parameters.AddWithValue("@precioCompra", obj.precioCompra);
            cmd.Parameters.AddWithValue("@precioVenta", obj.precioVenta);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
       
           


            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }
        public List<EProducto> ListarProducto(string buscar)
        {
            SqlDataReader Mostrar;
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspSelectProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            SqlCon.Open();
            cmd.Parameters.AddWithValue("@buscar", buscar);
            Mostrar = cmd.ExecuteReader();

            List<EProducto> Listar = new List<EProducto>();

            while (Mostrar.Read())
            {
                Listar.Add(new EProducto
                {

                    idProducto = Mostrar.GetInt32(0),
                    nombreProd = Mostrar.GetString(1),
                    idTipoProd = Mostrar.GetInt32(2),
                    descripcion = Mostrar.GetString(3),
                    idProveedor = Mostrar.GetInt32(4),
                    precioCompra = Mostrar.GetDecimal(5),
                    precioVenta = Mostrar.GetDecimal(6),
                    prodMax = Mostrar.GetInt32(7),
                    prodMin = Mostrar.GetInt32(8), 
                    fechaIngreso = Mostrar.GetDateTime(9),
                    
                    
                    
                });
            }
            SqlCon.Close();
            Mostrar.Close();

            return Listar;
        }
        public void ActualizarProducto(EProducto obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertProducto", SqlCon);

            cmd.Parameters.AddWithValue("@nombreProd", obj.nombreProd);
            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);
            cmd.Parameters.AddWithValue("@descripcion", obj.descripcion);
            cmd.Parameters.AddWithValue("@idProveedor", obj.idProveedor);
            cmd.Parameters.AddWithValue("@proMax", obj.prodMax);
            cmd.Parameters.AddWithValue("@proMin", obj.prodMin);
            cmd.Parameters.AddWithValue("@precioCompra", obj.precioCompra);
            cmd.Parameters.AddWithValue("@precioVenta", obj.precioVenta);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);



            SqlCon.Open();

            cmd.ExecuteNonQuery();

            SqlCon.Close();
        }

        public void ElimiarProducto(EProducto obj)
        {
            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspDeleteProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto);

            SqlCon.Open();
            cmd.ExecuteNonQuery();
            SqlCon.Close();

        }
    }
}
