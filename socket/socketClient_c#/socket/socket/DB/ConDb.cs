using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace socket
{
    public class ConDb
    {
        public string strIP { get; set; }
        public string strDB { get; set; }
        public string strID { get; set; }
        public string strPW { get; set; }

        public ConDb()
        {
            strID = "interfaceuser";
            strPW = "interfaceuser";
        }
        public override string ToString()
        {
            return $"ID: {strID}, Password: {strPW} IP: {strIP} DB: {strDB}";
        }

        public bool ValueCheck()
        {
            var properties = new[] { strIP, strDB, strID, strPW };
            return properties.All(p => !string.IsNullOrEmpty(p));

        }

        public SqlConnection InitializeConnection()
        {
            var connectionString = $"Data Source={strIP};Initial Catalog={strDB};Persist Security Info=True; User ID={strID};Password={strPW}";
            var sqlCon = new SqlConnection(connectionString);
            return sqlCon;
        }

        public async Task InsertData(Dto dto)
        {
            using (SqlConnection sqlCon = InitializeConnection())

            {
                using (SqlCommand sqlCom = new SqlCommand())
                {
                    sqlCom.CommandTimeout = 600;
                    sqlCom.CommandType = CommandType.Text;
                    var queryBuilder = new StringBuilder();
                    queryBuilder.Append("INSERT INTO measure_interface(INTERFACE_ID, MEASURE_DATE, MEASURE_TIME, CAR_NUMBER, ")
                                .Append("A_CODE, ITEM_CODE, TOTAL_WEIGHT, EMPTY_WEIGHT, MEASURE_FLAG, WEIGHT_FLAG, INTERFACE_FLAG, ")
                                .Append("LOAD_TYPE, BALE_SIZE, BALE_COUNT) ")
                                .Append("VALUES (@INTERFACE_ID, @MEASURE_DATE, @MEASURE_TIME, @CAR_NUMBER, @A_CODE, @ITEM_CODE, ")
                                .Append("@TOTAL_WEIGHT, @EMPTY_WEIGHT, @MEASURE_FLAG, @WEIGHT_FLAG, @INTERFACE_FLAG, ")
                                .Append("@LOAD_TYPE, @BALE_SIZE, @BALE_COUNT)");

                    sqlCom.CommandText = queryBuilder.ToString();

                    sqlCom.Parameters.Add("@INTERFACE_ID", SqlDbType.VarChar).Value = dto.INTERFACE_ID;
                    sqlCom.Parameters.Add("@MEASURE_DATE", SqlDbType.VarChar).Value = dto.MEASURE_DATE;
                    sqlCom.Parameters.Add("@MEASURE_TIME", SqlDbType.VarChar).Value = dto.MEASURE_TIME;
                    sqlCom.Parameters.Add("@CAR_NUMBER", SqlDbType.VarChar).Value = dto.CAR_NUMBER;
                    sqlCom.Parameters.Add("@A_CODE", SqlDbType.VarChar).Value = dto.A_CODE;
                    sqlCom.Parameters.Add("@ITEM_CODE", SqlDbType.VarChar).Value = dto.ITEM_CODE;
                    sqlCom.Parameters.Add("@TOTAL_WEIGHT", SqlDbType.VarChar).Value = dto.TOTAL_WEIGHT;
                    sqlCom.Parameters.Add("@EMPTY_WEIGHT", SqlDbType.VarChar).Value = dto.EMPTY_WEIGHT;
                    sqlCom.Parameters.Add("@MEASURE_FLAG", SqlDbType.VarChar).Value = dto.MEASURE_FLAG;
                    sqlCom.Parameters.Add("@WEIGHT_FLAG", SqlDbType.VarChar).Value = dto.WEIGHT_FLAG;
                    sqlCom.Parameters.Add("@INTERFACE_FLAG", SqlDbType.VarChar).Value = dto.INTERFACE_FLAG;
                    sqlCom.Parameters.Add("@LOAD_TYPE", SqlDbType.VarChar).Value = dto.LOAD_TYPE;
                    sqlCom.Parameters.Add("@BALE_SIZE", SqlDbType.VarChar).Value = dto.BALE_SIZE;
                    sqlCom.Parameters.Add("@BALE_COUNT", SqlDbType.VarChar).Value = dto.BALE_COUNT;

                    sqlCom.Connection = sqlCon;
                    sqlCon.Open();
                    await sqlCom.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task UpdateData(Dto dto)
        {
            using (SqlConnection sqlCon = InitializeConnection())

            {
                using (SqlCommand sqlCom = new SqlCommand())
                {
                    sqlCom.CommandTimeout = 600;
                    sqlCom.CommandType = CommandType.Text;
                    var queryBuilder = new StringBuilder();
                    queryBuilder.Append("UPDATE measure_interface SET ")
                                .Append("EMPTY_WEIGHT = @EMPTY_WEIGHT, ")  
                                .Append("WEIGHT_FLAG = 2 ")  
                                .Append("WHERE MEASURE_DATE = @MEASURE_DATE AND INTERFACE_ID = @INTERFACE_ID");


                    sqlCom.CommandText = queryBuilder.ToString();

                    sqlCom.Parameters.Add("@EMPTY_WEIGHT", SqlDbType.VarChar).Value = dto.EMPTY_WEIGHT;
                    sqlCom.Parameters.Add("@MEASURE_DATE", SqlDbType.VarChar).Value = dto.MEASURE_DATE;
                    sqlCom.Parameters.Add("@INTERFACE_ID", SqlDbType.VarChar).Value = dto.INTERFACE_ID;

                    sqlCom.Connection = sqlCon;
                    sqlCon.Open();
                    await sqlCom.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
