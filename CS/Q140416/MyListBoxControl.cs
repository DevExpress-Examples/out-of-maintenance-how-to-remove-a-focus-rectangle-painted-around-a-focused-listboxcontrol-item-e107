using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.ViewInfo;

namespace DXSample {
    public class MyListBoxControl : ListBoxControl {
        public MyListBoxControl() : base() { }
        protected override BaseStyleControlViewInfo CreateViewInfo() { return new MyBaseListBoxViewInfo(this); }
    }

    public class MyListBoxItemPainter :ListBoxItemPainter {
        public MyListBoxItemPainter() : base() { }
        protected override void DrawItemBar(ListBoxItemObjectInfoArgs e) { e.PaintAppearance.FillRectangle(e.Cache, e.Bounds); }
    }

    public class MyBaseListBoxViewInfo :BaseListBoxViewInfo {
        public MyBaseListBoxViewInfo(BaseListBoxControl owner) : base(owner) { }

        protected override BaseListBoxItemPainter CreateItemPainter() {
            if (IsSkinnedHighlightingEnabled) return new MyListBoxSkinItemPainter();
            return new MyListBoxItemPainter();
        }
    }

    public class MyListBoxSkinItemPainter :ListBoxSkinItemPainter {
        public MyListBoxSkinItemPainter() : base() { }
        protected override void DrawItemBar(ListBoxItemObjectInfoArgs e) { DrawItemBarCore(e); }
    }
}