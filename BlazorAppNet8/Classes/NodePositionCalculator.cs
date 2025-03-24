namespace BlazorAppNet8.Classes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Blazor.Diagrams.Core.Geometry;
    using BlazorAppNet8.Components.MyNodes;

    public class NodePositionCalculator
	{
		// Ширина между нодами
		private const int HorizontalSpacing = 250;

		// Высота между нодами
		private const int VerticalSpacing = 250;

		private const int InitialX = 50;

		private const int InitialY = 50;

		public static Dictionary<int, Point> CalculatePositions(List<Department> departments)
		{
			var positions = new Dictionary<int, Point>();

			var levels = GroupNodesByLevel(departments);

			foreach (var level in levels)
			{
				int levelIndex = level.Key;
				var nodesOnLevel = level.Value;

				int nodeCount = nodesOnLevel.Count;

				double totalWidth = nodeCount * HorizontalSpacing;

				double startX = InitialX + (DiagramWidth - totalWidth) / 2;

				double y = InitialY + levelIndex * VerticalSpacing;

				for (int i = 0; i < nodeCount; i++)
				{
					var department = nodesOnLevel[i];
					double x = startX + i * HorizontalSpacing;
					positions[department.Id] = new Point(x, y);
				}
			}

			return positions;
		}

		public static Dictionary<int, Point> CalculateVisiblePositions(List<DepartmentNode> visibleNodes)
		{
			var positions = new Dictionary<int, Point>();
			var levels = GroupNodesByLevel(visibleNodes);

			foreach (var level in levels)
			{
				int levelIndex = level.Key;
				var nodesOnLevel = level.Value;

				int nodeCount = nodesOnLevel.Count;
				double totalWidth = nodeCount * HorizontalSpacing;

				double startX = InitialX + (DiagramWidth - totalWidth) / 2;
				double y = InitialY + levelIndex * VerticalSpacing;

				for (int i = 0; i < nodeCount; i++)
				{
					var node = nodesOnLevel[i];
					double x = startX + i * HorizontalSpacing;
					positions[node.Department.Id] = new Point(x, y);
				}
			}

			return positions;
		}

		private static Dictionary<int, List<Department>> GroupNodesByLevel(List<Department> departments)
		{
			var levels = new Dictionary<int, List<Department>>();

			var rootNodes = departments.Where(d => !d.ParentId.HasValue).ToList();
			levels[0] = rootNodes;

			int currentLevel = 0;
			while (levels.ContainsKey(currentLevel))
			{
				var currentNodes = levels[currentLevel];
				var nextLevelNodes = new List<Department>();

				foreach (var node in currentNodes)
				{
					var children = departments.Where(d => d.ParentId == node.Id).ToList();
					nextLevelNodes.AddRange(children);
				}

				if (nextLevelNodes.Any())
				{
					levels[currentLevel + 1] = nextLevelNodes;
				}

				currentLevel++;
			}

			return levels;
		}

		private static Dictionary<int, List<DepartmentNode>> GroupNodesByLevel(List<DepartmentNode> visibleNodes)
		{
			var levels = new Dictionary<int, List<DepartmentNode>>();

			var rootNodes = visibleNodes.Where(n => !n.Department.ParentId.HasValue).ToList();
			levels[0] = rootNodes;

			int currentLevel = 0;
			while (levels.ContainsKey(currentLevel))
			{
				var currentNodes = levels[currentLevel];
				var nextLevelNodes = new List<DepartmentNode>();

				foreach (var node in currentNodes)
				{
					var children = visibleNodes.Where(n => n.Department.ParentId == node.Department.Id).ToList();
					nextLevelNodes.AddRange(children);
				}

				if (nextLevelNodes.Any())
				{
					levels[currentLevel + 1] = nextLevelNodes;
				}

				currentLevel++;
			}

			return levels;
		}

		private const int DiagramWidth = 250;
	}
}
