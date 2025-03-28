// AbstractDiagramBase.cs
using Blazor.Diagrams.Core.Models;
using Blazor.Diagrams.Core.PathGenerators;
using Blazor.Diagrams.Core.Routers;
using Blazor.Diagrams.Options;
using Blazor.Diagrams;
using BlazorAppNet8.Components.MyNodes.Interfaces;
using Microsoft.AspNetCore.Components;

public abstract class AbstractDiagramBase<TItem, TNode> : ComponentBase
	where TItem : IHierarchyItem
	where TNode : INode<TItem>
	{
		protected BlazorDiagram Diagram { get; set; } = null!;

		[Parameter]
		public List<TNode> Nodes { get; set; } = new();

		protected override void OnInitialized()
		{
			InitializeDiagram();
			base.OnInitialized();
		}

		protected virtual void InitializeDiagram()
		{
			var options = new BlazorDiagramOptions
			{
				AllowMultiSelection = false,
				Zoom = { Enabled = false },
				Links = { DefaultRouter = new NormalRouter(), DefaultPathGenerator = new StraightPathGenerator() }
			};

			Diagram = new BlazorDiagram(options);
			UpdateDiagram();
		}

		// Абстрактные методы, которые должны быть реализованы в потомках
		protected abstract NodeModel CreateDiagramNode(TNode node);
		protected abstract void AddLinkBetweenNodes(TNode source, TNode target);

		// Общая логика, которая может быть переопределена
		protected virtual void UpdateDiagram() { /* ... */ }
		protected virtual void RecalculatePositions() { /* ... */ }
	}