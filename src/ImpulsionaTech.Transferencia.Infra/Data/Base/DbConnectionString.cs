using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpulsionaTech.Transferencia.Infra.Data.Base
{
  public interface IDbConnectionString
  {
    string? ConnectionString { get; set; }
    string? DatabaseName { get; set; }
  }

  public class DbConnectionString : IDbConnectionString
  {
    public string? ConnectionString { get; set; }
    public string? DatabaseName { get; set; }
  }
}
