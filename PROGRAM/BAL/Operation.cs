using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BEL;
using System.Data;
using System.Data.SqlClient;

namespace BAL
{
    public class Operation
    {
        public Dbconnection db = new Dbconnection();
        public Informations info = new Informations();

        public DataTable viewclients(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.CLIENTS";
            return db.ExeReader(cmd);
        }

        public DataTable viewholdings(Informations info, string act_nbr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.HOLDINGS where act_nbr =" + act_nbr;
            return db.ExeReader(cmd);
        }

        public DataTable viewmaster(Informations info, string ind_code)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.MASTER where INDUSTRY =" + ind_code;
            return db.ExeReader(cmd);
        }

        public DataTable viewindustry(Informations info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from dbo.INDUSTRY";
            return db.ExeReader(cmd);
        }
    }
}
