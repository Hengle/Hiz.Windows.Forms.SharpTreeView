using System;
using System.ComponentModel.Design;

using Aga.Controls.Tree.NodeControls;

namespace Aga.Controls.Design
{
	public class NodeControlCollectionEditor : CollectionEditor
	{
		private Type[] _types;

		public NodeControlCollectionEditor(Type type)
			: base(type)
		{
			_types = new Type[] { typeof(NodeTextBox), typeof(NodeIntegerTextBox), typeof(NodeDecimalTextBox),
				typeof(NodeComboBox), typeof(NodeCheckBox),
				typeof(NodeStateIcon), typeof(NodeIcon), typeof(NodeNumericUpDown), typeof(ExpandingIcon) };
		}

		protected override System.Type[] CreateNewItemTypes()
		{
			return _types;
		}
	}
}
