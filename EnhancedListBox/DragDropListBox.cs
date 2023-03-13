using System;
using System.Drawing;
using System.Windows.Forms;

namespace EnhancedListBox
{
    public partial class DragDropListBox : ListBox
    {
        private int prevSelectedIndex = -1;

        public DragDropListBox()
        {
            InitializeComponent();
            AllowDrop = true;
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            base.OnDragOver(e);
        }

        protected override void OnDragDrop(DragEventArgs e)
        {
            Point p = PointToClient(new Point(e.X, e.Y));
            int index = IndexFromPoint(p.X, p.Y);
            if (index < 0) index = Items.Count - 1;
            var data = SelectedItem;
            if (data == null) return;
            Items.Remove(data);
            Items.Insert(index, data);
            base.OnDragDrop(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (SelectedIndex >= 0)
            {
                DoDragDrop(SelectedItem, DragDropEffects.Move);
            }
            OnSelectedIndexChanged(e);
            base.OnMouseDown(e);
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            if (SelectedIndex != -1 && SelectedIndex == prevSelectedIndex) // снятие выделения при выборе уже выделенной ячейки
            {
                ClearSelected();
            }
            prevSelectedIndex = SelectedIndex;
        }
    }
}
