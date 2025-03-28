using BlazorAppNet8.Classes;
using BlazorAppNet8.Components.MyNodes.Interfaces;

namespace BlazorAppNet8.Classes
{
	public class Department : IHierarchyItem
	{
		public int Id { get; set; }
		public string Name { get; set; } = "";
		public int? ParentId { get; set; } = null;
	}
}
public class DepartmentGenerator
{
	public static List<Department> GenerateDepartments()
	{
		var departments = new List<Department>();

		departments.Add(new Department
		{
			Id = 0,
			Name = $"Корневое подразделение",
		});

		departments.Add(new Department
		{
			Id = -1,
			Name = $"Второе корневое подразделение",
		});

		for (int i = 1; i <= 5; i++)
		{
			departments.Add(new Department
			{
				Id = i,
				Name = $"Подразделение {i}",
				ParentId = 0
			});
		}

		int childId = 6;
		for (int i = 1; i <= 5; i++)
		{
			for (int j = 1; j <= 5; j++)
			{
				departments.Add(new Department
				{
					Id = childId,
					Name = $"Подразделение {childId} (Дочернее от {i})",
					ParentId = i
				});
				childId++;
			}
		}

		return departments;
	}
}
