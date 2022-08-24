using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public class TestClass
    {
        public class GuiaTransporte
        {
            public int Numero { get; set; }
            public string? DataEnvio { get; set; }
            public string? Estado { get; set; }
            public StockInfo? Unidades { get; set; }

        }
        public class StockInfo
        {
            public string Modelo { get; set; }
            public string Serie { get; set; }
            public string Imei { get; set; }
            public bool Entregue { get; set; }

            public StockInfo() { }

            public StockInfo(StockInfo stockInfo, bool changeAllData)
            {
                setData(stockInfo, changeAllData);
            }

            void setData(StockInfo stockInfo, bool changeAllData)
            {
                Modelo = stockInfo.Modelo;
                Serie = stockInfo.Serie;
                Imei = stockInfo.Imei;
                Entregue = (changeAllData == true) ? !stockInfo.Entregue : stockInfo.Entregue;



            }
        }
    }
}
