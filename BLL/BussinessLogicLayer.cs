using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class BussinessLogicLayer
    {
        DataAccessLayer data = new DataAccessLayer();
        public int InsertError(Error error)
        {
            return data.InsertError(error);
        }
        public DataTable ReadError()
        {
            return data.ReadError();
        }
        public int UpdateError(Error error)
        {
            return data.UpdateError(error);
        }
        public int DeleteError(Error error)
        {
            return data.DeleteError(error);
        }
        public int InsertSolution(Solution solution)
        {
            return data.InsertSolution(solution);
        }
        public DataTable GetSolution()
        {
            return data.GetSolution();
        }
        public int UpdateSolution(Solution solution)
        {
            return data.UpdateSolution(solution);
        }
        public int DeleteSolution(Solution solution)
        {
            return data.DeleteSolution(solution);
        }
        public int InsertErrorSolution(ErrorSolution es)
        {
            return data.InsertErrorSolution(es);
        }
        public DataTable GetErrorSolution()
        {
            return data.GetErrorSolution();
        }
        public int UpdateErrorSolution(ErrorSolution es)
        {
            return data.UpdateErrorSolution(es);
        }
        public int DeleteErrorSolution(ErrorSolution es)
        {
            return data.DeleteErrorSolution(es);
        }
        public int InsertModuleTopic(ModuleTopic tm)
        {
            return data.InsertModuleTopic(tm);
        }
        public DataTable GetModuleTopic()
        {
            return data.GetModuleTopic();
        }
        public int UpdateModuleTopic(ModuleTopic moduleTopic)
        {
            return data.UpdateModuleTopic(moduleTopic);
        }
        public int DeleteModuleTopic(ModuleTopic moduleTopic)
        {
            return data.DeleteModuleTopic(moduleTopic);
        }
        public int InsertUser(Administrator administrator)
        {
            return data.InsertUser(administrator);
            
        }
        public DataTable GetUser()
        {
            return data.GetUser();
        }
        public int UpdateUser(Administrator admin)
        {
            return data.UpdateUser(admin);
        }
        public int DeleteUser(Administrator admin)
        {
            return data.DeleteUser(admin);
        }
        public int InsertRole(Role role)
        {
            return data.InsertRole(role);
        }
        public DataTable GetRole()
        {
            return data.GetRole();
        }
        public int UpdateRole(Role role)
        {
            return data.UpdateRole(role);
        }
        public int DeleteRole(Role role)
        {
            return data.DeletRole(role);
        }
        public DataTable GetLogin(string email,string password)
        {
            return data.GetLogin(email,password);
        }
        public int InsertProgLang(ProgLanguage prog)
        {
            return data.InsertProgLang(prog);
        }
        public DataTable GetProgLanguage()
        {
            return data.GetProgLanguage();
        }
        public int UpdateProgLang(ProgLanguage prog)
        {
            return data.UpdateProgLang(prog);
        }
        public int DeleteProgLang(ProgLanguage prog)
        {
            return data.DeleteProgLang(prog);
        }
        public int InsertYear(Year year)
        {
            return data.InsertYear(year);
        }
        public DataTable GetYear()
        {
            return data.GetYear();
        }
        public int UpdateYear(Year year)
        {
            return data.UpdateYear(year);
        }
        public int DeleteYear(Year year)
        {
            return data.DeleteYear(year);
        }
        public int InsertTopic(Topic topic)
        {
            return data.InsertTopic(topic);
        }
        public DataTable GetTopic()
        {
            return data.GetTopic();
        }
        public int UpdateTopic(Topic topic)
        {
            return data.UpdateTopic(topic);
        }
        public int DeleteTopic(Topic topic)
        {
            return data.DeleteTopic(topic);
        }
        public int InsertModule(Module mod)
        {
            return data.InsertModule(mod);
        }
        public DataTable GetModule()
        {
            return data.GetModule();
        }
        public int UpdateModule(Module mod)
        {
            return data.UpdateModule(mod);
        }
        public int DeleteModule(Module mod)
        {
            return data.DeleteModule(mod);
        }
        public DataTable GetTopicByModule(int moduleID)
        {
            return data.GetTopicByModule(moduleID);
        }
        public DataTable GetErrorByTopic(int topicID)
        {
            return data.GetErrorByTopic(topicID);
        }
        public DataTable GetErrorByProg(int progID)
        {
            return data.GetErrorByProg(progID);
        }
        public DataTable CountQuestions()
        {
            return data.CountQuestion();
        }
    }
}
