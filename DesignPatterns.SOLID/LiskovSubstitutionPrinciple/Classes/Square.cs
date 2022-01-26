namespace LiskovSubstitutionPrinciple.Classes
{
    public class Square : Rectangle
    {
        //public new int Width
        //{
        //    set { base.Width = base.Height = value; }
        //}

        //public new int Height
        //{
        //    set { base.Width = base.Height = value; }
        //}

        // ^^^^^^ BEFORE ^^^^^^


        // vvvvv  AFTER  vvvvv

        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
}
