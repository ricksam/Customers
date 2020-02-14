using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Financeiro_Marcelo
{
  partial class dsBAL_BALANCO
  {
    public BAL_BALANCO[] GetList_UltimosFechamentos(int BAL_EMP_CODIGO) 
    {
      return GetList(
        string.Format(
        " select * from BAL_BALANCO "+
        " where BAL_EMP_CODIGO = {0} ORDER BY BAL_DATA DESC", BAL_EMP_CODIGO), 24);
    }

    public BAL_BALANCO[] GetList_UltimosFechamentos()
    {
      return GetList(
        string.Format(
        " select * from BAL_BALANCO " +
        " ORDER BY BAL_DATA DESC"), 24);
    }
  }
}
