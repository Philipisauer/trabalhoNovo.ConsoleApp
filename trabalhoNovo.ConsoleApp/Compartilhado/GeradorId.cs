namespace trabalhoNovo.ConsoleApp.Compartilhado
{
    public static class GeradorId
    {
        public static int IdEquipamentos = 0;

        public static int GerarIDEquipamento()
        {
            IdEquipamentos++;

            return IdEquipamentos;
        }
    }
}
