namespace AppBanco.Models
{
     public class Transacao
    {
        public Guid ID {get; set;} = new();
        public TipoTransacao Tipo {get; set;}
        public decimal Valor {get; set;}
        public DateTime Data {get; set;} = DateTime.Now;
        public string EmailDestino {get; set;} = string.Empty;
        public Guid? ContaOrigemId {get; set;}
        public Guid? ContaDestinoId{get; set;}
    }

}