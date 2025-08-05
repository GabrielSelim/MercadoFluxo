namespace Projeto_Gabriel.Domain.Entity.Enum.Mercadinho
{
    public enum EUnidadeMedida
    {
        UN, // Unidade
        KG, // Quilograma
        G,  // Grama
        L,  // Litro
        ML  // Mililitro
    }

    public enum EStatusVenda
    {
        Concluida,
        Cancelada
    }

    public enum ETipoMovimentacaoCaixa
    {
        Abertura,
        Fechamento,
        Sangria,
        Suprimento
    }

    public enum ENivelAcesso
    {
        Caixa,
        Gerente,
        Administrador
    }
}
