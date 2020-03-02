﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos.Properties
{
    public class DProducto
    {
        public void InsertarProducto(EProducto obj)
        {

            SqlConnection SqlCon = new SqlConnection();
            SqlCon = Conexion.CrearInstancia().CrearConexion();
            SqlCommand cmd = new SqlCommand("uspInsertProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nombreProd", obj.idProducto);
            cmd.Parameters.AddWithValue("@prodMax", obj.prodMax);
            cmd.Parameters.AddWithValue("@prodMin", obj.prodMin);
            cmd.Parameters.AddWithValue("@precioCompra", obj.precioVenta);
            cmd.Parameters.AddWithValue("@precioVenta", obj.precioVenta);
            cmd.Parameters.AddWithValue("@fechaIngreso", obj.fechaIngreso);
            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);


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
                    prodMax = Mostrar.GetInt32(2),
                    prodMin = Mostrar.GetInt32(3),
                    precioCompra = Mostrar.GetDecimal(4),
                    precioVenta = Mostrar.GetDecimal(5),
                    fechaIngreso = Mostrar.GetDateTime(6),
                    idTipoProd = Mostrar.GetInt32(7),
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
            SqlCommand cmd = new SqlCommand("uspUdateProducto", SqlCon);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idProducto", obj.idProducto);
            cmd.Parameters.AddWithValue("@nombreProd", obj.nombreProd);
            cmd.Parameters.AddWithValue("@proMax", obj.prodMax);
            cmd.Parameters.AddWithValue("@proMin", obj.prodMin);
            cmd.Parameters.AddWithValue("@precioCompra", obj.precioCompra);
            cmd.Parameters.AddWithValue("@PrecioVenta", obj.precioVenta);
            cmd.Parameters.AddWithValue("@FechaIngreso", obj.fechaIngreso);
            cmd.Parameters.AddWithValue("@idTipoProd", obj.idTipoProd);



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