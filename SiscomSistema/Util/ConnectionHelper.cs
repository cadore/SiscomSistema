using DevExpress.XtraEditors;
using ServicoDeOperacaoClienteUsuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SiscomSistema.Util
{
    public static class ConnectionHelper
    {
        private static NetTcpBinding b;
        private static EndpointAddress vEndPoint;
        private static IService vService;
        public static IService iniciaConexao()
        {
            try
            {
                b = new NetTcpBinding();
                int _maxReceivedMessageSize = Convert.ToInt32(FilesINI.ReadValue("Host", "maxReceivedMessageSize"));
                b.MaxReceivedMessageSize = b.MaxReceivedMessageSize * _maxReceivedMessageSize;
                b.Security.Mode = SecurityMode.None;
                //b.Security.Message.ClientCredentialType = MessageCredentialType.None;
                string a = FilesINI.ReadValue("Host", "addressServer");
                vEndPoint = new EndpointAddress(a);
                ChannelFactory<IService> cf = new ChannelFactory<IService>(b, vEndPoint);

                return vService = cf.CreateChannel();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
