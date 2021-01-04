using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagementSystem.database
{
	class Employee
	{
		[Key]
		public string username { get; set; }
		public string password { get; set; }

		public virtual ICollection<Sale> Sales { get; set; }

		public static Employee getEmployee(string dusername, string dpassword) {

			Employee employeeInfo;

			using (var context = new MngContext()) {
				
				employeeInfo = context.Employees.SqlQuery("Select username, password from Employees where username=@usr and password=@pwd", new SqlParameter("@usr", dusername), new SqlParameter("@pwd", dpassword)).FirstOrDefault<Employee>();

			}

			return employeeInfo;
		}

		public static void setEmployee(string dusername, string dpassword) {


			if (getEmployee(dusername, dpassword) == null) 
			{ //eklenecek çalışanın database de olup olmadığınıa bakılır. 
			
				using (var context = new MngContext())
				{

					Employee e = new Employee
					{
						username = dusername,
						password = dpassword,
					};
					
					context.Employees.Add(e);
					context.SaveChanges();

				}

			}

		}

	}
}
