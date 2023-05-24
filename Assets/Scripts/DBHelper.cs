using System.Collections.Generic;
using DefaultNamespace;
using HakatonApp;
using Npgsql;

public class DBHelper
{
    private Dictionary<Roles, string> _connectionsSettings = new Dictionary<Roles, string>()
    {
        { Roles.advertiser, "advertiser123" },
        { Roles.customer, "customer123" },
        { Roles.guest, "guest123" },
        { Roles.judge, "judge123" },
        { Roles.mentor, "mentor123" },
        { Roles.organizer, "organizer123" },
        { Roles.participant, "participant123" },
        { Roles.postgres, "postgres123" },
        { Roles.sponsor, "sponsor123" },
        { Roles.cu_org, "cu_org123" },
        { Roles.cu_org_sp, "cu_org_sp123" }, 
        { Roles.cu_sp, "cu_sp123" },
        { Roles.ju_me, "ju_me123" },
    };

    public void RegUser(string login, string password, Roles roleId)
    {
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={roleId.ToString()};Password={_connectionsSettings[roleId]};";
        using (NpgsqlConnection conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"select insert_user('{login}', '{password}', {(int)roleId})");
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    public Roles GetUserRole(string login)
    {
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id=postgres;Password=postgres123;";
        using (NpgsqlConnection conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"select role_id from users where login = '{login}'", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return (Roles)dr.GetInt32(0);
            }
            conn.Close();
        }

        return Roles.postgres;
    }

    public void UpdatePassword(string login, string newPassword)
    {
        Roles roleId = GetUserRole(login);
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={roleId.ToString()};Password={_connectionsSettings[roleId]};";

        using (var conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            var cmd = new NpgsqlCommand($"select update_password('{login}', '{newPassword}')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

    public bool AuthUser(string login, string password)
    {
        Roles roleId = GetUserRole(login);
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={roleId.ToString()};Password={_connectionsSettings[roleId]};";

        using (NpgsqlConnection conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"select check_user('{login}', '{password}')", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return dr.GetBoolean(0);
            }
        }

        return false;
    }

    public List<Hakaton> GetHakatonsInfo(string login)
    {
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={GetUserRole(login).ToString()};Password={_connectionsSettings[GetUserRole(login)]};";

        var hakatonsInfo = new List<Hakaton>();
        using (var conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            var cmd = new NpgsqlCommand("select * from hakaton_info", conn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hakatonsInfo.Add(new Hakaton(dr.GetString(0), dr.GetBoolean(1), dr.GetDateTime(2), dr.GetDateTime(3),
                    dr.GetDecimal(4), dr.GetInt32(5)));
            }
            conn.Close();
        }

        return hakatonsInfo;
    }

    public List<TaskRating> GetTasksInfo(string login)
    {
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={GetUserRole(login).ToString()};Password={_connectionsSettings[GetUserRole(login)]};";

        var tasksInfo = new List<TaskRating>();
        using (var conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            var cmd = new NpgsqlCommand("select * from rating_info", conn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tasksInfo.Add(new TaskRating(dr.GetString(0), dr.GetString(1), dr.GetString(2), dr.GetString(3),
                    dr.GetTimeSpan(4), dr.GetDecimal(5)));
            }
            conn.Close();
        }

        return tasksInfo;
    }

    public List<TopTeam> GetTopTeamsInfo(string login)
    {
        string connection =
            $"Server=127.0.0.1;Port=5432;Database=hakaton;User Id={GetUserRole(login).ToString()};Password={_connectionsSettings[GetUserRole(login)]};";

        var topTeams = new List<TopTeam>();
        using (var conn = new NpgsqlConnection(connection))
        {
            conn.Open();
            var cmd = new NpgsqlCommand("select * from top_teams_per_hakaton()", conn);
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                topTeams.Add(new TopTeam(dr.GetString(0), dr.GetString(1), dr.GetDecimal(2), dr.GetTimeSpan(3),
                    dr.GetDecimal(4)));
            }
            conn.Close();
        }

        return topTeams;
    }
}