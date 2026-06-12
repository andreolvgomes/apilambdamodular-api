namespace ApiLambdaModular.Endpoints.Vendas.Dtos;

public class CriarVendaRequest
{
    public string Cliente { get; set; }
}

public class ItemVendas
{
    public string Produto { get; set; }
}

public class BulkCancelarItensVenda
{
    public List<string> Itens { get; set; }
}

public class PagamentoVendaRequest
{
    public string Forma { get; set; }
}

public class BulkCancelarPagamentosVenda
{
    public List<string> Itens { get; set; }
}
