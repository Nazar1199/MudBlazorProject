﻿namespace BlazorAppNet8.Classes
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Blazor.Diagrams.Core.Geometry;
    using BlazorAppNet8.Components.MyNodes;
	using BlazorAppNet8.Components.MyNodes.Interfaces;

    public class NodePositionCalculator
	{
		// Ширина между нодами
		private const int HorizontalSpacing = 250;

		// Высота между нодами
		private const int VerticalSpacing = 250;

		private const int InitialX = 50;

		private const int InitialY = 50;

		private const int DiagramWidth = 250;

		public static Dictionary<int, Point> CalculatePositions(List<IHierarchyItem> HierarchyItems)
		{
			var positions = new Dictionary<int, Point>();

			var levels = GroupNodesByLevel(HierarchyItems);

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
		private static Dictionary<int, List<IHierarchyItem>> GroupNodesByLevel(List<IHierarchyItem> NodeItems)
		{
			var levels = new Dictionary<int, List<IHierarchyItem>>();

			var rootNodes = NodeItems.Where(d => !d.ParentId.HasValue).ToList();
			levels[0] = rootNodes;

			int currentLevel = 0;
			while (levels.ContainsKey(currentLevel))
			{
				var currentNodes = levels[currentLevel];
				var nextLevelNodes = new List<IHierarchyItem>();

				foreach (var node in currentNodes)
				{
					var children = NodeItems.Where(d => d.ParentId == node.Id).ToList();
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
	}
}
