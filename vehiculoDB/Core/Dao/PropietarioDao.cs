using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using vehiculoDB.Core.Clases;
using vehiculoDB.Core.Lib;
using System.Data;

namespace vehiculoDB.Core.Dao
{
    internal class PropietarioDao: Cnn, IPropietarioDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idPropietario)
        {
            throw new NotImplementedException();
        }

        public List<Propietario> GetAll(string filtro = "")
        {
            var lista = new List<Propietario>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"
                    SELECT IdPropietario, Nombre, Apellido, DUI, Telefono, Direccion FROM Propietarios /**where**/
                    ORDER BY  IdPropietario DESC;";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/**where**/", "WHERE Nombre LIKE @r  OR Apellido LIKE @f OR DUI @f");
                }
                else
                {
                    sql = sql.Replace("/**where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 120).Value = "%{filtro}%";
                }

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    lista.Add(Map(rd));
                }
            }
            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }
            return lista;
        }

        private static Propietario Map(SqlDataReader rd)
        {
            return new Propietario
            {
                IdPropetario = rd.GetInt32(0),
                Nombre = rd.GetString(1),
                Apellido = rd.GetString(2),
                Dui = rd.GetString(3),
                Telefono = rd.IsDBNull(4) ? null : rd.GetString(4),
                Direccion = rd.IsDBNull(5) ? null : rd.GetString(5)
            };

        }

        public Propietario? GetById(int idPropietario)
        {
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    SELECT IdPropietario, Nombre, Apellido, DUI, Telefono, Direccion 
                    FROM Propietarios 
                    WHERE IdPropietario = @idPropietario;", Con);

                command.Parameters.Add("@idPropietario", SqlDbType.Int).Value = idPropietario;
                rd = command.ExecuteReader(CommandBehavior.SingleRow);

                if(!rd.Read())
                {
                    return null;
                }

                return Map(rd);

            }

            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }
        }

        public int Insert(Propietario paPropietario)
        {
            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    INSERT INTO Propietarios (Nombre, Apellido, DUI, Telefono, Direccion)
                    OUTPUT INSERTED.IdPropietario
                    VALUES (@nombre, @apellido, @dui, @telefono, @direccion);
                    SELECT SCOPE_IDENTITY();", Con);

                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paPropietario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar, 100).Value = paPropietario.Apellido;
                command.Parameters.Add("@dui", SqlDbType.Char, 10).Value = paPropietario.Dui;
                command.Parameters.Add("@telefono", SqlDbType.Char, 15).Value = (object?)paPropietario.Telefono ?? DBNull.Value ;
                command.Parameters.Add("@direccion", SqlDbType.NVarChar, 200).Value = (object?)paPropietario.Direccion ?? DBNull.Value;

                var id = command.ExecuteScalar();
                return Convert.ToInt32(id);

            }
            catch ( SqlException ex) when (ex.Number == 2627 || ex.Number == 2601){
                throw new ApplicationException("El DUI ya existe, verifica la informacion. ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public bool Update(Propietario paPropietario)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
                    UPDATE Propietarios
                    SET Nombre = @nombre,
                        Apellido = @apellido,
                        DUI = @dui,
                        Telefono = @telefono,
                        Direccion = @direccion
                    WHERE IdPropietario = @idPropietario;", Con);
                command.Parameters.Add("@idPropietario", SqlDbType.Int).Value = paPropietario.IdPropetario;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paPropietario.Nombre;
                command.Parameters.Add("@apellido", SqlDbType.NVarChar, 100).Value = paPropietario.Apellido;
                command.Parameters.Add("@dui", SqlDbType.Char, 10).Value = paPropietario.Dui;
                command.Parameters.Add("@telefono", SqlDbType.Char, 15).Value = (object?)paPropietario.Telefono ?? DBNull.Value;
                command.Parameters.Add("@direccion", SqlDbType.NVarChar, 200).Value = (object?)paPropietario.Direccion ?? DBNull.Value;
                var filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("El DUI ya existe, verifica la informacion. ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }

        }   

    }

}
