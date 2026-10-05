namespace AppBanco.Models
{
    public class HistoricoTransacao
    {
        private List<Transacao> _extrato {get;set;} = new();
        public IReadOnlyCollection<Transacao> Extrato => _extrato.AsReadOnly();
     

        //Vai gerenciar os tipos de movimentações realizadas
        protected void RegistrarMovimentecao(TipoTransacao tipo, decimal valor)
        {
            _extrato.Add(new Transacao{
                Tipo = tipo,
                Valor = valor,
            });
            
        }
    }
}