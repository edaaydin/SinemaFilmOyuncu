namespace BeyazPerdeForm
{
    public static class Yardimci
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                else if (item is DateTimePicker) ((DateTimePicker)item).Value = DateTime.Now;
                else if (item is GroupBox) Temizle(((GroupBox)item).Controls);
            }
        }
    }
}
