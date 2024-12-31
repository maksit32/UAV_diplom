using Microsoft.Extensions.Configuration;
using UAV_program.DbContexts;
using UAV_program.Domain.Exceptions;

namespace UAV_program
{
	public partial class EnterForm : Form
	{
		#region [Objects]
		//objects

		//configurations
		private static readonly IConfiguration configuration = new ConfigurationBuilder().AddUserSecrets<EnterForm>().Build();

		//connection string
		private static readonly string connectionString = configuration["PostgreSqlConnectionString"]
					?? throw new EmptyConnectionStringException("Connection string not found.");

		//services

		//CTS
		private static readonly CancellationTokenSource cts = new CancellationTokenSource();
		#endregion

		public EnterForm()
		{
			InitializeComponent();
		}

		#region [Methods]
		private void Form1_Load(object sender, EventArgs e)
		{

		}
		#endregion
	}
}

//Scoped + нужен repository
////развертка базы (Scoped lifetime)
//var config = new ConfigurationBuilder()
//.AddJsonFile(appSettingsPath, optional: false, reloadOnChange: true)
//.Build();
//using PostgreSqlDb postgreeDb = new PostgreSqlDb(connectionString: config.GetSection("PostgreeSqlConnectionString").Value ?? throw new NullReferenceException());
//и в репозиторий
