using System;
using System.Data.Common;
using System.Data.SqlServerCe;

namespace PosColector.DAO
{
	public class SynchronizerDAO : pos_colector
	{
		private string dateInitial = "01/05/2017 07:00:00";

		public static int count { get; set; }

		private string getLastChangeDateTimeItems()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM articulo ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeProvider()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM proveedor ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUnits()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM unidad_medida ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUsers()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM usuario ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		private string getLastChangeDateTimeUsuarioPermiso()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM usuario_permiso ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		public static string getLastChangeDateTimeOrders()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM orden ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : null;
		}

		private string getLastChangeDateTimeOrdersDetail()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM orden_articulo ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : dateInitial;
		}

		public static string getLastChangeDateTimeInventarios()
		{
			string sqlCommand = "SELECT TOP(1) CONVERT(nvarchar,fecha_registro,121) fecha_registro FROM inventario_fisico ORDER BY fecha_registro DESC";
			SqlCeDataReader data = pos_colector.GetData(sqlCommand);
			return ((DbDataReader)(object)data).Read() ? ((DbDataReader)(object)data)["fecha_registro"].ToString() : null;
		}
	}
}
