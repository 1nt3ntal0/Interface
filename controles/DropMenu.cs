using System.ComponentModel;

namespace Interface.controles
{
    public class DropMenu : ContextMenuStrip
    {
        private bool EsMenu1;
        private int menuItemHeight = 25;
        private Color menuItemColor = Color.DimGray;
        private Color primaryColor = Color.MediumSlateBlue;
        private Color menuItemTextColor;
        private Bitmap menuItemHeaderSize;

        public DropMenu()
        {
        }

        [Browsable(false)]
        public bool EsMenu
        {
            get => EsMenu1;
            set => EsMenu1 = value;
        }

        [Browsable(false)]
        public int MenuItemHeight
        {
            get => menuItemHeight;
            set => menuItemHeight = value;
        }

        [Browsable(false)]
        public Color MenuItemColor
        {
            get => menuItemColor;
            set => menuItemColor = value;
        }

        [Browsable(false)]
        public Color PrimaryColor
        {
            get => primaryColor;
            set => primaryColor = value;
        }

        private void LoadMenuItemAppearance()
        {
            if (EsMenu1)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                menuItemTextColor = Color.Chocolate;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeight);
            }
            foreach (ToolStripMenuItem MenuItem1 in this.Items)
            {
                MenuItem1.ForeColor = menuItemTextColor;
                MenuItem1.ImageScaling = ToolStripItemImageScaling.None;
                if (MenuItem1.Image == null) MenuItem1.Image = menuItemHeaderSize;
                foreach (ToolStripMenuItem MenuItem2 in MenuItem1.DropDownItems)
                {
                    MenuItem2.ForeColor = menuItemTextColor;
                    MenuItem2.ImageScaling = ToolStripItemImageScaling.None;
                    if (MenuItem2.Image == null) MenuItem2.Image = menuItemHeaderSize;
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!DesignMode)
            {
                LoadMenuItemAppearance();
                this.Renderer = new Renderisado(EsMenu, PrimaryColor, menuItemTextColor);
            }
        }
    }
}
