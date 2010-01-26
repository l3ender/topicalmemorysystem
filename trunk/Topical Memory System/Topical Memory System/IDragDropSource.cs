﻿namespace Topical_Memory_System
{
	public interface IDragDropSource
	{
		string DragDropGroup { get; }
		bool IsDragDropCopySource { get; }
		bool IsDragDropMoveSource { get; }
		object[] GetSelectedItems();
		void RemoveSelectedItems(ref int rowIndexToAjust);
		void OnDropped(DroppedEventArgs e);
	}
}
