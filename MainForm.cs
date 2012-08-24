using System;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Raven.Client.Document;
using Raven.Client.Extensions;
using Raven.Client.Indexes;

namespace SampleRavenIndexReplication
{
    public partial class MainForm : Form
    {
        private const string RavenDatabaseName = "Sample";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _ravenUrlTextBox.Text = ConfigurationManager.AppSettings["RavenURL"];
            _sqlConnectionStringTextBox.Text = ConfigurationManager.ConnectionStrings["Reports"].ConnectionString;
        }

        private void createTableButtonClick(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(_sqlConnectionStringTextBox.Text))
            {
                connection.Open();
                SqlCommand createTable = new SqlCommand(@"  CREATE TABLE [dbo].[Dogs]( 
                                                                [Id] nvarchar(64) NULL, 
                                                                [Name] nchar(255) NULL, 
                                                                [Breed] nchar(255) NULL) 
                                                            ON [PRIMARY]", connection);
                createTable.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void createIndexButtonClick(object sender, EventArgs e)
        {
            using (var store = new DocumentStore { Url = _ravenUrlTextBox.Text })
            {
                store.Initialize();
                IndexCreation.CreateIndexes(new CompositionContainer(new AssemblyCatalog(typeof(Dogs_List).Assembly)), store.DatabaseCommands.ForDatabase(RavenDatabaseName), store.Conventions);
            }
        }

        private void _configureReplicationButton_Click(object sender, EventArgs e)
        {
            var replicationDocument = new Raven.Bundles.IndexReplication.Data.IndexReplicationDestination
                {
                    Id = "Raven/IndexReplication/Dogs/List", 
                    ColumnsMapping =
                        {
                            { "Name", "Name" },
                            { "Breed", "Breed" }
                        }, 
                    ConnectionStringName = "Reports", 
                    PrimaryKeyColumnName = "Id", 
                    TableName = "Dogs"
                };


            using (var store = new DocumentStore { Url = _ravenUrlTextBox.Text })
            {
                store.Initialize();
                store.DatabaseCommands.EnsureDatabaseExists(RavenDatabaseName);
                using (var session = store.OpenSession(RavenDatabaseName))
                {
                    session.Store(replicationDocument); 
                    session.SaveChanges();
                }
            }
        }

        private void _resetIndexButton_Click(object sender, EventArgs e)
        {
            using (var store = new DocumentStore { Url = _ravenUrlTextBox.Text })
            {
                store.Initialize();
                store.DatabaseCommands.ForDatabase(RavenDatabaseName).ResetIndex("Dogs/List");
            }
        }

        private void _addDogButton_Click(object sender, EventArgs e)
        {
            using (var store = new DocumentStore { Url = _ravenUrlTextBox.Text })
            {
                store.Initialize();
                store.DatabaseCommands.EnsureDatabaseExists(RavenDatabaseName);
                using (var session = store.OpenSession(RavenDatabaseName))
                {
                    session.Store(new Dog {Name = _dogNameTextBox.Text, Breed = _dogBreedTextBox.Text});
                    session.SaveChanges();
                }
            }
        }
    }

    public class Dogs_List : AbstractIndexCreationTask<Dog>
    {
        public Dogs_List()
        {
            Map = dogs => from d in dogs select new { Breed = d.Breed, Name = d.Name };
        }
    }

    public class Dog
    {
        public string Id { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
    }
}
