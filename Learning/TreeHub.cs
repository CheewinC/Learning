using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Newtonsoft.Json;

namespace Learning
{
    public class TreeHub : Hub
    {
        public void AddTreeHub(int id,string name,int parentId)
        {
            LearningDataContext db = new LearningDataContext();
            db.Trees.InsertOnSubmit(new Tree
            {
                Id = id,
                Name = name,
                ParentId = parentId
            });
            db.SubmitChanges();
            Clients.All.addGridviewrow(id, name, parentId);
        }

        public void GetTreeData()
        {
            string jsonData = GetData();
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<TreeHub>();
            context.Clients.All.displayStatus(jsonData);
        }

        private string GetData()
        {
            using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LearningConnectionString"].ConnectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"SELECT [Id],[Name],[ParentId] FROM [dbo].[Tree]", connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;

                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (var reader = command.ExecuteReader()) { 
                        var data = reader.Cast<IDataRecord>()
                            .Select(x => new Tree()
                            {
                                Id = x.GetInt32(0),
                                Name = x.GetString(1),
                                ParentId = x.GetInt32(2),
                            }).ToList();
                        return JsonConvert.SerializeObject(data);
                    }
                }
            }
        }
        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            GetTreeData();
        }
    }
}