namespace Totem.Models
{
    internal class FundoSingleton
    {
        public Fundo Fundo { get; set; }
        private FundoSingleton()
        {
            this.Fundo = new Fundo();
            this.Fundo.Visible = false;
        }

        public void ShowFundo()
        {
            if (Fundo.Visible == false)
            {
                instance.Fundo.Show();
            }
        }

        private static FundoSingleton instance;

        public static FundoSingleton Instance
        {

            get
            {
                if (instance == null)
                {
                    instance = new FundoSingleton();
                }
                return instance;
            }
        }
    }
}
