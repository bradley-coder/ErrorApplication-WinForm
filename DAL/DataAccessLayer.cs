using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DataAccessLayer
    {
        static string connString = "Data Source=localhost;Initial Catalog=ErrorDB;Integrated Security=true;";
        SqlConnection connection = new SqlConnection(connString);
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        public int InsertError(Error error)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertError";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorDescription", error.ErrorDescription);
            command.Parameters.AddWithValue("@StudentID", error.StudentID);
            command.Parameters.AddWithValue("@ProgLanguageID", error.ProgLanguageID);
            command.Parameters.AddWithValue("@ModuleTopicID", error.ModuleTopicID);
            command.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);
            int x = command.ExecuteNonQuery();                       
            return x;
            connection.Close();
        }
        public DataTable ReadError()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_ReadError";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();          
        }
        public int UpdateError(Error error)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateError";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorID", error.ErrorID);
            command.Parameters.AddWithValue("@ErrorStatus", error.ErrorStatus);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteError(Error error)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteError";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorID", error.ErrorID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertSolution(Solution solution)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SolutionDescription", solution.SolutionDescription);
            command.Parameters.AddWithValue("@LecturerID", solution.LecturerID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetSolution()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetSolution";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateSolution(Solution solution)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SolutionID", solution.SolutionID);
            command.Parameters.AddWithValue("@SolutionDescription", solution.SolutionDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteSolution(Solution solution)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SolutionID", solution.SolutionID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertErrorSolution(ErrorSolution errorSolution)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertErrorSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorID", errorSolution.ErrorID);
            command.Parameters.AddWithValue("@SolutionID", errorSolution.SolutionID);
            command.Parameters.AddWithValue("@SolutionDate", errorSolution.SolutionDate);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetErrorSolution()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetErrorSolution";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateErrorSolution(ErrorSolution es)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateErrorSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorSolutionID", es.ErrorSolutionID);
            command.Parameters.AddWithValue("@ErrorID", es.ErrorID);
            command.Parameters.AddWithValue("@SolutionID", es.SolutionID);
            command.Parameters.AddWithValue("@SolutionDate", es.SolutionDate);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteErrorSolution(ErrorSolution es)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteErrorSolution";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ErrorSolutionID", es.ErrorSolutionID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertModuleTopic(ModuleTopic tm)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertModuleTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleID", tm.ModuleID);
            command.Parameters.AddWithValue("@TopicID", tm.TopicID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetModuleTopic()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetModuleTopic";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateModuleTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleTopicID", moduleTopic.ModuleTopicID);
            command.Parameters.AddWithValue("@ModuleID", moduleTopic.ModuleID);
            command.Parameters.AddWithValue("@TopicID", moduleTopic.TopicID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteModuleTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleTopicID", moduleTopic.ModuleTopicID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertUser(Administrator admin)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertUser";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserName",admin.UserName );
            command.Parameters.AddWithValue("@SurName", admin.SurName);
            command.Parameters.AddWithValue("@Email", admin.Email);
            command.Parameters.AddWithValue("@Password", admin.Password);
            command.Parameters.AddWithValue("@RoleID", admin.RoleID);
            
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
            
        }
        public DataTable GetUser()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetUser";
            command = new SqlCommand(sql, connection);
            //command.CommandType = CommandType.StoredProcedure;
            //command.Parameters.AddWithValue("@RoleID", roleID);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateUser(Administrator admin)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UserUpdate";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", admin.UserID);
            command.Parameters.AddWithValue("@RoleID", admin.RoleID);
            command.Parameters.AddWithValue("@Email", admin.Email);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteUser(Administrator admin)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteUser";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@UserID", admin.UserID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertRole(Role role)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            //string sql = "INSERT INTO tblError(ErrorDescription) " +
            //    "VALUES(@ErrorDescription)";
            string sql = "sp_InsertRole";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);
            //command.Parameters.AddWithValue("@RoleDescription", admin.RoleDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetRole()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetRole";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();          
        }
        public int UpdateRole(Role role)
        {

            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateRole";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleID", role.RoleID);
            command.Parameters.AddWithValue("@RoleDescription", role.RoleDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeletRole(Role role)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteRole";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@RoleID", role.RoleID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetLogin(string email,string password)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetLogin";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Email",email);
            command.Parameters.AddWithValue("@Password",password);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int InsertProgLang(ProgLanguage prog)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertProgLanguage";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProgLanguageDescription", prog.ProgLanguageDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetProgLanguage()
        {

            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetProgLan";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateProgLang(ProgLanguage prog)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateProgLang";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProgLanguageID", prog.ProgLanguageID);
            command.Parameters.AddWithValue("@ProgLanguageDescription", prog.ProgLanguageDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteProgLang(ProgLanguage prog)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteProgLang";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProgLanguageID", prog.ProgLanguageID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertYear(Year year)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertYear";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@YearDescription", year.YearDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetYear()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetYear";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateYear(Year year)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateYear";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@YearID", year.YearID);
            command.Parameters.AddWithValue("@YearDescription", year.YearDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteYear(Year year)
        {

            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteYear";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@YearID", year.YearID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertTopic(Topic topic)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TopicDescription",topic.TopicDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetTopic()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetTopic";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateTopic(Topic topic)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TopicID", topic.TopicID);
            command.Parameters.AddWithValue("@TopicDescription", topic.TopicDescription);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteTopic(Topic topic)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TopicID", topic.TopicID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int InsertModule(Module module)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_InsertModule";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);
            command.Parameters.AddWithValue("@YearID",module.YearID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetModule()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetModule";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public int UpdateModule(Module module)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_UpdateModule";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleID",module.ModuleID);           
            command.Parameters.AddWithValue("@ModuleDescription", module.ModuleDescription);
            command.Parameters.AddWithValue("@YearID", module.YearID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public int DeleteModule(Module module)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_DeleteModule";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleID", module.ModuleID);
            int x = command.ExecuteNonQuery();
            return x;
            connection.Close();
        }
        public DataTable GetTopicByModule(int moduleID)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetTopicByModule";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ModuleID",moduleID);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public DataTable GetErrorByTopic(int topicID)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetErrorByTopic";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@TopicID", topicID);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public DataTable GetErrorByProg(int progID)
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_GetErrorByProg";
            command = new SqlCommand(sql, connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ProgLanguageID", progID);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }
        public DataTable CountQuestion()
        {
            try
            {
                connection.Open();
            }
            catch
            {

            }
            string sql = "sp_CountQuestions";
            command = new SqlCommand(sql, connection);
            dt = new DataTable();
            adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
            connection.Close();
        }

    }
}
