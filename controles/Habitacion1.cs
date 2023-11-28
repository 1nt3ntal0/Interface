namespace Interface.controles
{
    public class Habitacion1 : ProfessionalColorTable
    {
        private Color backColor;
        private Color leftColumnColor;
        private Color borderColor;
        private Color menuItemBorderColor;
        private Color menuItemSelectedColor;

        public Habitacion1(bool EsMenuP, Color primaryColor)
        {
            if (EsMenuP)
            {
                backColor = Color.FromArgb(37, 40, 70);
                leftColumnColor = Color.FromArgb(30, 32, 55);
                borderColor = Color.FromArgb(32, 43, 55);
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
            else
            {
                backColor = Color.White;
                leftColumnColor = Color.LightGray;
                borderColor = Color.LightGray;
                menuItemBorderColor = primaryColor;
                menuItemSelectedColor = primaryColor;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return backColor;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return borderColor;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return menuItemBorderColor;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return menuItemSelectedColor;
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return leftColumnColor;
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return leftColumnColor;
            }
        }
    }
}
