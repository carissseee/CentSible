using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CentSible.Models;

namespace CentSible.Database
{
    public class GoalDB
    {
        

        public List<Goal> GetGoalsByPeriod(int accountId, int month, int year)
        {
            List<Goal> list = new List<Goal>();
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                string query = "SELECT * FROM goals WHERE accountID = @id AND MONTH(targetDate) = @m AND YEAR(targetDate) = @y";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", accountId);
                cmd.Parameters.AddWithValue("@m", month);
                cmd.Parameters.AddWithValue("@y", year);
                conn.Open();
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        list.Add(new Goal
                        {
                            GoalID = Convert.ToInt32(rdr["goalID"]),
                            AccountID = Convert.ToInt32(rdr["accountID"]),
                            GoalType = (GoalCategory)Enum.Parse(typeof(GoalCategory), rdr["goalType"].ToString(), true),
                            TargetAmount = Convert.ToDouble(rdr["targetAmount"]),
                            CurrentAmount = Convert.ToDouble(rdr["currentAmount"]),
                            TargetDate = Convert.ToDateTime(rdr["targetDate"])
                        });
                    }
                }
            }
            return list;
        }

        public bool AddGoal(Goal g)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                string query = "INSERT INTO goals (accountID, goalType, targetAmount, currentAmount, targetDate) VALUES (@id, @type, @target, @current, @date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", g.AccountID);
                cmd.Parameters.AddWithValue("@type", g.GoalType.ToString());
                cmd.Parameters.AddWithValue("@target", g.TargetAmount);
                cmd.Parameters.AddWithValue("@current", g.CurrentAmount);
                cmd.Parameters.AddWithValue("@date", g.TargetDate);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool UpdateGoal(Goal g)
        {
            using (MySqlConnection conn = new MySqlConnection(DBConfig.ConnectionString))
            {
                string query = "UPDATE goals SET targetAmount = @target, currentAmount = @current, targetDate = @date WHERE accountID = @id AND goalType = @type AND MONTH(targetDate) = MONTH(@date) AND YEAR(targetDate) = YEAR(@date)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", g.AccountID);
                cmd.Parameters.AddWithValue("@type", g.GoalType.ToString());
                cmd.Parameters.AddWithValue("@target", g.TargetAmount);
                cmd.Parameters.AddWithValue("@current", g.CurrentAmount);
                cmd.Parameters.AddWithValue("@date", g.TargetDate);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}