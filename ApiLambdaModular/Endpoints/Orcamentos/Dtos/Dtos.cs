namespace ApiLambdaModular.Endpoints.Orcamentos;

public class CriarOrcamentosRequest
{
    public string Cliente { get; set; }
}

public class ItemOrcamentos
{
    public string Produto { get; set; }
}

public class BulkCancelarItens
{
    public List<string> Itens { get; set; }
}

public class BulkRecuperarItens
{
    public List<string> Itens { get; set; }
}

public class CriarPagamentoOrcamentosRequest
{
    public string Forma { get; set; }
}

public class BulkCancelarPagamentos
{
    public List<string> Itens { get; set; }
}
